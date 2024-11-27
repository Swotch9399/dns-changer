using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Net.NetworkInformation;
using System.Net.Http;
using IWshRuntimeLibrary;
using File = System.IO.File;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using dnschanger.Properties;
using System.Text.RegularExpressions;


namespace dnschanger
{
    public partial class dnschanger : Form
    {
        private const string AppName = "DNSChanger";

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public dnschanger()
        {
            InitializeComponent();
            InitializeTrayMenu();
            LoadAutoStartSetting();
        }

        private void InitializeTrayMenu()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(GetType(), "dnschanger.ico");
            trayIcon.Text = "DNS Changer";
            trayIcon.Visible = true;

            trayMenu = new ContextMenuStrip();
            var checkUpdatesMenuItem = new ToolStripMenuItem("Check for Updates", null, OnCheckForUpdates);
            trayMenu.Items.Add(checkUpdatesMenuItem);
            var showMenuItem = new ToolStripMenuItem("Show", null, OnShow);
            trayMenu.Items.Add(showMenuItem);
            var hideMenuItem = new ToolStripMenuItem("Hide", null, OnHide);
            trayMenu.Items.Add(hideMenuItem);
            trayMenu.Items.Add("Exit", null, OnExit);

            trayIcon.ContextMenuStrip = trayMenu;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                trayIcon.Visible = true;
            }

            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            trayIcon.Visible = false;
            base.OnFormClosed(e);
        }

        private void OnCheckForUpdates(object sender, EventArgs e)
        {
            CheckForUpdates(sender, e);
        }

        private void OnShow(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

            UpdateMenuItemStates();
        }

        private void OnHide(object sender, EventArgs e)
        {
            this.Hide();

            UpdateMenuItemStates();
        }

        private void OnExit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void UpdateMenuItemStates()
        {
            var showMenuItem = trayMenu.Items[1];
            var hideMenuItem = trayMenu.Items[2];
            if (this.Visible)
            {
                showMenuItem.Enabled = false;
                hideMenuItem.Enabled = true;
            }

            else
            {
                showMenuItem.Enabled = true;
                hideMenuItem.Enabled = false;
            }
        }

        private void dnschanger_Load(object sender, EventArgs e)
        {
            if (!IsRunningAsAdministrator())
            {
                MessageBox.Show("The application was not run as administrator. Run it again as administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private string GetSelectedNetworkInterface()
        {
            if (radioBtnEthernet.Checked)
            {
                return "Ethernet";
            }

            else if (radioBtnWiFi.Checked)
            {
                return "Wi-Fi";
            }

            return null;
        }

        private void btnChangeDNS_Click(object sender, EventArgs e)
        {
            string preferredDNS = txtPreferredDNS.Text.Trim();
            string alternateDNS = txtAlternateDNS.Text.Trim();
            string networkInterface = GetSelectedNetworkInterface();

            if (string.IsNullOrEmpty(preferredDNS) || string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please select primary DNS and network interface!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SetDNS(networkInterface, preferredDNS, alternateDNS);
                MessageBox.Show("DNS settings changed successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetDNS_Click(object sender, EventArgs e)
        {
            string networkInterface = GetSelectedNetworkInterface();

            if (string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please select network interface!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ResetDNS(networkInterface);
                MessageBox.Show("DNS settings reset to default!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartGoodbyeDPI_Click(object sender, EventArgs e)
        {
            string arguments = txtGoodbyeDPIArgs.Text.Trim();

            if (string.IsNullOrEmpty(arguments))
            {
                MessageBox.Show("Please enter arguments for GoodbyeDPI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                InstallAndRunGoodbyeDPI(arguments);
                MessageBox.Show("GoodbyeDPI launched successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopGoodbyeDPI_Click(object sender, EventArgs e)
        {
            try
            {
                StopGoodbyeDPI();
                MessageBox.Show("GoodbyeDPI successfully stopped!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIP.Text.Trim();

            if (string.IsNullOrEmpty(ipAddress))
            {
                MessageBox.Show("Please enter a valid IP address or domain name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(ipAddress);

                if (reply.Status == IPStatus.Success)
                {
                    MessageBox.Show($"Ping sent successfully!\n" +
                                    $"Target: {reply.Address}\n" +
                                    $"Delay: {reply.RoundtripTime} ms\n" +
                                    $"TTL: {reply.Options.Ttl}\n" +
                                    $"Size: {reply.Buffer.Length} byte", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Ping failed! Status: {reply.Status}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            CheckForUpdates(sender, e);
        }

        private void btnDeleteGoodbyeDPI_Click(object sender, EventArgs e)
        {
            try
            {
                string downloadPath = Path.Combine(Path.GetTempPath(), "goodbyedpi-0.2.3rc3-2.zip");
                string extractPath = Path.Combine(Path.GetTempPath(), "goodbyedpi-0.2.3rc3-2");

                if (File.Exists(downloadPath))
                {
                    try
                    {
                        File.Delete(downloadPath);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Directory.Exists(extractPath))
                {
                    try
                    {
                        Directory.Delete(extractPath, true);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("GoodbyeDPI has been removed successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoStart.Checked)
            {
                AddToStartup();
            }

            else
            {
                RemoveFromStartup();
            }
        }

        private void SetDNS(string interfaceName, string preferredDNS, string alternateDNS)
        {
            ExecuteCommand($"netsh interface ip set dns name=\"{interfaceName}\" static {preferredDNS}");

            if (!string.IsNullOrEmpty(alternateDNS))
            {
                ExecuteCommand($"netsh interface ip add dns name=\"{interfaceName}\" {alternateDNS} index=2");
            }
        }

        private void ResetDNS(string interfaceName)
        {
            ExecuteCommand($"netsh interface ip set dns name=\"{interfaceName}\" dhcp");
        }

        private void InstallAndRunGoodbyeDPI(string arguments)
        {
            string goodbyeDPIUrl = "https://github.com/ValdikSS/GoodbyeDPI/releases/download/0.2.3rc3/goodbyedpi-0.2.3rc3-2.zip";
            string downloadPath = Path.Combine(Path.GetTempPath(), "goodbyedpi-0.2.3rc3-2.zip");
            string extractPath = Path.Combine(Path.GetTempPath(), "goodbyedpi-0.2.3rc3-2");

            string projectGoodbyeDPIExecutable = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "goodbyedpi-0.2.3rc3-2", "x86", "goodbyedpi.exe");

            if (!File.Exists(Path.Combine(extractPath, "goodbyedpi.exe")))
            {
                if (!File.Exists(downloadPath))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(goodbyeDPIUrl, downloadPath);
                    }
                }

                if (!Directory.Exists(extractPath))
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(downloadPath, extractPath);
                }
            }

            string goodbyeDPIExecutable = Path.Combine(extractPath, "goodbyedpi-0.2.3rc3-2", "x86", "goodbyedpi.exe");

            if (!File.Exists(goodbyeDPIExecutable))
            {
                if (File.Exists(projectGoodbyeDPIExecutable))
                {
                    MessageBox.Show("'GoodbyeDPI' was not found in the temporary directory. The file within the project is being run.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    goodbyeDPIExecutable = projectGoodbyeDPIExecutable;
                }

                else
                {
                    throw new Exception("GoodbyeDPI executable not found!");
                }
            }

            Process process = new Process();
            process.StartInfo.FileName = goodbyeDPIExecutable;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WorkingDirectory = Path.GetDirectoryName(goodbyeDPIExecutable);
            process.StartInfo.CreateNoWindow = !chkShowConsole.Checked;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        private void StopGoodbyeDPI()
        {
            foreach (var process in Process.GetProcessesByName("goodbyedpi"))
            {
                process.Kill();
                process.WaitForExit();
            }

            foreach (var process in Process.GetProcessesByName("WinDivert"))
            {
                process.Kill();
                process.WaitForExit();
            }

            ExecuteCommand($"sc stop WinDivert");
        }

        private async void CheckForUpdates(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://api.github.com/repos/swotch9399/dns-changer/releases/latest";

                var releaseInfo = await GetLatestReleaseFromGitHubAsync(apiUrl);

                var currentVersion = Application.ProductVersion;

                var latestVersion = releaseInfo.Item1;
                var downloadUrl = releaseInfo.Item2;

                var latestVersionWithoutV = latestVersion.StartsWith("v") ? latestVersion.Substring(1) : latestVersion;

                if (new Version(latestVersionWithoutV) > new Version(currentVersion))
                {
                    DialogResult result = MessageBox.Show($"A new version is available!\n( Current version: {currentVersion}, New version: {latestVersion} )\nWould you like to download now?", "Update Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(downloadUrl);
                    }
                }

                else
                {
                    MessageBox.Show("Your app is at the latest version.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Tuple<string, string>> GetLatestReleaseFromGitHubAsync(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");

                var response = await client.GetStringAsync(url);

                var tagRegex = new Regex("\"tag_name\"\\s*:\\s*\"(.*?)\"");
                var tagMatch = tagRegex.Match(response);
                var latestVersion = tagMatch.Success ? tagMatch.Groups[1].Value : "Unknown";

                var downloadUrlRegex = new Regex("\"browser_download_url\"\\s*:\\s*\"(.*?)\"");
                var downloadMatch = downloadUrlRegex.Match(response);
                var downloadUrl = downloadMatch.Success ? downloadMatch.Groups[1].Value : "Unknown";

                return new Tuple<string, string>(latestVersion, downloadUrl);
            }
        }

        private void LoadAutoStartSetting()
        {
            string shortcutPath = GetStartupShortcutPath();
            chkAutoStart.Checked = File.Exists(shortcutPath);
        }

        private void AddToStartup()
        {
            try
            {
                string shortcutPath = GetStartupShortcutPath();
                string exePath = Application.ExecutablePath;

                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.WorkingDirectory = Path.GetDirectoryName(exePath);
                shortcut.Save();

                MessageBox.Show("The application is set to run on startup.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStartupShortcutPath()
        {
            string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            return Path.Combine(startupFolderPath, $"{AppName}.lnk");
        }

        private void RemoveFromStartup()
        {
            try
            {
                string shortcutPath = GetStartupShortcutPath();

                if (File.Exists(shortcutPath))
                {
                    File.Delete(shortcutPath);
                    MessageBox.Show("Startup is disabled.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsRunningAsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void ExecuteCommand(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C {command}";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new Exception($"The command could not be run: {error}");
            }
        }
    }
}
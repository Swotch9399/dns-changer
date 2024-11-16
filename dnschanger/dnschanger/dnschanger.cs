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
using System.Net.Http;


namespace dnschanger
{
    public partial class dnschanger : Form
    {
        public dnschanger()
        {
            InitializeComponent();
        }

        private void dnschanger_Load(object sender, EventArgs e)
        {
            if (!IsRunningAsAdministrator())
            {
                MessageBox.Show("The application was not run as administrator. Run it again as administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void btnChangeDNS_Click(object sender, EventArgs e)
        {
            string preferredDNS = txtPreferredDNS.Text.Trim();
            string alternateDNS = txtAlternateDNS.Text.Trim();
            string networkInterface = txtNetworkInterface.Text.Trim();

            if (string.IsNullOrEmpty(preferredDNS) || string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please enter the primary DNS and network interface name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string networkInterface = txtNetworkInterface.Text.Trim();

            if (string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please enter the network interface name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnStartGoodbyeDPI_Click(object sender, EventArgs e)
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

            string nestedPath = Path.Combine(extractPath, "goodbyedpi-0.2.3rc3-2", "x86");
            string goodbyeDPIExecutable = Path.Combine(nestedPath, "goodbyedpi.exe");

            if (!File.Exists(goodbyeDPIExecutable))
            {
                throw new Exception("GoodbyeDPI executable not found!");
            }

            Process process = new Process();
            process.StartInfo.FileName = goodbyeDPIExecutable;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WorkingDirectory = nestedPath;
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

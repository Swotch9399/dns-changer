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
using dnschanger.Properties;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Security.Cryptography;


namespace dnschanger
{
    public partial class DNSChanger : Form
    {
        private const string AppName = "DNSChanger";
        private string executablePath = Application.ExecutablePath;

        private string defaultPreferredIPv4DNS = "1.1.1.1";
        private string defaultAlternateIPv4DNS = "1.0.0.1";

        private string defaultPreferredIPv6DNS = "2606:4700:4700::1111";
        private string defaultAlternateIPv6DNS = "2606:4700:4700::1001";

        private string defaultGoodbyeDPIArgs = "-5 --set-ttl 5 --dns-addr 77.88.8.8 --dns-port 1253 --dnsv6-addr 2a02:6b8::feed:0ff --dnsv6-port 1253";

        private string defaultIP = "1.1.1.1";

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public DNSChanger()
        {
            InitializeComponent();
            InitializeTrayMenu();
            Application.ApplicationExit += OnApplicationExit;
        }

        private void InitializeTrayMenu()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(GetType(), "dnschanger.ico");
            trayIcon.Text = "DNS Changer";
            trayIcon.Visible = true;

            trayMenu = new ContextMenuStrip();

            var checkUpdatesMenuItem = new ToolStripMenuItem("Check for Updates", null, OnCheckForUpdates);
            checkUpdatesMenuItem.Enabled = true;
            trayMenu.Items.Add(checkUpdatesMenuItem);
            var connectMenuItem = new ToolStripMenuItem("Connect", null, OnConnect);
            connectMenuItem.Enabled = true;
            trayMenu.Items.Add(connectMenuItem);
            var disconnectMenuItem = new ToolStripMenuItem("Disconnect", null, OnDisconnect);
            disconnectMenuItem.Enabled = false;
            trayMenu.Items.Add(disconnectMenuItem);
            var showMenuItem = new ToolStripMenuItem("Show", null, OnShow);
            showMenuItem.Enabled = false;
            trayMenu.Items.Add(showMenuItem);
            var hideMenuItem = new ToolStripMenuItem("Hide", null, OnHide);
            hideMenuItem.Enabled = true;
            trayMenu.Items.Add(hideMenuItem);
            var exitMenuItem = new ToolStripMenuItem("Exit", null, OnExit);
            exitMenuItem.Enabled = true;
            trayMenu.Items.Add(exitMenuItem);

            trayIcon.ContextMenuStrip = trayMenu;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            StopGoodbyeDPI();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                trayIcon.Visible = true;

                var showMenuItem = trayMenu.Items[3];
                var hideMenuItem = trayMenu.Items[4];
                showMenuItem.Enabled = true;
                hideMenuItem.Enabled = false;
            }

            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            trayIcon.Visible = false;
            base.OnFormClosed(e);
        }

        private async void OnConnect(object sender, EventArgs e)
        {
            var connectMenuItem = trayMenu.Items[1];
            var disconnectMenuItem = trayMenu.Items[2];

            connectMenuItem.Enabled = false;
            disconnectMenuItem.Enabled = true;

            string preferredDNSIPv4 = txtPreferredIPv4DNS.Text.Trim();
            string alternateDNSIPv4 = txtAlternateIPv4DNS.Text.Trim();
            string networkInterfaceIPv4 = GetSelectedIPv4NetworkInterface();

            string preferredDNSIPv6 = txtPreferredIPv6DNS.Text.Trim();
            string alternateDNSIPv6 = txtAlternateIPv6DNS.Text.Trim();
            string networkInterfaceIPv6 = GetSelectedIPv6NetworkInterface();

            string arguments = txtGoodbyeDPIArgs.Text.Trim();

            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = "Connecting...";

            await Task.Delay(1000);

            if (string.IsNullOrEmpty(preferredDNSIPv4) || string.IsNullOrEmpty(networkInterfaceIPv4))
            {
                MessageBox.Show("Please select primary DNS and network interface for IPv4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(preferredDNSIPv6) || string.IsNullOrEmpty(networkInterfaceIPv6))
            {
                MessageBox.Show("Please select primary DNS and network interface for IPv6!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(arguments))
            {
                MessageBox.Show("Please enter arguments for GoodbyeDPI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IPv4SetDNS(networkInterfaceIPv4, preferredDNSIPv4, alternateDNSIPv4);
                IPv6SetDNS(networkInterfaceIPv6, preferredDNSIPv6, alternateDNSIPv6);
                InstallAndStartGoodbyeDPI(arguments);

                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.Green;
            }

            catch (Exception ex)
            {
                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void OnDisconnect(object sender, EventArgs e)
        {
            var connectMenuItem = trayMenu.Items[1];
            var disconnectMenuItem = trayMenu.Items[2];

            connectMenuItem.Enabled = true;
            disconnectMenuItem.Enabled = false;

            string networkInterfaceIPv4 = GetSelectedIPv4NetworkInterface();
            string networkInterfaceIPv6 = GetSelectedIPv6NetworkInterface();

            if (string.IsNullOrEmpty(networkInterfaceIPv4))
            {
                MessageBox.Show("Please select network interface for IPv4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(networkInterfaceIPv6))
            {
                MessageBox.Show("Please select network interface for IPv6!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = "Disconnecting...";

            await Task.Delay(1000);

            try
            {
                IPv4ResetDNS(networkInterfaceIPv4);
                IPv6ResetDNS(networkInterfaceIPv6);
                StopGoodbyeDPI();

                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = Color.Red;
            }

            catch (Exception ex)
            {
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.Green;
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            var showMenuItem = trayMenu.Items[3];
            var hideMenuItem = trayMenu.Items[4];

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
                DialogResult result = MessageBox.Show("The application was not run as administrator. Run it again as administrator ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    RestartAsAdmin();
                }

                else
                {
                    Application.Exit();
                }
            }

            chkRememberSettings.Checked = Properties.Settings.Default.RememberSettings;

            if (Properties.Settings.Default.RememberSettings)
            {
                txtPreferredIPv4DNS.Text = Properties.Settings.Default.PreferredIPv4DNS;
                txtAlternateIPv4DNS.Text = Properties.Settings.Default.AlternateIPv4DNS;
                txtPreferredIPv6DNS.Text = Properties.Settings.Default.PreferredIPv6DNS;
                txtAlternateIPv6DNS.Text = Properties.Settings.Default.AlternateIPv6DNS;
                txtGoodbyeDPIArgs.Text = Properties.Settings.Default.GoodbyeDPIArgs;
                txtIP.Text = Properties.Settings.Default.IPAddress;
            }
        }

        private async void btnQuickConnect_Click(object sender, EventArgs e)
        {
            var connectMenuItem = trayMenu.Items[1];
            var disconnectMenuItem = trayMenu.Items[2];

            connectMenuItem.Enabled = false;
            disconnectMenuItem.Enabled = true;

            string preferredDNSIPv4 = txtPreferredIPv4DNS.Text.Trim();
            string alternateDNSIPv4 = txtAlternateIPv4DNS.Text.Trim();
            string networkInterfaceIPv4 = GetSelectedIPv4NetworkInterface();

            string preferredDNSIPv6 = txtPreferredIPv6DNS.Text.Trim();
            string alternateDNSIPv6 = txtAlternateIPv6DNS.Text.Trim();
            string networkInterfaceIPv6 = GetSelectedIPv6NetworkInterface();

            string arguments = txtGoodbyeDPIArgs.Text.Trim();

            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = "Connecting...";

            await Task.Delay(1000);

            if (string.IsNullOrEmpty(preferredDNSIPv4) || string.IsNullOrEmpty(networkInterfaceIPv4))
            {
                MessageBox.Show("Please select primary DNS and network interface for IPv4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(preferredDNSIPv6) || string.IsNullOrEmpty(networkInterfaceIPv6))
            {
                MessageBox.Show("Please select primary DNS and network interface for IPv6!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(arguments))
            {
                MessageBox.Show("Please enter arguments for GoodbyeDPI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IPv4SetDNS(networkInterfaceIPv4, preferredDNSIPv4, alternateDNSIPv4);
                IPv6SetDNS(networkInterfaceIPv6, preferredDNSIPv6, alternateDNSIPv6);
                InstallAndStartGoodbyeDPI(arguments);

                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.Green;
            }

            catch (Exception ex)
            {
                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnQuickDisconnect_Click(object sender, EventArgs e)
        {
            var connectMenuItem = trayMenu.Items[1];
            var disconnectMenuItem = trayMenu.Items[2];

            connectMenuItem.Enabled = true;
            disconnectMenuItem.Enabled = false;

            string networkInterfaceIPv4 = GetSelectedIPv4NetworkInterface();
            string networkInterfaceIPv6 = GetSelectedIPv6NetworkInterface();

            if (string.IsNullOrEmpty(networkInterfaceIPv4))
            {
                MessageBox.Show("Please select network interface for IPv4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(networkInterfaceIPv6))
            {
                MessageBox.Show("Please select network interface for IPv6!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = "Disconnecting...";

            await Task.Delay(1000);

            try
            {
                IPv4ResetDNS(networkInterfaceIPv4);
                IPv6ResetDNS(networkInterfaceIPv6);
                StopGoodbyeDPI();

                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = Color.Red;
            }

            catch (Exception ex)
            {
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.Green;
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPreferredIPv4DNS_TextChanged(object sender, EventArgs e)
        {
            if (chkRememberSettings.Checked)
            {
                Properties.Settings.Default.PreferredIPv4DNS = txtPreferredIPv4DNS.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtAlternateIPv4DNS_TextChanged(object sender, EventArgs e)
        {
            if (chkRememberSettings.Checked)
            {
                Properties.Settings.Default.AlternateIPv4DNS = txtAlternateIPv4DNS.Text;
                Properties.Settings.Default.Save();
            }
        }

        private string GetSelectedIPv4NetworkInterface()
        {
            if (radioBtnIPv4Ethernet.Checked)
            {
                return "Ethernet";
            }

            if (radioBtnIPv4WiFi.Checked)
            {
                return "Wi-Fi";
            }

            if (radioBtnIPv4Auto.Checked)
            {
                string connectionType = GetNetworkConnectionType();

                if (connectionType == "Ethernet")
                {
                    return "Ethernet";
                }

                else if (connectionType == "Wi-Fi")
                {
                    return "Wi-Fi";
                }
            }

            return null;
        }

        private void btnPreferredIPv4DNSDefault_Click(object sender, EventArgs e)
        {
            txtPreferredIPv4DNS.Text = defaultPreferredIPv4DNS;
        }

        private void btnAlternateIPv4DNSDefault_Click(object sender, EventArgs e)
        {
            txtAlternateIPv4DNS.Text = defaultAlternateIPv4DNS;
        }

        private void btnChangeIPv4DNS_Click(object sender, EventArgs e)
        {
            string preferredDNS = txtPreferredIPv4DNS.Text.Trim();
            string alternateDNS = txtAlternateIPv4DNS.Text.Trim();
            string networkInterface = GetSelectedIPv4NetworkInterface();

            if (string.IsNullOrEmpty(preferredDNS) || string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please select primary DNS and network interface!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IPv4SetDNS(networkInterface, preferredDNS, alternateDNS);
                MessageBox.Show("DNS settings changed successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetIPv4DNS_Click(object sender, EventArgs e)
        {
            string networkInterface = GetSelectedIPv4NetworkInterface();

            if (string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please select network interface!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IPv4ResetDNS(networkInterface);
                MessageBox.Show("DNS settings reset to default!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPreferredIPv6DNS_TextChanged(object sender, EventArgs e)
        {
            if (chkRememberSettings.Checked)
            {
                Properties.Settings.Default.PreferredIPv6DNS = txtPreferredIPv6DNS.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtAlternateIPv6DNS_TextChanged(object sender, EventArgs e)
        {
            if (chkRememberSettings.Checked)
            {
                Properties.Settings.Default.AlternateIPv6DNS = txtAlternateIPv6DNS.Text;
                Properties.Settings.Default.Save();
            }
        }

        private string GetSelectedIPv6NetworkInterface()
        {
            if (radioBtnIPv6Ethernet.Checked)
            {
                return "Ethernet";
            }

            else if (radioBtnIPv6WiFi.Checked)
            {
                return "Wi-Fi";
            }

            if (radioBtnIPv6Auto.Checked)
            {
                string connectionType = GetNetworkConnectionType();

                if (connectionType == "Ethernet")
                {
                    return "Ethernet";
                }

                else if (connectionType == "Wi-Fi")
                {
                    return "Wi-Fi";
                }
            }

            return null;
        }

        private void btnPreferredIPv6DNSDefault_Click(object sender, EventArgs e)
        {
            txtPreferredIPv6DNS.Text = defaultPreferredIPv6DNS;
        }

        private void btnAlternateIPv6DNSDefault_Click(object sender, EventArgs e)
        {
            txtAlternateIPv6DNS.Text = defaultAlternateIPv6DNS;
        }

        private void btnChangeIPv6DNS_Click(object sender, EventArgs e)
        {
            string preferredDNS = txtPreferredIPv6DNS.Text.Trim();
            string alternateDNS = txtAlternateIPv6DNS.Text.Trim();
            string networkInterface = GetSelectedIPv6NetworkInterface();

            if (string.IsNullOrEmpty(preferredDNS) || string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please select primary DNS and network interface!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IPv6SetDNS(networkInterface, preferredDNS, alternateDNS);
                MessageBox.Show("DNS settings changed successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetIPv6DNS_Click(object sender, EventArgs e)
        {
            string networkInterface = GetSelectedIPv6NetworkInterface();

            if (string.IsNullOrEmpty(networkInterface))
            {
                MessageBox.Show("Please select network interface!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IPv6ResetDNS(networkInterface);
                MessageBox.Show("DNS settings reset to default!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGoodbyeDPIArgs_TextChanged(object sender, EventArgs e)
        {
            if (chkRememberSettings.Checked)
            {
                Properties.Settings.Default.GoodbyeDPIArgs = txtGoodbyeDPIArgs.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnGoodbyeDPIArgsDefault_Click(object sender, EventArgs e)
        {
            txtGoodbyeDPIArgs.Text = defaultGoodbyeDPIArgs;
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
                InstallAndStartGoodbyeDPI(arguments);
                MessageBox.Show("GoodbyeDPI launched successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServiceInstallGoodbyeDPI_Click(object sender, EventArgs e)
        {
            string arguments = txtGoodbyeDPIArgs.Text.Trim();

            if (string.IsNullOrEmpty(arguments))
            {
                MessageBox.Show("Please enter arguments for GoodbyeDPI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ServiceInstallGoodbyeDPI(arguments);
                MessageBox.Show("Goodbye DPI services successfully installed!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServiceDeleteGoodbyeDPI_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceDeleteGoodbyeDPI();
                MessageBox.Show("GoodbyeDPI services successfully deleted!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteGoodbyeDPI_Click(object sender, EventArgs e)
        {
            if (IsProcessRunning("goodbyedpi") || IsProcessRunning("WinDivert") || IsProcessRunning("WinDivert14"))
            {
                StopGoodbyeDPI();
                ServiceDeleteGoodbyeDPI();
                DeleteGoodbyeDPI();
            }

            else
            {
                ServiceDeleteGoodbyeDPI();
                DeleteGoodbyeDPI();
            }
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            if (chkRememberSettings.Checked)
            {
                Properties.Settings.Default.IPAddress = txtIP.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnIPDefault_Click(object sender, EventArgs e)
        {
            txtIP.Text = defaultIP;
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
                    MessageBox.Show($"Ping sent successfully!\n" + $"Target: {reply.Address}\n" + $"Delay: {reply.RoundtripTime} ms\n" + $"TTL: {reply.Options.Ttl}\n" + $"Size: {reply.Buffer.Length} byte", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Ping failed! Status: {reply.Status}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            CheckForUpdates(sender, e);
        }

        private void btnClearDNSCache_Click(object sender, EventArgs e)
        {
            try
            {
                ClearDNSCache();
                MessageBox.Show("DNS cache cleared.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkRememberSettings_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberSettings = chkRememberSettings.Checked;
            Properties.Settings.Default.Save();

            if (!chkRememberSettings.Checked)
            {
                Properties.Settings.Default.PreferredIPv4DNS = defaultPreferredIPv4DNS;
                Properties.Settings.Default.AlternateIPv4DNS = defaultAlternateIPv4DNS;
                Properties.Settings.Default.PreferredIPv6DNS = defaultPreferredIPv6DNS;
                Properties.Settings.Default.AlternateIPv6DNS = defaultAlternateIPv6DNS;
                Properties.Settings.Default.GoodbyeDPIArgs = defaultGoodbyeDPIArgs;
                Properties.Settings.Default.IPAddress = defaultIP;
                Properties.Settings.Default.Save();
            }
        }

        private string GetNetworkConnectionType()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        return "Ethernet";
                    }

                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        return "Wi-Fi";
                    }
                }
            }

            return null;
        }

        private async void IPv4SetDNS(string interfaceName, string preferredDNS, string alternateDNS)
        {
            try
            {
                ExecuteCommand($"netsh interface ip set dns name=\"{interfaceName}\" static {preferredDNS}");

                if (!string.IsNullOrEmpty(alternateDNS))
                {
                    ExecuteCommand($"netsh interface ip add dns name=\"{interfaceName}\" {alternateDNS} index=2");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void IPv4ResetDNS(string interfaceName)
        {
            try
            {
                ExecuteCommand($"netsh interface ip set dns name=\"{interfaceName}\" dhcp");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void IPv6SetDNS(string interfaceName, string preferredDNS, string alternateDNS)
        {
            try
            {
                ExecuteCommand($"netsh interface ipv6 set dns name=\"{interfaceName}\" static {preferredDNS}");

                if (!string.IsNullOrEmpty(alternateDNS))
                {
                    ExecuteCommand($"netsh interface ipv6 add dns name=\"{interfaceName}\" {alternateDNS} index=2");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void IPv6ResetDNS(string interfaceName)
        {
            try
            {
                ExecuteCommand($"netsh interface ipv6 set dns name=\"{interfaceName}\" dhcp");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<(string executablePath, string downloadPath, string extractPath)> DownloadAndExtractGoodbyeDPI()
        {
            string goodbyeDPIUrl = "https://github.com/ValdikSS/GoodbyeDPI/releases/download/0.2.3rc3/goodbyedpi-0.2.3rc3-2.zip";
            string downloadPath = Path.Combine(Path.GetTempPath(), "goodbyedpi-0.2.3rc3-2.zip");
            string extractPath = Path.Combine(Path.GetTempPath(), "goodbyedpi-0.2.3rc3-2");
            string architecture = Environment.Is64BitOperatingSystem ? "x86_64" : "x86";
            string goodbyeDPIExecutable = Path.Combine(extractPath, "goodbyedpi-0.2.3rc3-2", architecture, "goodbyedpi.exe");
            string projectGoodbyeDPIExecutable = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "goodbyedpi-0.2.3rc3-2", architecture, "goodbyedpi.exe");

            try
            {
                if (!File.Exists(goodbyeDPIExecutable))
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
                        Directory.CreateDirectory(extractPath);
                        ZipFile.ExtractToDirectory(downloadPath, extractPath);
                    }
                }

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
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null, null);
            }

            return (goodbyeDPIExecutable, downloadPath, extractPath);
        }

        private async void InstallAndStartGoodbyeDPI(string arguments)
        {
            var (goodbyeDPIExecutable, downloadPath, extractPath) = await DownloadAndExtractGoodbyeDPI();

            if (string.IsNullOrEmpty(goodbyeDPIExecutable))
            {
                return;
            }

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = goodbyeDPIExecutable;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(goodbyeDPIExecutable);
                process.StartInfo.CreateNoWindow = !chkShowConsole.Checked;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Verb = "runas";
                process.Start();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            foreach (var process in Process.GetProcessesByName("WinDivert14"))
            {
                process.Kill();
                process.WaitForExit();
            }

            ExecuteCommand($"sc stop GoodbyeDPI");
            ExecuteCommand($"sc stop WinDivert");
            ExecuteCommand($"sc stop WinDivert14");
        }

        private async void ServiceInstallGoodbyeDPI(string arguments)
        {
            var (goodbyeDPIExecutable, downloadPath, extractPath) = await DownloadAndExtractGoodbyeDPI();

            if (string.IsNullOrEmpty(goodbyeDPIExecutable))
            {
                return;
            }

            ServiceDeleteGoodbyeDPI();
            ExecuteCommand($"sc create GoodbyeDPI binPath= \"{goodbyeDPIExecutable} {arguments}\" start= auto");
        }

        private async void ServiceDeleteGoodbyeDPI()
        {
            StopGoodbyeDPI();
            ExecuteCommand($"sc delete GoodbyeDPI");
            ExecuteCommand($"sc delete WinDivert");
            ExecuteCommand($"sc delete WinDivert14");
        }

        private async void DeleteGoodbyeDPI()
        {
            var (goodbyeDPIExecutable, downloadPath, extractPath) = await DownloadAndExtractGoodbyeDPI();

            try
            {
                if (File.Exists(downloadPath))
                {
                    try
                    {
                        File.Delete(downloadPath);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("GoodbyeDPI has been removed successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void ClearDNSCache()
        {
            try
            {
                ExecuteCommand($"ipconfig /flushdns");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsRunningAsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private bool IsProcessRunning(string processName)
        {
            return Process.GetProcessesByName(processName).Any();
        }

        private void RestartAsAdmin()
        {
            try
            {
                var exePath = Application.ExecutablePath;
                var processStartInfo = new ProcessStartInfo(exePath)
                {
                    Verb = "runas",
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);
                Application.Exit();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }
    }
}
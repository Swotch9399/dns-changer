namespace dnschanger
{
    partial class dnschanger
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dnschanger));
            this.dpıSettigsGroupBox = new System.Windows.Forms.GroupBox();
            this.chkShowConsole = new System.Windows.Forms.CheckBox();
            this.btnStopGoodbyeDPI = new System.Windows.Forms.Button();
            this.btnStartGoodbyeDPI = new System.Windows.Forms.Button();
            this.argumentLabel = new System.Windows.Forms.Label();
            this.txtGoodbyeDPIArgs = new System.Windows.Forms.TextBox();
            this.dnsSettigsGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnEthernet = new System.Windows.Forms.RadioButton();
            this.radioBtnWiFi = new System.Windows.Forms.RadioButton();
            this.btnResetDNS = new System.Windows.Forms.Button();
            this.btnChangeDNS = new System.Windows.Forms.Button();
            this.preferredDnsLabel = new System.Windows.Forms.Label();
            this.txtPreferredDNS = new System.Windows.Forms.TextBox();
            this.networkInterfaceLabel = new System.Windows.Forms.Label();
            this.alternativeDnsLabel = new System.Windows.Forms.Label();
            this.txtAlternateDNS = new System.Windows.Forms.TextBox();
            this.pingTestGroupBox = new System.Windows.Forms.GroupBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.recommendedDnsGroupBox = new System.Windows.Forms.GroupBox();
            this.openDnsGroupBox = new System.Windows.Forms.GroupBox();
            this.openDnsLabel = new System.Windows.Forms.Label();
            this.googleDnsGroupBox = new System.Windows.Forms.GroupBox();
            this.googleDnsLabel = new System.Windows.Forms.Label();
            this.cloudflareDnsGroupBox = new System.Windows.Forms.GroupBox();
            this.cloudflareDnsLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.appSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnCheckForUpdates = new System.Windows.Forms.Button();
            this.btnDeleteGoodbyeDPI = new System.Windows.Forms.Button();
            this.dpıSettigsGroupBox.SuspendLayout();
            this.dnsSettigsGroupBox.SuspendLayout();
            this.pingTestGroupBox.SuspendLayout();
            this.recommendedDnsGroupBox.SuspendLayout();
            this.openDnsGroupBox.SuspendLayout();
            this.googleDnsGroupBox.SuspendLayout();
            this.cloudflareDnsGroupBox.SuspendLayout();
            this.appSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpıSettigsGroupBox
            // 
            this.dpıSettigsGroupBox.Controls.Add(this.chkShowConsole);
            this.dpıSettigsGroupBox.Controls.Add(this.btnStopGoodbyeDPI);
            this.dpıSettigsGroupBox.Controls.Add(this.btnStartGoodbyeDPI);
            this.dpıSettigsGroupBox.Controls.Add(this.argumentLabel);
            this.dpıSettigsGroupBox.Controls.Add(this.txtGoodbyeDPIArgs);
            this.dpıSettigsGroupBox.Location = new System.Drawing.Point(12, 171);
            this.dpıSettigsGroupBox.Name = "dpıSettigsGroupBox";
            this.dpıSettigsGroupBox.Size = new System.Drawing.Size(412, 121);
            this.dpıSettigsGroupBox.TabIndex = 16;
            this.dpıSettigsGroupBox.TabStop = false;
            this.dpıSettigsGroupBox.Text = "GoodbyeDPI Settings";
            // 
            // chkShowConsole
            // 
            this.chkShowConsole.AutoSize = true;
            this.chkShowConsole.Location = new System.Drawing.Point(160, 98);
            this.chkShowConsole.Name = "chkShowConsole";
            this.chkShowConsole.Size = new System.Drawing.Size(94, 17);
            this.chkShowConsole.TabIndex = 14;
            this.chkShowConsole.Text = "Show Console";
            this.chkShowConsole.UseVisualStyleBackColor = true;
            // 
            // btnStopGoodbyeDPI
            // 
            this.btnStopGoodbyeDPI.Location = new System.Drawing.Point(147, 68);
            this.btnStopGoodbyeDPI.Name = "btnStopGoodbyeDPI";
            this.btnStopGoodbyeDPI.Size = new System.Drawing.Size(114, 23);
            this.btnStopGoodbyeDPI.TabIndex = 13;
            this.btnStopGoodbyeDPI.Text = "Stop";
            this.btnStopGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnStopGoodbyeDPI.Click += new System.EventHandler(this.btnStopGoodbyeDPI_Click);
            // 
            // btnStartGoodbyeDPI
            // 
            this.btnStartGoodbyeDPI.Location = new System.Drawing.Point(147, 39);
            this.btnStartGoodbyeDPI.Name = "btnStartGoodbyeDPI";
            this.btnStartGoodbyeDPI.Size = new System.Drawing.Size(114, 23);
            this.btnStartGoodbyeDPI.TabIndex = 12;
            this.btnStartGoodbyeDPI.Text = "Start";
            this.btnStartGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnStartGoodbyeDPI.Click += new System.EventHandler(this.btnStartGoodbyeDPI_Click);
            // 
            // argumentLabel
            // 
            this.argumentLabel.AutoSize = true;
            this.argumentLabel.Location = new System.Drawing.Point(139, 16);
            this.argumentLabel.Name = "argumentLabel";
            this.argumentLabel.Size = new System.Drawing.Size(55, 13);
            this.argumentLabel.TabIndex = 6;
            this.argumentLabel.Text = "Argument:";
            // 
            // txtGoodbyeDPIArgs
            // 
            this.txtGoodbyeDPIArgs.Location = new System.Drawing.Point(200, 13);
            this.txtGoodbyeDPIArgs.Name = "txtGoodbyeDPIArgs";
            this.txtGoodbyeDPIArgs.Size = new System.Drawing.Size(100, 20);
            this.txtGoodbyeDPIArgs.TabIndex = 9;
            this.txtGoodbyeDPIArgs.Text = "-5 --set-ttl 5 --dns-addr 77.88.8.8 --dns-port 1253 --dnsv6-addr 2a02:6b8::feed:0" +
    "ff --dnsv6-port 1253";
            // 
            // dnsSettigsGroupBox
            // 
            this.dnsSettigsGroupBox.Controls.Add(this.radioBtnEthernet);
            this.dnsSettigsGroupBox.Controls.Add(this.radioBtnWiFi);
            this.dnsSettigsGroupBox.Controls.Add(this.btnResetDNS);
            this.dnsSettigsGroupBox.Controls.Add(this.btnChangeDNS);
            this.dnsSettigsGroupBox.Controls.Add(this.preferredDnsLabel);
            this.dnsSettigsGroupBox.Controls.Add(this.txtPreferredDNS);
            this.dnsSettigsGroupBox.Controls.Add(this.networkInterfaceLabel);
            this.dnsSettigsGroupBox.Controls.Add(this.alternativeDnsLabel);
            this.dnsSettigsGroupBox.Controls.Add(this.txtAlternateDNS);
            this.dnsSettigsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.dnsSettigsGroupBox.Name = "dnsSettigsGroupBox";
            this.dnsSettigsGroupBox.Size = new System.Drawing.Size(412, 153);
            this.dnsSettigsGroupBox.TabIndex = 15;
            this.dnsSettigsGroupBox.TabStop = false;
            this.dnsSettigsGroupBox.Text = "DNS Settings";
            // 
            // radioBtnEthernet
            // 
            this.radioBtnEthernet.AutoSize = true;
            this.radioBtnEthernet.Location = new System.Drawing.Point(255, 67);
            this.radioBtnEthernet.Name = "radioBtnEthernet";
            this.radioBtnEthernet.Size = new System.Drawing.Size(65, 17);
            this.radioBtnEthernet.TabIndex = 15;
            this.radioBtnEthernet.TabStop = true;
            this.radioBtnEthernet.Text = "Ethernet";
            this.radioBtnEthernet.UseVisualStyleBackColor = true;
            // 
            // radioBtnWiFi
            // 
            this.radioBtnWiFi.AutoSize = true;
            this.radioBtnWiFi.Location = new System.Drawing.Point(200, 67);
            this.radioBtnWiFi.Name = "radioBtnWiFi";
            this.radioBtnWiFi.Size = new System.Drawing.Size(49, 17);
            this.radioBtnWiFi.TabIndex = 14;
            this.radioBtnWiFi.TabStop = true;
            this.radioBtnWiFi.Text = "Wi-Fi";
            this.radioBtnWiFi.UseVisualStyleBackColor = true;
            // 
            // btnResetDNS
            // 
            this.btnResetDNS.Location = new System.Drawing.Point(147, 124);
            this.btnResetDNS.Name = "btnResetDNS";
            this.btnResetDNS.Size = new System.Drawing.Size(114, 23);
            this.btnResetDNS.TabIndex = 13;
            this.btnResetDNS.Text = "Reset DNS";
            this.btnResetDNS.UseVisualStyleBackColor = true;
            this.btnResetDNS.Click += new System.EventHandler(this.btnResetDNS_Click);
            // 
            // btnChangeDNS
            // 
            this.btnChangeDNS.Location = new System.Drawing.Point(147, 95);
            this.btnChangeDNS.Name = "btnChangeDNS";
            this.btnChangeDNS.Size = new System.Drawing.Size(114, 23);
            this.btnChangeDNS.TabIndex = 12;
            this.btnChangeDNS.Text = "Change DNS";
            this.btnChangeDNS.UseVisualStyleBackColor = true;
            this.btnChangeDNS.Click += new System.EventHandler(this.btnChangeDNS_Click);
            // 
            // preferredDnsLabel
            // 
            this.preferredDnsLabel.AutoSize = true;
            this.preferredDnsLabel.Location = new System.Drawing.Point(115, 16);
            this.preferredDnsLabel.Name = "preferredDnsLabel";
            this.preferredDnsLabel.Size = new System.Drawing.Size(79, 13);
            this.preferredDnsLabel.TabIndex = 6;
            this.preferredDnsLabel.Text = "Preferred DNS:";
            // 
            // txtPreferredDNS
            // 
            this.txtPreferredDNS.Location = new System.Drawing.Point(200, 13);
            this.txtPreferredDNS.Name = "txtPreferredDNS";
            this.txtPreferredDNS.Size = new System.Drawing.Size(100, 20);
            this.txtPreferredDNS.TabIndex = 9;
            this.txtPreferredDNS.Text = "1.1.1.1";
            // 
            // networkInterfaceLabel
            // 
            this.networkInterfaceLabel.AutoSize = true;
            this.networkInterfaceLabel.Location = new System.Drawing.Point(99, 69);
            this.networkInterfaceLabel.Name = "networkInterfaceLabel";
            this.networkInterfaceLabel.Size = new System.Drawing.Size(95, 13);
            this.networkInterfaceLabel.TabIndex = 8;
            this.networkInterfaceLabel.Text = "Network Interface:";
            // 
            // alternativeDnsLabel
            // 
            this.alternativeDnsLabel.AutoSize = true;
            this.alternativeDnsLabel.Location = new System.Drawing.Point(108, 42);
            this.alternativeDnsLabel.Name = "alternativeDnsLabel";
            this.alternativeDnsLabel.Size = new System.Drawing.Size(86, 13);
            this.alternativeDnsLabel.TabIndex = 7;
            this.alternativeDnsLabel.Text = "Alternative DNS:";
            // 
            // txtAlternateDNS
            // 
            this.txtAlternateDNS.Location = new System.Drawing.Point(200, 39);
            this.txtAlternateDNS.Name = "txtAlternateDNS";
            this.txtAlternateDNS.Size = new System.Drawing.Size(100, 20);
            this.txtAlternateDNS.TabIndex = 10;
            this.txtAlternateDNS.Text = "1.0.0.1";
            // 
            // pingTestGroupBox
            // 
            this.pingTestGroupBox.Controls.Add(this.btnPing);
            this.pingTestGroupBox.Controls.Add(this.ipLabel);
            this.pingTestGroupBox.Controls.Add(this.txtIP);
            this.pingTestGroupBox.Location = new System.Drawing.Point(12, 298);
            this.pingTestGroupBox.Name = "pingTestGroupBox";
            this.pingTestGroupBox.Size = new System.Drawing.Size(412, 69);
            this.pingTestGroupBox.TabIndex = 17;
            this.pingTestGroupBox.TabStop = false;
            this.pingTestGroupBox.Text = "Ping Test";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(147, 39);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(114, 23);
            this.btnPing.TabIndex = 12;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(133, 16);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(61, 13);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(200, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 9;
            this.txtIP.Text = "1.1.1.1";
            // 
            // recommendedDnsGroupBox
            // 
            this.recommendedDnsGroupBox.Controls.Add(this.openDnsGroupBox);
            this.recommendedDnsGroupBox.Controls.Add(this.googleDnsGroupBox);
            this.recommendedDnsGroupBox.Controls.Add(this.cloudflareDnsGroupBox);
            this.recommendedDnsGroupBox.Location = new System.Drawing.Point(12, 373);
            this.recommendedDnsGroupBox.Name = "recommendedDnsGroupBox";
            this.recommendedDnsGroupBox.Size = new System.Drawing.Size(412, 105);
            this.recommendedDnsGroupBox.TabIndex = 18;
            this.recommendedDnsGroupBox.TabStop = false;
            this.recommendedDnsGroupBox.Text = "Recommended DNS";
            // 
            // openDnsGroupBox
            // 
            this.openDnsGroupBox.Controls.Add(this.openDnsLabel);
            this.openDnsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openDnsGroupBox.Location = new System.Drawing.Point(242, 19);
            this.openDnsGroupBox.Name = "openDnsGroupBox";
            this.openDnsGroupBox.Size = new System.Drawing.Size(164, 79);
            this.openDnsGroupBox.TabIndex = 21;
            this.openDnsGroupBox.TabStop = false;
            this.openDnsGroupBox.Text = "Open DNS";
            // 
            // openDnsLabel
            // 
            this.openDnsLabel.AutoSize = true;
            this.openDnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openDnsLabel.Location = new System.Drawing.Point(6, 25);
            this.openDnsLabel.Name = "openDnsLabel";
            this.openDnsLabel.Size = new System.Drawing.Size(138, 39);
            this.openDnsLabel.TabIndex = 7;
            this.openDnsLabel.Text = "Preferred: 208.67.222.222\r\n\r\nAlternative: 208.67.220.220";
            // 
            // googleDnsGroupBox
            // 
            this.googleDnsGroupBox.Controls.Add(this.googleDnsLabel);
            this.googleDnsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.googleDnsGroupBox.Location = new System.Drawing.Point(124, 19);
            this.googleDnsGroupBox.Name = "googleDnsGroupBox";
            this.googleDnsGroupBox.Size = new System.Drawing.Size(112, 79);
            this.googleDnsGroupBox.TabIndex = 20;
            this.googleDnsGroupBox.TabStop = false;
            this.googleDnsGroupBox.Text = "Google DNS";
            // 
            // googleDnsLabel
            // 
            this.googleDnsLabel.AutoSize = true;
            this.googleDnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.googleDnsLabel.Location = new System.Drawing.Point(8, 25);
            this.googleDnsLabel.Name = "googleDnsLabel";
            this.googleDnsLabel.Size = new System.Drawing.Size(96, 39);
            this.googleDnsLabel.TabIndex = 7;
            this.googleDnsLabel.Text = "Preferred: 8.8.8.8\r\n\r\nAlternative: 8.8.4.4";
            // 
            // cloudflareDnsGroupBox
            // 
            this.cloudflareDnsGroupBox.Controls.Add(this.cloudflareDnsLabel);
            this.cloudflareDnsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cloudflareDnsGroupBox.Location = new System.Drawing.Point(6, 19);
            this.cloudflareDnsGroupBox.Name = "cloudflareDnsGroupBox";
            this.cloudflareDnsGroupBox.Size = new System.Drawing.Size(112, 79);
            this.cloudflareDnsGroupBox.TabIndex = 19;
            this.cloudflareDnsGroupBox.TabStop = false;
            this.cloudflareDnsGroupBox.Text = "Cloudflare DNS";
            // 
            // cloudflareDnsLabel
            // 
            this.cloudflareDnsLabel.AutoSize = true;
            this.cloudflareDnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cloudflareDnsLabel.Location = new System.Drawing.Point(8, 25);
            this.cloudflareDnsLabel.Name = "cloudflareDnsLabel";
            this.cloudflareDnsLabel.Size = new System.Drawing.Size(96, 39);
            this.cloudflareDnsLabel.TabIndex = 7;
            this.cloudflareDnsLabel.Text = "Preferred: 1.1.1.1\r\n\r\nAlternative: 1.0.0.1";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versionLabel.Location = new System.Drawing.Point(376, 579);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(46, 13);
            this.versionLabel.TabIndex = 19;
            this.versionLabel.Text = "v2.0.0.0";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAutoStart.Location = new System.Drawing.Point(160, 69);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(95, 17);
            this.chkAutoStart.TabIndex = 20;
            this.chkAutoStart.Text = "Run at Startup";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // appSettingsGroupBox
            // 
            this.appSettingsGroupBox.Controls.Add(this.btnCheckForUpdates);
            this.appSettingsGroupBox.Controls.Add(this.btnDeleteGoodbyeDPI);
            this.appSettingsGroupBox.Controls.Add(this.chkAutoStart);
            this.appSettingsGroupBox.Location = new System.Drawing.Point(12, 484);
            this.appSettingsGroupBox.Name = "appSettingsGroupBox";
            this.appSettingsGroupBox.Size = new System.Drawing.Size(412, 92);
            this.appSettingsGroupBox.TabIndex = 21;
            this.appSettingsGroupBox.TabStop = false;
            this.appSettingsGroupBox.Text = "App Settings";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.Location = new System.Drawing.Point(147, 11);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(114, 23);
            this.btnCheckForUpdates.TabIndex = 22;
            this.btnCheckForUpdates.Text = "Check for Updates";
            this.btnCheckForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // btnDeleteGoodbyeDPI
            // 
            this.btnDeleteGoodbyeDPI.Location = new System.Drawing.Point(147, 40);
            this.btnDeleteGoodbyeDPI.Name = "btnDeleteGoodbyeDPI";
            this.btnDeleteGoodbyeDPI.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteGoodbyeDPI.TabIndex = 21;
            this.btnDeleteGoodbyeDPI.Text = "Delete GDPI";
            this.btnDeleteGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnDeleteGoodbyeDPI.Click += new System.EventHandler(this.btnDeleteGoodbyeDPI_Click);
            // 
            // dnschanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 601);
            this.Controls.Add(this.appSettingsGroupBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.recommendedDnsGroupBox);
            this.Controls.Add(this.pingTestGroupBox);
            this.Controls.Add(this.dpıSettigsGroupBox);
            this.Controls.Add(this.dnsSettigsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 640);
            this.Name = "dnschanger";
            this.Text = "DNS Changer";
            this.Load += new System.EventHandler(this.dnschanger_Load);
            this.dpıSettigsGroupBox.ResumeLayout(false);
            this.dpıSettigsGroupBox.PerformLayout();
            this.dnsSettigsGroupBox.ResumeLayout(false);
            this.dnsSettigsGroupBox.PerformLayout();
            this.pingTestGroupBox.ResumeLayout(false);
            this.pingTestGroupBox.PerformLayout();
            this.recommendedDnsGroupBox.ResumeLayout(false);
            this.openDnsGroupBox.ResumeLayout(false);
            this.openDnsGroupBox.PerformLayout();
            this.googleDnsGroupBox.ResumeLayout(false);
            this.googleDnsGroupBox.PerformLayout();
            this.cloudflareDnsGroupBox.ResumeLayout(false);
            this.cloudflareDnsGroupBox.PerformLayout();
            this.appSettingsGroupBox.ResumeLayout(false);
            this.appSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dpıSettigsGroupBox;
        private System.Windows.Forms.Button btnStopGoodbyeDPI;
        private System.Windows.Forms.Button btnStartGoodbyeDPI;
        private System.Windows.Forms.Label argumentLabel;
        private System.Windows.Forms.TextBox txtGoodbyeDPIArgs;
        private System.Windows.Forms.GroupBox dnsSettigsGroupBox;
        private System.Windows.Forms.Button btnResetDNS;
        private System.Windows.Forms.Button btnChangeDNS;
        private System.Windows.Forms.Label preferredDnsLabel;
        private System.Windows.Forms.TextBox txtPreferredDNS;
        private System.Windows.Forms.Label networkInterfaceLabel;
        private System.Windows.Forms.Label alternativeDnsLabel;
        private System.Windows.Forms.TextBox txtAlternateDNS;
        private System.Windows.Forms.CheckBox chkShowConsole;
        private System.Windows.Forms.RadioButton radioBtnWiFi;
        private System.Windows.Forms.RadioButton radioBtnEthernet;
        private System.Windows.Forms.GroupBox pingTestGroupBox;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.GroupBox recommendedDnsGroupBox;
        private System.Windows.Forms.GroupBox openDnsGroupBox;
        private System.Windows.Forms.Label openDnsLabel;
        private System.Windows.Forms.GroupBox googleDnsGroupBox;
        private System.Windows.Forms.Label googleDnsLabel;
        private System.Windows.Forms.GroupBox cloudflareDnsGroupBox;
        private System.Windows.Forms.Label cloudflareDnsLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.GroupBox appSettingsGroupBox;
        private System.Windows.Forms.Button btnDeleteGoodbyeDPI;
        private System.Windows.Forms.Button btnCheckForUpdates;
    }
}


namespace dnschanger
{
    partial class DNSChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNSChanger));
            this.dpıSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnGoodbyeDPIArgsDefault = new System.Windows.Forms.Button();
            this.btnServiceDeleteGoodbyeDPI = new System.Windows.Forms.Button();
            this.btnServiceInstallGoodbyeDPI = new System.Windows.Forms.Button();
            this.btnDeleteGoodbyeDPI = new System.Windows.Forms.Button();
            this.chkShowConsole = new System.Windows.Forms.CheckBox();
            this.btnStopGoodbyeDPI = new System.Windows.Forms.Button();
            this.btnStartGoodbyeDPI = new System.Windows.Forms.Button();
            this.argumentLabel = new System.Windows.Forms.Label();
            this.txtGoodbyeDPIArgs = new System.Windows.Forms.TextBox();
            this.IPv4DNSSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnIPv4Auto = new System.Windows.Forms.RadioButton();
            this.btnAlternateIPv4DNSDefault = new System.Windows.Forms.Button();
            this.btnPreferredIPv4DNSDefault = new System.Windows.Forms.Button();
            this.radioBtnIPv4Ethernet = new System.Windows.Forms.RadioButton();
            this.radioBtnIPv4WiFi = new System.Windows.Forms.RadioButton();
            this.btnResetIPv4DNS = new System.Windows.Forms.Button();
            this.btnChangeIPv4DNS = new System.Windows.Forms.Button();
            this.preferredIPv4DNSLabel = new System.Windows.Forms.Label();
            this.txtPreferredIPv4DNS = new System.Windows.Forms.TextBox();
            this.networkInterfaceIPv4Label = new System.Windows.Forms.Label();
            this.alternativeIPv4DNSLabel = new System.Windows.Forms.Label();
            this.txtAlternateIPv4DNS = new System.Windows.Forms.TextBox();
            this.pingTestGroupBox = new System.Windows.Forms.GroupBox();
            this.btnIPDefault = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.appSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.chkRememberSettings = new System.Windows.Forms.CheckBox();
            this.btnClearDNSCache = new System.Windows.Forms.Button();
            this.btnCheckForUpdates = new System.Windows.Forms.Button();
            this.IPv6DNSSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnIPv6Auto = new System.Windows.Forms.RadioButton();
            this.btnAlternateIPv6DNSDefault = new System.Windows.Forms.Button();
            this.btnPreferredIPv6DNSDefault = new System.Windows.Forms.Button();
            this.radioBtnIPv6Ethernet = new System.Windows.Forms.RadioButton();
            this.radioBtnIPv6WiFi = new System.Windows.Forms.RadioButton();
            this.btnResetIPv6DNS = new System.Windows.Forms.Button();
            this.btnChangeIPv6DNS = new System.Windows.Forms.Button();
            this.preferredIPv6DNSLabel = new System.Windows.Forms.Label();
            this.txtPreferredIPv6DNS = new System.Windows.Forms.TextBox();
            this.networkInterfaceIPv6Label = new System.Windows.Forms.Label();
            this.alternativeIPv6DNSLabel = new System.Windows.Forms.Label();
            this.txtAlternateIPv6DNS = new System.Windows.Forms.TextBox();
            this.quickConnectAndDisconnectGroupBox = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnQuickDisconnect = new System.Windows.Forms.Button();
            this.btnQuickConnect = new System.Windows.Forms.Button();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.dpıSettingsGroupBox.SuspendLayout();
            this.IPv4DNSSettingsGroupBox.SuspendLayout();
            this.pingTestGroupBox.SuspendLayout();
            this.appSettingsGroupBox.SuspendLayout();
            this.IPv6DNSSettingsGroupBox.SuspendLayout();
            this.quickConnectAndDisconnectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpıSettingsGroupBox
            // 
            this.dpıSettingsGroupBox.Controls.Add(this.btnGoodbyeDPIArgsDefault);
            this.dpıSettingsGroupBox.Controls.Add(this.btnServiceDeleteGoodbyeDPI);
            this.dpıSettingsGroupBox.Controls.Add(this.btnServiceInstallGoodbyeDPI);
            this.dpıSettingsGroupBox.Controls.Add(this.btnDeleteGoodbyeDPI);
            this.dpıSettingsGroupBox.Controls.Add(this.chkShowConsole);
            this.dpıSettingsGroupBox.Controls.Add(this.btnStopGoodbyeDPI);
            this.dpıSettingsGroupBox.Controls.Add(this.btnStartGoodbyeDPI);
            this.dpıSettingsGroupBox.Controls.Add(this.argumentLabel);
            this.dpıSettingsGroupBox.Controls.Add(this.txtGoodbyeDPIArgs);
            this.dpıSettingsGroupBox.Location = new System.Drawing.Point(12, 348);
            this.dpıSettingsGroupBox.MaximumSize = new System.Drawing.Size(412, 233);
            this.dpıSettingsGroupBox.MinimumSize = new System.Drawing.Size(412, 233);
            this.dpıSettingsGroupBox.Name = "dpıSettingsGroupBox";
            this.dpıSettingsGroupBox.Size = new System.Drawing.Size(412, 233);
            this.dpıSettingsGroupBox.TabIndex = 16;
            this.dpıSettingsGroupBox.TabStop = false;
            this.dpıSettingsGroupBox.Text = "GoodbyeDPI Settings";
            // 
            // btnGoodbyeDPIArgsDefault
            // 
            this.btnGoodbyeDPIArgsDefault.Location = new System.Drawing.Point(302, 34);
            this.btnGoodbyeDPIArgsDefault.Name = "btnGoodbyeDPIArgsDefault";
            this.btnGoodbyeDPIArgsDefault.Size = new System.Drawing.Size(53, 20);
            this.btnGoodbyeDPIArgsDefault.TabIndex = 25;
            this.btnGoodbyeDPIArgsDefault.Text = "Default";
            this.btnGoodbyeDPIArgsDefault.UseVisualStyleBackColor = true;
            this.btnGoodbyeDPIArgsDefault.Click += new System.EventHandler(this.btnGoodbyeDPIArgsDefault_Click);
            // 
            // btnServiceDeleteGoodbyeDPI
            // 
            this.btnServiceDeleteGoodbyeDPI.Location = new System.Drawing.Point(141, 170);
            this.btnServiceDeleteGoodbyeDPI.Name = "btnServiceDeleteGoodbyeDPI";
            this.btnServiceDeleteGoodbyeDPI.Size = new System.Drawing.Size(120, 23);
            this.btnServiceDeleteGoodbyeDPI.TabIndex = 23;
            this.btnServiceDeleteGoodbyeDPI.Text = "Service Delete GDPI";
            this.btnServiceDeleteGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnServiceDeleteGoodbyeDPI.Click += new System.EventHandler(this.btnServiceDeleteGoodbyeDPI_Click);
            // 
            // btnServiceInstallGoodbyeDPI
            // 
            this.btnServiceInstallGoodbyeDPI.Location = new System.Drawing.Point(141, 141);
            this.btnServiceInstallGoodbyeDPI.Name = "btnServiceInstallGoodbyeDPI";
            this.btnServiceInstallGoodbyeDPI.Size = new System.Drawing.Size(120, 23);
            this.btnServiceInstallGoodbyeDPI.TabIndex = 22;
            this.btnServiceInstallGoodbyeDPI.Text = "Service Install GDPI";
            this.btnServiceInstallGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnServiceInstallGoodbyeDPI.Click += new System.EventHandler(this.btnServiceInstallGoodbyeDPI_Click);
            // 
            // btnDeleteGoodbyeDPI
            // 
            this.btnDeleteGoodbyeDPI.Location = new System.Drawing.Point(141, 199);
            this.btnDeleteGoodbyeDPI.Name = "btnDeleteGoodbyeDPI";
            this.btnDeleteGoodbyeDPI.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteGoodbyeDPI.TabIndex = 21;
            this.btnDeleteGoodbyeDPI.Text = "Delete GDPI";
            this.btnDeleteGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnDeleteGoodbyeDPI.Click += new System.EventHandler(this.btnDeleteGoodbyeDPI_Click);
            // 
            // chkShowConsole
            // 
            this.chkShowConsole.AutoSize = true;
            this.chkShowConsole.Location = new System.Drawing.Point(150, 118);
            this.chkShowConsole.Name = "chkShowConsole";
            this.chkShowConsole.Size = new System.Drawing.Size(94, 17);
            this.chkShowConsole.TabIndex = 14;
            this.chkShowConsole.Text = "Show Console";
            this.chkShowConsole.UseVisualStyleBackColor = true;
            // 
            // btnStopGoodbyeDPI
            // 
            this.btnStopGoodbyeDPI.Location = new System.Drawing.Point(141, 89);
            this.btnStopGoodbyeDPI.Name = "btnStopGoodbyeDPI";
            this.btnStopGoodbyeDPI.Size = new System.Drawing.Size(120, 23);
            this.btnStopGoodbyeDPI.TabIndex = 13;
            this.btnStopGoodbyeDPI.Text = "Stop GDPI";
            this.btnStopGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnStopGoodbyeDPI.Click += new System.EventHandler(this.btnStopGoodbyeDPI_Click);
            // 
            // btnStartGoodbyeDPI
            // 
            this.btnStartGoodbyeDPI.Location = new System.Drawing.Point(141, 60);
            this.btnStartGoodbyeDPI.Name = "btnStartGoodbyeDPI";
            this.btnStartGoodbyeDPI.Size = new System.Drawing.Size(120, 23);
            this.btnStartGoodbyeDPI.TabIndex = 12;
            this.btnStartGoodbyeDPI.Text = "Start GDPI";
            this.btnStartGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnStartGoodbyeDPI.Click += new System.EventHandler(this.btnStartGoodbyeDPI_Click);
            // 
            // argumentLabel
            // 
            this.argumentLabel.AutoSize = true;
            this.argumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.argumentLabel.Location = new System.Drawing.Point(70, 16);
            this.argumentLabel.Name = "argumentLabel";
            this.argumentLabel.Size = new System.Drawing.Size(63, 15);
            this.argumentLabel.TabIndex = 6;
            this.argumentLabel.Text = "Argument:";
            // 
            // txtGoodbyeDPIArgs
            // 
            this.txtGoodbyeDPIArgs.Location = new System.Drawing.Point(73, 34);
            this.txtGoodbyeDPIArgs.Name = "txtGoodbyeDPIArgs";
            this.txtGoodbyeDPIArgs.Size = new System.Drawing.Size(223, 20);
            this.txtGoodbyeDPIArgs.TabIndex = 9;
            this.txtGoodbyeDPIArgs.Text = "-5 --set-ttl 5 --dns-addr 77.88.8.8 --dns-port 1253 --dnsv6-addr 2a02:6b8::feed:0" +
    "ff --dnsv6-port 1253";
            this.txtGoodbyeDPIArgs.TextChanged += new System.EventHandler(this.txtGoodbyeDPIArgs_TextChanged);
            // 
            // IPv4DNSSettingsGroupBox
            // 
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.radioBtnIPv4Auto);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.btnAlternateIPv4DNSDefault);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.btnPreferredIPv4DNSDefault);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.radioBtnIPv4Ethernet);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.radioBtnIPv4WiFi);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.btnResetIPv4DNS);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.btnChangeIPv4DNS);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.preferredIPv4DNSLabel);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.txtPreferredIPv4DNS);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.networkInterfaceIPv4Label);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.alternativeIPv4DNSLabel);
            this.IPv4DNSSettingsGroupBox.Controls.Add(this.txtAlternateIPv4DNS);
            this.IPv4DNSSettingsGroupBox.Location = new System.Drawing.Point(12, 140);
            this.IPv4DNSSettingsGroupBox.MaximumSize = new System.Drawing.Size(412, 202);
            this.IPv4DNSSettingsGroupBox.MinimumSize = new System.Drawing.Size(412, 202);
            this.IPv4DNSSettingsGroupBox.Name = "IPv4DNSSettingsGroupBox";
            this.IPv4DNSSettingsGroupBox.Size = new System.Drawing.Size(412, 202);
            this.IPv4DNSSettingsGroupBox.TabIndex = 15;
            this.IPv4DNSSettingsGroupBox.TabStop = false;
            this.IPv4DNSSettingsGroupBox.Text = "IPv4 DNS Settings";
            // 
            // radioBtnIPv4Auto
            // 
            this.radioBtnIPv4Auto.AutoSize = true;
            this.radioBtnIPv4Auto.Checked = true;
            this.radioBtnIPv4Auto.Location = new System.Drawing.Point(195, 116);
            this.radioBtnIPv4Auto.Name = "radioBtnIPv4Auto";
            this.radioBtnIPv4Auto.Size = new System.Drawing.Size(47, 17);
            this.radioBtnIPv4Auto.TabIndex = 28;
            this.radioBtnIPv4Auto.TabStop = true;
            this.radioBtnIPv4Auto.Text = "Auto";
            this.radioBtnIPv4Auto.UseVisualStyleBackColor = true;
            // 
            // btnAlternateIPv4DNSDefault
            // 
            this.btnAlternateIPv4DNSDefault.Location = new System.Drawing.Point(302, 75);
            this.btnAlternateIPv4DNSDefault.Name = "btnAlternateIPv4DNSDefault";
            this.btnAlternateIPv4DNSDefault.Size = new System.Drawing.Size(53, 20);
            this.btnAlternateIPv4DNSDefault.TabIndex = 27;
            this.btnAlternateIPv4DNSDefault.Text = "Default";
            this.btnAlternateIPv4DNSDefault.UseVisualStyleBackColor = true;
            this.btnAlternateIPv4DNSDefault.Click += new System.EventHandler(this.btnAlternateIPv4DNSDefault_Click);
            // 
            // btnPreferredIPv4DNSDefault
            // 
            this.btnPreferredIPv4DNSDefault.Location = new System.Drawing.Point(302, 34);
            this.btnPreferredIPv4DNSDefault.Name = "btnPreferredIPv4DNSDefault";
            this.btnPreferredIPv4DNSDefault.Size = new System.Drawing.Size(53, 20);
            this.btnPreferredIPv4DNSDefault.TabIndex = 26;
            this.btnPreferredIPv4DNSDefault.Text = "Default";
            this.btnPreferredIPv4DNSDefault.UseVisualStyleBackColor = true;
            this.btnPreferredIPv4DNSDefault.Click += new System.EventHandler(this.btnPreferredIPv4DNSDefault_Click);
            // 
            // radioBtnIPv4Ethernet
            // 
            this.radioBtnIPv4Ethernet.AutoSize = true;
            this.radioBtnIPv4Ethernet.Location = new System.Drawing.Point(124, 116);
            this.radioBtnIPv4Ethernet.Name = "radioBtnIPv4Ethernet";
            this.radioBtnIPv4Ethernet.Size = new System.Drawing.Size(65, 17);
            this.radioBtnIPv4Ethernet.TabIndex = 15;
            this.radioBtnIPv4Ethernet.Text = "Ethernet";
            this.radioBtnIPv4Ethernet.UseVisualStyleBackColor = true;
            // 
            // radioBtnIPv4WiFi
            // 
            this.radioBtnIPv4WiFi.AutoSize = true;
            this.radioBtnIPv4WiFi.Location = new System.Drawing.Point(69, 116);
            this.radioBtnIPv4WiFi.Name = "radioBtnIPv4WiFi";
            this.radioBtnIPv4WiFi.Size = new System.Drawing.Size(49, 17);
            this.radioBtnIPv4WiFi.TabIndex = 14;
            this.radioBtnIPv4WiFi.Text = "Wi-Fi";
            this.radioBtnIPv4WiFi.UseVisualStyleBackColor = true;
            // 
            // btnResetIPv4DNS
            // 
            this.btnResetIPv4DNS.Location = new System.Drawing.Point(141, 168);
            this.btnResetIPv4DNS.Name = "btnResetIPv4DNS";
            this.btnResetIPv4DNS.Size = new System.Drawing.Size(120, 23);
            this.btnResetIPv4DNS.TabIndex = 13;
            this.btnResetIPv4DNS.Text = "Reset DNS IPv4";
            this.btnResetIPv4DNS.UseVisualStyleBackColor = true;
            this.btnResetIPv4DNS.Click += new System.EventHandler(this.btnResetIPv4DNS_Click);
            // 
            // btnChangeIPv4DNS
            // 
            this.btnChangeIPv4DNS.Location = new System.Drawing.Point(141, 139);
            this.btnChangeIPv4DNS.Name = "btnChangeIPv4DNS";
            this.btnChangeIPv4DNS.Size = new System.Drawing.Size(120, 23);
            this.btnChangeIPv4DNS.TabIndex = 12;
            this.btnChangeIPv4DNS.Text = "Change DNS IPv4";
            this.btnChangeIPv4DNS.UseVisualStyleBackColor = true;
            this.btnChangeIPv4DNS.Click += new System.EventHandler(this.btnChangeIPv4DNS_Click);
            // 
            // preferredIPv4DNSLabel
            // 
            this.preferredIPv4DNSLabel.AutoSize = true;
            this.preferredIPv4DNSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.preferredIPv4DNSLabel.Location = new System.Drawing.Point(66, 16);
            this.preferredIPv4DNSLabel.Name = "preferredIPv4DNSLabel";
            this.preferredIPv4DNSLabel.Size = new System.Drawing.Size(116, 15);
            this.preferredIPv4DNSLabel.TabIndex = 6;
            this.preferredIPv4DNSLabel.Text = "IPv4 Preferred DNS:";
            // 
            // txtPreferredIPv4DNS
            // 
            this.txtPreferredIPv4DNS.Location = new System.Drawing.Point(69, 34);
            this.txtPreferredIPv4DNS.Name = "txtPreferredIPv4DNS";
            this.txtPreferredIPv4DNS.Size = new System.Drawing.Size(227, 20);
            this.txtPreferredIPv4DNS.TabIndex = 9;
            this.txtPreferredIPv4DNS.Text = "1.1.1.1";
            this.txtPreferredIPv4DNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreferredIPv4DNS.TextChanged += new System.EventHandler(this.txtPreferredIPv4DNS_TextChanged);
            // 
            // networkInterfaceIPv4Label
            // 
            this.networkInterfaceIPv4Label.AutoSize = true;
            this.networkInterfaceIPv4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.networkInterfaceIPv4Label.Location = new System.Drawing.Point(66, 98);
            this.networkInterfaceIPv4Label.Name = "networkInterfaceIPv4Label";
            this.networkInterfaceIPv4Label.Size = new System.Drawing.Size(131, 15);
            this.networkInterfaceIPv4Label.TabIndex = 8;
            this.networkInterfaceIPv4Label.Text = "IPv4 Network Interface:";
            // 
            // alternativeIPv4DNSLabel
            // 
            this.alternativeIPv4DNSLabel.AutoSize = true;
            this.alternativeIPv4DNSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternativeIPv4DNSLabel.Location = new System.Drawing.Point(66, 57);
            this.alternativeIPv4DNSLabel.Name = "alternativeIPv4DNSLabel";
            this.alternativeIPv4DNSLabel.Size = new System.Drawing.Size(121, 15);
            this.alternativeIPv4DNSLabel.TabIndex = 7;
            this.alternativeIPv4DNSLabel.Text = "IPv4 Alternative DNS:";
            // 
            // txtAlternateIPv4DNS
            // 
            this.txtAlternateIPv4DNS.Location = new System.Drawing.Point(69, 75);
            this.txtAlternateIPv4DNS.Name = "txtAlternateIPv4DNS";
            this.txtAlternateIPv4DNS.Size = new System.Drawing.Size(227, 20);
            this.txtAlternateIPv4DNS.TabIndex = 10;
            this.txtAlternateIPv4DNS.Text = "1.0.0.1";
            this.txtAlternateIPv4DNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlternateIPv4DNS.TextChanged += new System.EventHandler(this.txtAlternateIPv4DNS_TextChanged);
            // 
            // pingTestGroupBox
            // 
            this.pingTestGroupBox.Controls.Add(this.btnIPDefault);
            this.pingTestGroupBox.Controls.Add(this.btnPing);
            this.pingTestGroupBox.Controls.Add(this.ipLabel);
            this.pingTestGroupBox.Controls.Add(this.txtIP);
            this.pingTestGroupBox.Location = new System.Drawing.Point(430, 348);
            this.pingTestGroupBox.MaximumSize = new System.Drawing.Size(412, 94);
            this.pingTestGroupBox.MinimumSize = new System.Drawing.Size(412, 94);
            this.pingTestGroupBox.Name = "pingTestGroupBox";
            this.pingTestGroupBox.Size = new System.Drawing.Size(412, 94);
            this.pingTestGroupBox.TabIndex = 17;
            this.pingTestGroupBox.TabStop = false;
            this.pingTestGroupBox.Text = "Ping Test";
            // 
            // btnIPDefault
            // 
            this.btnIPDefault.Location = new System.Drawing.Point(302, 34);
            this.btnIPDefault.Name = "btnIPDefault";
            this.btnIPDefault.Size = new System.Drawing.Size(53, 20);
            this.btnIPDefault.TabIndex = 25;
            this.btnIPDefault.Text = "Default";
            this.btnIPDefault.UseVisualStyleBackColor = true;
            this.btnIPDefault.Click += new System.EventHandler(this.btnIPDefault_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(141, 60);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(120, 23);
            this.btnPing.TabIndex = 12;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipLabel.Location = new System.Drawing.Point(66, 16);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(68, 15);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(69, 34);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(227, 20);
            this.txtIP.TabIndex = 9;
            this.txtIP.Text = "1.1.1.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVersion.Location = new System.Drawing.Point(180, 102);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 13);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "v3.5.0.0";
            // 
            // appSettingsGroupBox
            // 
            this.appSettingsGroupBox.Controls.Add(this.chkRememberSettings);
            this.appSettingsGroupBox.Controls.Add(this.btnClearDNSCache);
            this.appSettingsGroupBox.Controls.Add(this.btnCheckForUpdates);
            this.appSettingsGroupBox.Controls.Add(this.lblVersion);
            this.appSettingsGroupBox.Location = new System.Drawing.Point(430, 448);
            this.appSettingsGroupBox.MaximumSize = new System.Drawing.Size(412, 133);
            this.appSettingsGroupBox.MinimumSize = new System.Drawing.Size(412, 133);
            this.appSettingsGroupBox.Name = "appSettingsGroupBox";
            this.appSettingsGroupBox.Size = new System.Drawing.Size(412, 133);
            this.appSettingsGroupBox.TabIndex = 21;
            this.appSettingsGroupBox.TabStop = false;
            this.appSettingsGroupBox.Text = "App Settings";
            // 
            // chkRememberSettings
            // 
            this.chkRememberSettings.AutoSize = true;
            this.chkRememberSettings.Location = new System.Drawing.Point(143, 74);
            this.chkRememberSettings.Name = "chkRememberSettings";
            this.chkRememberSettings.Size = new System.Drawing.Size(118, 17);
            this.chkRememberSettings.TabIndex = 24;
            this.chkRememberSettings.Text = "Remember Settings";
            this.chkRememberSettings.UseVisualStyleBackColor = true;
            this.chkRememberSettings.CheckedChanged += new System.EventHandler(this.chkRememberSettings_CheckedChanged);
            // 
            // btnClearDNSCache
            // 
            this.btnClearDNSCache.Location = new System.Drawing.Point(141, 45);
            this.btnClearDNSCache.Name = "btnClearDNSCache";
            this.btnClearDNSCache.Size = new System.Drawing.Size(120, 23);
            this.btnClearDNSCache.TabIndex = 23;
            this.btnClearDNSCache.Text = "Clear DNS Cache";
            this.btnClearDNSCache.UseVisualStyleBackColor = true;
            this.btnClearDNSCache.Click += new System.EventHandler(this.btnClearDNSCache_Click);
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.Location = new System.Drawing.Point(141, 16);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(120, 23);
            this.btnCheckForUpdates.TabIndex = 22;
            this.btnCheckForUpdates.Text = "Check for Updates";
            this.btnCheckForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // IPv6DNSSettingsGroupBox
            // 
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.radioBtnIPv6Auto);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.btnAlternateIPv6DNSDefault);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.btnPreferredIPv6DNSDefault);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.radioBtnIPv6Ethernet);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.radioBtnIPv6WiFi);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.btnResetIPv6DNS);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.btnChangeIPv6DNS);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.preferredIPv6DNSLabel);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.txtPreferredIPv6DNS);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.networkInterfaceIPv6Label);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.alternativeIPv6DNSLabel);
            this.IPv6DNSSettingsGroupBox.Controls.Add(this.txtAlternateIPv6DNS);
            this.IPv6DNSSettingsGroupBox.Location = new System.Drawing.Point(430, 140);
            this.IPv6DNSSettingsGroupBox.MaximumSize = new System.Drawing.Size(412, 202);
            this.IPv6DNSSettingsGroupBox.MinimumSize = new System.Drawing.Size(412, 202);
            this.IPv6DNSSettingsGroupBox.Name = "IPv6DNSSettingsGroupBox";
            this.IPv6DNSSettingsGroupBox.Size = new System.Drawing.Size(412, 202);
            this.IPv6DNSSettingsGroupBox.TabIndex = 22;
            this.IPv6DNSSettingsGroupBox.TabStop = false;
            this.IPv6DNSSettingsGroupBox.Text = "IPv6 DNS Settings";
            // 
            // radioBtnIPv6Auto
            // 
            this.radioBtnIPv6Auto.AutoSize = true;
            this.radioBtnIPv6Auto.Checked = true;
            this.radioBtnIPv6Auto.Location = new System.Drawing.Point(197, 116);
            this.radioBtnIPv6Auto.Name = "radioBtnIPv6Auto";
            this.radioBtnIPv6Auto.Size = new System.Drawing.Size(47, 17);
            this.radioBtnIPv6Auto.TabIndex = 29;
            this.radioBtnIPv6Auto.TabStop = true;
            this.radioBtnIPv6Auto.Text = "Auto";
            this.radioBtnIPv6Auto.UseVisualStyleBackColor = true;
            // 
            // btnAlternateIPv6DNSDefault
            // 
            this.btnAlternateIPv6DNSDefault.Location = new System.Drawing.Point(302, 75);
            this.btnAlternateIPv6DNSDefault.Name = "btnAlternateIPv6DNSDefault";
            this.btnAlternateIPv6DNSDefault.Size = new System.Drawing.Size(53, 20);
            this.btnAlternateIPv6DNSDefault.TabIndex = 27;
            this.btnAlternateIPv6DNSDefault.Text = "Default";
            this.btnAlternateIPv6DNSDefault.UseVisualStyleBackColor = true;
            this.btnAlternateIPv6DNSDefault.Click += new System.EventHandler(this.btnAlternateIPv6DNSDefault_Click);
            // 
            // btnPreferredIPv6DNSDefault
            // 
            this.btnPreferredIPv6DNSDefault.Location = new System.Drawing.Point(302, 34);
            this.btnPreferredIPv6DNSDefault.Name = "btnPreferredIPv6DNSDefault";
            this.btnPreferredIPv6DNSDefault.Size = new System.Drawing.Size(53, 20);
            this.btnPreferredIPv6DNSDefault.TabIndex = 26;
            this.btnPreferredIPv6DNSDefault.Text = "Default";
            this.btnPreferredIPv6DNSDefault.UseVisualStyleBackColor = true;
            this.btnPreferredIPv6DNSDefault.Click += new System.EventHandler(this.btnPreferredIPv6DNSDefault_Click);
            // 
            // radioBtnIPv6Ethernet
            // 
            this.radioBtnIPv6Ethernet.AutoSize = true;
            this.radioBtnIPv6Ethernet.Location = new System.Drawing.Point(126, 116);
            this.radioBtnIPv6Ethernet.Name = "radioBtnIPv6Ethernet";
            this.radioBtnIPv6Ethernet.Size = new System.Drawing.Size(65, 17);
            this.radioBtnIPv6Ethernet.TabIndex = 15;
            this.radioBtnIPv6Ethernet.Text = "Ethernet";
            this.radioBtnIPv6Ethernet.UseVisualStyleBackColor = true;
            // 
            // radioBtnIPv6WiFi
            // 
            this.radioBtnIPv6WiFi.AutoSize = true;
            this.radioBtnIPv6WiFi.Location = new System.Drawing.Point(71, 116);
            this.radioBtnIPv6WiFi.Name = "radioBtnIPv6WiFi";
            this.radioBtnIPv6WiFi.Size = new System.Drawing.Size(49, 17);
            this.radioBtnIPv6WiFi.TabIndex = 14;
            this.radioBtnIPv6WiFi.Text = "Wi-Fi";
            this.radioBtnIPv6WiFi.UseVisualStyleBackColor = true;
            // 
            // btnResetIPv6DNS
            // 
            this.btnResetIPv6DNS.Location = new System.Drawing.Point(141, 168);
            this.btnResetIPv6DNS.Name = "btnResetIPv6DNS";
            this.btnResetIPv6DNS.Size = new System.Drawing.Size(120, 23);
            this.btnResetIPv6DNS.TabIndex = 13;
            this.btnResetIPv6DNS.Text = "Reset DNS IPv6";
            this.btnResetIPv6DNS.UseVisualStyleBackColor = true;
            this.btnResetIPv6DNS.Click += new System.EventHandler(this.btnResetIPv6DNS_Click);
            // 
            // btnChangeIPv6DNS
            // 
            this.btnChangeIPv6DNS.Location = new System.Drawing.Point(141, 139);
            this.btnChangeIPv6DNS.Name = "btnChangeIPv6DNS";
            this.btnChangeIPv6DNS.Size = new System.Drawing.Size(120, 23);
            this.btnChangeIPv6DNS.TabIndex = 12;
            this.btnChangeIPv6DNS.Text = "Change DNS IPv6";
            this.btnChangeIPv6DNS.UseVisualStyleBackColor = true;
            this.btnChangeIPv6DNS.Click += new System.EventHandler(this.btnChangeIPv6DNS_Click);
            // 
            // preferredIPv6DNSLabel
            // 
            this.preferredIPv6DNSLabel.AutoSize = true;
            this.preferredIPv6DNSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.preferredIPv6DNSLabel.Location = new System.Drawing.Point(68, 16);
            this.preferredIPv6DNSLabel.Name = "preferredIPv6DNSLabel";
            this.preferredIPv6DNSLabel.Size = new System.Drawing.Size(116, 15);
            this.preferredIPv6DNSLabel.TabIndex = 6;
            this.preferredIPv6DNSLabel.Text = "IPv6 Preferred DNS:";
            // 
            // txtPreferredIPv6DNS
            // 
            this.txtPreferredIPv6DNS.Location = new System.Drawing.Point(71, 34);
            this.txtPreferredIPv6DNS.Name = "txtPreferredIPv6DNS";
            this.txtPreferredIPv6DNS.Size = new System.Drawing.Size(225, 20);
            this.txtPreferredIPv6DNS.TabIndex = 9;
            this.txtPreferredIPv6DNS.Text = "2606:4700:4700::1111";
            this.txtPreferredIPv6DNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreferredIPv6DNS.TextChanged += new System.EventHandler(this.txtPreferredIPv6DNS_TextChanged);
            // 
            // networkInterfaceIPv6Label
            // 
            this.networkInterfaceIPv6Label.AutoSize = true;
            this.networkInterfaceIPv6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.networkInterfaceIPv6Label.Location = new System.Drawing.Point(68, 98);
            this.networkInterfaceIPv6Label.Name = "networkInterfaceIPv6Label";
            this.networkInterfaceIPv6Label.Size = new System.Drawing.Size(131, 15);
            this.networkInterfaceIPv6Label.TabIndex = 8;
            this.networkInterfaceIPv6Label.Text = "IPv6 Network Interface:";
            // 
            // alternativeIPv6DNSLabel
            // 
            this.alternativeIPv6DNSLabel.AutoSize = true;
            this.alternativeIPv6DNSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alternativeIPv6DNSLabel.Location = new System.Drawing.Point(68, 57);
            this.alternativeIPv6DNSLabel.Name = "alternativeIPv6DNSLabel";
            this.alternativeIPv6DNSLabel.Size = new System.Drawing.Size(121, 15);
            this.alternativeIPv6DNSLabel.TabIndex = 7;
            this.alternativeIPv6DNSLabel.Text = "IPv6 Alternative DNS:";
            // 
            // txtAlternateIPv6DNS
            // 
            this.txtAlternateIPv6DNS.Location = new System.Drawing.Point(71, 75);
            this.txtAlternateIPv6DNS.Name = "txtAlternateIPv6DNS";
            this.txtAlternateIPv6DNS.Size = new System.Drawing.Size(225, 20);
            this.txtAlternateIPv6DNS.TabIndex = 10;
            this.txtAlternateIPv6DNS.Text = "2606:4700:4700::1001";
            this.txtAlternateIPv6DNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlternateIPv6DNS.TextChanged += new System.EventHandler(this.txtAlternateIPv6DNS_TextChanged);
            // 
            // quickConnectAndDisconnectGroupBox
            // 
            this.quickConnectAndDisconnectGroupBox.Controls.Add(this.lblStatus);
            this.quickConnectAndDisconnectGroupBox.Controls.Add(this.btnQuickDisconnect);
            this.quickConnectAndDisconnectGroupBox.Controls.Add(this.btnQuickConnect);
            this.quickConnectAndDisconnectGroupBox.Controls.Add(this.lblStatus1);
            this.quickConnectAndDisconnectGroupBox.Location = new System.Drawing.Point(12, 12);
            this.quickConnectAndDisconnectGroupBox.MaximumSize = new System.Drawing.Size(830, 122);
            this.quickConnectAndDisconnectGroupBox.MinimumSize = new System.Drawing.Size(830, 122);
            this.quickConnectAndDisconnectGroupBox.Name = "quickConnectAndDisconnectGroupBox";
            this.quickConnectAndDisconnectGroupBox.Size = new System.Drawing.Size(830, 122);
            this.quickConnectAndDisconnectGroupBox.TabIndex = 23;
            this.quickConnectAndDisconnectGroupBox.TabStop = false;
            this.quickConnectAndDisconnectGroupBox.Text = "Quick Connect && Disconnect";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(392, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 16);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Disconnected";
            // 
            // btnQuickDisconnect
            // 
            this.btnQuickDisconnect.Location = new System.Drawing.Point(354, 88);
            this.btnQuickDisconnect.Name = "btnQuickDisconnect";
            this.btnQuickDisconnect.Size = new System.Drawing.Size(120, 23);
            this.btnQuickDisconnect.TabIndex = 26;
            this.btnQuickDisconnect.Text = "Disconnect";
            this.btnQuickDisconnect.UseVisualStyleBackColor = true;
            this.btnQuickDisconnect.Click += new System.EventHandler(this.btnQuickDisconnect_Click);
            // 
            // btnQuickConnect
            // 
            this.btnQuickConnect.Location = new System.Drawing.Point(354, 59);
            this.btnQuickConnect.Name = "btnQuickConnect";
            this.btnQuickConnect.Size = new System.Drawing.Size(120, 23);
            this.btnQuickConnect.TabIndex = 12;
            this.btnQuickConnect.Text = "Connect";
            this.btnQuickConnect.UseVisualStyleBackColor = true;
            this.btnQuickConnect.Click += new System.EventHandler(this.btnQuickConnect_Click);
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus1.Location = new System.Drawing.Point(348, 26);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(47, 16);
            this.lblStatus1.TabIndex = 6;
            this.lblStatus1.Text = "Status:";
            // 
            // DNSChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(854, 591);
            this.Controls.Add(this.quickConnectAndDisconnectGroupBox);
            this.Controls.Add(this.IPv6DNSSettingsGroupBox);
            this.Controls.Add(this.appSettingsGroupBox);
            this.Controls.Add(this.pingTestGroupBox);
            this.Controls.Add(this.dpıSettingsGroupBox);
            this.Controls.Add(this.IPv4DNSSettingsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 630);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 630);
            this.Name = "DNSChanger";
            this.Text = "DNS Changer";
            this.Load += new System.EventHandler(this.dnschanger_Load);
            this.dpıSettingsGroupBox.ResumeLayout(false);
            this.dpıSettingsGroupBox.PerformLayout();
            this.IPv4DNSSettingsGroupBox.ResumeLayout(false);
            this.IPv4DNSSettingsGroupBox.PerformLayout();
            this.pingTestGroupBox.ResumeLayout(false);
            this.pingTestGroupBox.PerformLayout();
            this.appSettingsGroupBox.ResumeLayout(false);
            this.appSettingsGroupBox.PerformLayout();
            this.IPv6DNSSettingsGroupBox.ResumeLayout(false);
            this.IPv6DNSSettingsGroupBox.PerformLayout();
            this.quickConnectAndDisconnectGroupBox.ResumeLayout(false);
            this.quickConnectAndDisconnectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dpıSettingsGroupBox;
        private System.Windows.Forms.Button btnStopGoodbyeDPI;
        private System.Windows.Forms.Button btnStartGoodbyeDPI;
        private System.Windows.Forms.Label argumentLabel;
        private System.Windows.Forms.TextBox txtGoodbyeDPIArgs;
        private System.Windows.Forms.GroupBox IPv4DNSSettingsGroupBox;
        private System.Windows.Forms.Button btnResetIPv4DNS;
        private System.Windows.Forms.Button btnChangeIPv4DNS;
        private System.Windows.Forms.Label preferredIPv4DNSLabel;
        private System.Windows.Forms.TextBox txtPreferredIPv4DNS;
        private System.Windows.Forms.Label networkInterfaceIPv4Label;
        private System.Windows.Forms.Label alternativeIPv4DNSLabel;
        private System.Windows.Forms.TextBox txtAlternateIPv4DNS;
        private System.Windows.Forms.CheckBox chkShowConsole;
        private System.Windows.Forms.RadioButton radioBtnIPv4WiFi;
        private System.Windows.Forms.RadioButton radioBtnIPv4Ethernet;
        private System.Windows.Forms.GroupBox pingTestGroupBox;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox appSettingsGroupBox;
        private System.Windows.Forms.Button btnDeleteGoodbyeDPI;
        private System.Windows.Forms.Button btnCheckForUpdates;
        private System.Windows.Forms.GroupBox IPv6DNSSettingsGroupBox;
        private System.Windows.Forms.RadioButton radioBtnIPv6Ethernet;
        private System.Windows.Forms.RadioButton radioBtnIPv6WiFi;
        private System.Windows.Forms.Button btnResetIPv6DNS;
        private System.Windows.Forms.Button btnChangeIPv6DNS;
        private System.Windows.Forms.Label preferredIPv6DNSLabel;
        private System.Windows.Forms.TextBox txtPreferredIPv6DNS;
        private System.Windows.Forms.Label networkInterfaceIPv6Label;
        private System.Windows.Forms.Label alternativeIPv6DNSLabel;
        private System.Windows.Forms.TextBox txtAlternateIPv6DNS;
        private System.Windows.Forms.Button btnClearDNSCache;
        private System.Windows.Forms.Button btnServiceDeleteGoodbyeDPI;
        private System.Windows.Forms.Button btnServiceInstallGoodbyeDPI;
        private System.Windows.Forms.Button btnIPDefault;
        private System.Windows.Forms.Button btnGoodbyeDPIArgsDefault;
        private System.Windows.Forms.Button btnAlternateIPv4DNSDefault;
        private System.Windows.Forms.Button btnPreferredIPv4DNSDefault;
        private System.Windows.Forms.Button btnAlternateIPv6DNSDefault;
        private System.Windows.Forms.Button btnPreferredIPv6DNSDefault;
        private System.Windows.Forms.CheckBox chkRememberSettings;
        private System.Windows.Forms.RadioButton radioBtnIPv4Auto;
        private System.Windows.Forms.RadioButton radioBtnIPv6Auto;
        private System.Windows.Forms.GroupBox quickConnectAndDisconnectGroupBox;
        private System.Windows.Forms.Button btnQuickDisconnect;
        private System.Windows.Forms.Button btnQuickConnect;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus;
    }
}


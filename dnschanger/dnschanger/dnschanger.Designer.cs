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
            this.dpıSettigsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnStopGoodbyeDPI = new System.Windows.Forms.Button();
            this.btnStartGoodbyeDPI = new System.Windows.Forms.Button();
            this.argumentLabel = new System.Windows.Forms.Label();
            this.txtGoodbyeDPIArgs = new System.Windows.Forms.TextBox();
            this.dnsSettigsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnResetDNS = new System.Windows.Forms.Button();
            this.btnChangeDNS = new System.Windows.Forms.Button();
            this.preferredDnsLabel = new System.Windows.Forms.Label();
            this.txtPreferredDNS = new System.Windows.Forms.TextBox();
            this.txtNetworkInterface = new System.Windows.Forms.TextBox();
            this.networkInterfaceLabel = new System.Windows.Forms.Label();
            this.alternativeDnsLabel = new System.Windows.Forms.Label();
            this.txtAlternateDNS = new System.Windows.Forms.TextBox();
            this.chkShowConsole = new System.Windows.Forms.CheckBox();
            this.dpıSettigsGroupBox.SuspendLayout();
            this.dnsSettigsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpıSettigsGroupBox
            // 
            this.dpıSettigsGroupBox.Controls.Add(this.chkShowConsole);
            this.dpıSettigsGroupBox.Controls.Add(this.btnStopGoodbyeDPI);
            this.dpıSettigsGroupBox.Controls.Add(this.btnStartGoodbyeDPI);
            this.dpıSettigsGroupBox.Controls.Add(this.argumentLabel);
            this.dpıSettigsGroupBox.Controls.Add(this.txtGoodbyeDPIArgs);
            this.dpıSettigsGroupBox.Location = new System.Drawing.Point(12, 251);
            this.dpıSettigsGroupBox.Name = "dpıSettigsGroupBox";
            this.dpıSettigsGroupBox.Size = new System.Drawing.Size(412, 149);
            this.dpıSettigsGroupBox.TabIndex = 16;
            this.dpıSettigsGroupBox.TabStop = false;
            this.dpıSettigsGroupBox.Text = "GoodbyeDPI Settings";
            // 
            // btnStopGoodbyeDPI
            // 
            this.btnStopGoodbyeDPI.Location = new System.Drawing.Point(163, 79);
            this.btnStopGoodbyeDPI.Name = "btnStopGoodbyeDPI";
            this.btnStopGoodbyeDPI.Size = new System.Drawing.Size(83, 23);
            this.btnStopGoodbyeDPI.TabIndex = 13;
            this.btnStopGoodbyeDPI.Text = "Stop";
            this.btnStopGoodbyeDPI.UseVisualStyleBackColor = true;
            this.btnStopGoodbyeDPI.Click += new System.EventHandler(this.btnStopGoodbyeDPI_Click);
            // 
            // btnStartGoodbyeDPI
            // 
            this.btnStartGoodbyeDPI.Location = new System.Drawing.Point(163, 50);
            this.btnStartGoodbyeDPI.Name = "btnStartGoodbyeDPI";
            this.btnStartGoodbyeDPI.Size = new System.Drawing.Size(83, 23);
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
            this.txtGoodbyeDPIArgs.Text = "-5";
            // 
            // dnsSettigsGroupBox
            // 
            this.dnsSettigsGroupBox.Controls.Add(this.btnResetDNS);
            this.dnsSettigsGroupBox.Controls.Add(this.btnChangeDNS);
            this.dnsSettigsGroupBox.Controls.Add(this.preferredDnsLabel);
            this.dnsSettigsGroupBox.Controls.Add(this.txtPreferredDNS);
            this.dnsSettigsGroupBox.Controls.Add(this.txtNetworkInterface);
            this.dnsSettigsGroupBox.Controls.Add(this.networkInterfaceLabel);
            this.dnsSettigsGroupBox.Controls.Add(this.alternativeDnsLabel);
            this.dnsSettigsGroupBox.Controls.Add(this.txtAlternateDNS);
            this.dnsSettigsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.dnsSettigsGroupBox.Name = "dnsSettigsGroupBox";
            this.dnsSettigsGroupBox.Size = new System.Drawing.Size(412, 233);
            this.dnsSettigsGroupBox.TabIndex = 15;
            this.dnsSettigsGroupBox.TabStop = false;
            this.dnsSettigsGroupBox.Text = "DNS Settings";
            // 
            // btnResetDNS
            // 
            this.btnResetDNS.Location = new System.Drawing.Point(163, 197);
            this.btnResetDNS.Name = "btnResetDNS";
            this.btnResetDNS.Size = new System.Drawing.Size(83, 23);
            this.btnResetDNS.TabIndex = 13;
            this.btnResetDNS.Text = "Reset DNS";
            this.btnResetDNS.UseVisualStyleBackColor = true;
            this.btnResetDNS.Click += new System.EventHandler(this.btnResetDNS_Click);
            // 
            // btnChangeDNS
            // 
            this.btnChangeDNS.Location = new System.Drawing.Point(147, 158);
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
            // txtNetworkInterface
            // 
            this.txtNetworkInterface.AccessibleName = "";
            this.txtNetworkInterface.Location = new System.Drawing.Point(200, 120);
            this.txtNetworkInterface.Name = "txtNetworkInterface";
            this.txtNetworkInterface.Size = new System.Drawing.Size(100, 20);
            this.txtNetworkInterface.TabIndex = 11;
            this.txtNetworkInterface.Text = "WiFi or Ethernet";
            // 
            // networkInterfaceLabel
            // 
            this.networkInterfaceLabel.AutoSize = true;
            this.networkInterfaceLabel.Location = new System.Drawing.Point(99, 123);
            this.networkInterfaceLabel.Name = "networkInterfaceLabel";
            this.networkInterfaceLabel.Size = new System.Drawing.Size(95, 13);
            this.networkInterfaceLabel.TabIndex = 8;
            this.networkInterfaceLabel.Text = "Network Interface:";
            // 
            // alternativeDnsLabel
            // 
            this.alternativeDnsLabel.AutoSize = true;
            this.alternativeDnsLabel.Location = new System.Drawing.Point(108, 70);
            this.alternativeDnsLabel.Name = "alternativeDnsLabel";
            this.alternativeDnsLabel.Size = new System.Drawing.Size(86, 13);
            this.alternativeDnsLabel.TabIndex = 7;
            this.alternativeDnsLabel.Text = "Alternative DNS:";
            // 
            // txtAlternateDNS
            // 
            this.txtAlternateDNS.Location = new System.Drawing.Point(200, 67);
            this.txtAlternateDNS.Name = "txtAlternateDNS";
            this.txtAlternateDNS.Size = new System.Drawing.Size(100, 20);
            this.txtAlternateDNS.TabIndex = 10;
            this.txtAlternateDNS.Text = "1.0.0.1";
            // 
            // chkShowConsole
            // 
            this.chkShowConsole.AutoSize = true;
            this.chkShowConsole.Location = new System.Drawing.Point(159, 117);
            this.chkShowConsole.Name = "chkShowConsole";
            this.chkShowConsole.Size = new System.Drawing.Size(94, 17);
            this.chkShowConsole.TabIndex = 14;
            this.chkShowConsole.Text = "Show Console";
            this.chkShowConsole.UseVisualStyleBackColor = true;
            // 
            // dnschanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.dpıSettigsGroupBox);
            this.Controls.Add(this.dnsSettigsGroupBox);
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "dnschanger";
            this.ShowIcon = false;
            this.Text = "DNS Changer";
            this.Load += new System.EventHandler(this.dnschanger_Load);
            this.dpıSettigsGroupBox.ResumeLayout(false);
            this.dpıSettigsGroupBox.PerformLayout();
            this.dnsSettigsGroupBox.ResumeLayout(false);
            this.dnsSettigsGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtNetworkInterface;
        private System.Windows.Forms.Label networkInterfaceLabel;
        private System.Windows.Forms.Label alternativeDnsLabel;
        private System.Windows.Forms.TextBox txtAlternateDNS;
        private System.Windows.Forms.CheckBox chkShowConsole;
    }
}


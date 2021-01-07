namespace NoIP_Updater
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.actionMenu = new System.Windows.Forms.MenuStrip();
            this.einstelllungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flushDNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicIPv4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicIPv6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbox_status = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_hosts = new System.Windows.Forms.Button();
            this.l_next_chk = new System.Windows.Forms.Label();
            this.l_status_hosts = new System.Windows.Forms.Label();
            this.l_hosts = new System.Windows.Forms.Label();
            this.l_status_next_check = new System.Windows.Forms.Label();
            this.pb_status_hosts = new System.Windows.Forms.PictureBox();
            this.btn_acc = new System.Windows.Forms.Button();
            this.l_status_acc = new System.Windows.Forms.Label();
            this.l_account = new System.Windows.Forms.Label();
            this.pb_status_acc = new System.Windows.Forms.PictureBox();
            this.l_status_ipv4 = new System.Windows.Forms.Label();
            this.l_ipv4 = new System.Windows.Forms.Label();
            this.pb_status_ipv6 = new System.Windows.Forms.PictureBox();
            this.l_status_ipv6 = new System.Windows.Forms.Label();
            this.l_ipv6 = new System.Windows.Forms.Label();
            this.pb_status_ipv4 = new System.Windows.Forms.PictureBox();
            this.notifyIconNoIP = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIPv4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIPv6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipUpdater = new System.Windows.Forms.Timer(this.components);
            this.l_log = new System.Windows.Forms.Label();
            this.l_status_log = new System.Windows.Forms.Label();
            this.actionMenu.SuspendLayout();
            this.gbox_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_hosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_ipv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_ipv4)).BeginInit();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionMenu
            // 
            this.actionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstelllungenToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.clipboardToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.actionMenu.Location = new System.Drawing.Point(0, 0);
            this.actionMenu.Name = "actionMenu";
            this.actionMenu.Size = new System.Drawing.Size(409, 24);
            this.actionMenu.TabIndex = 0;
            this.actionMenu.Text = "Menü";
            // 
            // einstelllungenToolStripMenuItem
            // 
            this.einstelllungenToolStripMenuItem.Name = "einstelllungenToolStripMenuItem";
            this.einstelllungenToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.einstelllungenToolStripMenuItem.Text = "Settings";
            this.einstelllungenToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flushDNSToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // flushDNSToolStripMenuItem
            // 
            this.flushDNSToolStripMenuItem.Name = "flushDNSToolStripMenuItem";
            this.flushDNSToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.flushDNSToolStripMenuItem.Text = "Flush DNS";
            this.flushDNSToolStripMenuItem.Click += new System.EventHandler(this.flushDNSToolStripMenuItem_Click);
            // 
            // clipboardToolStripMenuItem
            // 
            this.clipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicIPv4ToolStripMenuItem,
            this.publicIPv6ToolStripMenuItem});
            this.clipboardToolStripMenuItem.Name = "clipboardToolStripMenuItem";
            this.clipboardToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.clipboardToolStripMenuItem.Text = "Clipboard";
            // 
            // publicIPv4ToolStripMenuItem
            // 
            this.publicIPv4ToolStripMenuItem.Name = "publicIPv4ToolStripMenuItem";
            this.publicIPv4ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.publicIPv4ToolStripMenuItem.Text = "Copy IPv4";
            this.publicIPv4ToolStripMenuItem.Click += new System.EventHandler(this.publicIPv4ToolStripMenuItem_Click);
            // 
            // publicIPv6ToolStripMenuItem
            // 
            this.publicIPv6ToolStripMenuItem.Name = "publicIPv6ToolStripMenuItem";
            this.publicIPv6ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.publicIPv6ToolStripMenuItem.Text = "Copy IPv6";
            this.publicIPv6ToolStripMenuItem.Click += new System.EventHandler(this.publicIPv6ToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // gbox_status
            // 
            this.gbox_status.Controls.Add(this.btn_refresh);
            this.gbox_status.Controls.Add(this.btn_hosts);
            this.gbox_status.Controls.Add(this.l_next_chk);
            this.gbox_status.Controls.Add(this.l_status_hosts);
            this.gbox_status.Controls.Add(this.l_hosts);
            this.gbox_status.Controls.Add(this.l_status_next_check);
            this.gbox_status.Controls.Add(this.pb_status_hosts);
            this.gbox_status.Controls.Add(this.btn_acc);
            this.gbox_status.Controls.Add(this.l_status_acc);
            this.gbox_status.Controls.Add(this.l_account);
            this.gbox_status.Controls.Add(this.pb_status_acc);
            this.gbox_status.Controls.Add(this.l_status_ipv4);
            this.gbox_status.Controls.Add(this.l_ipv4);
            this.gbox_status.Controls.Add(this.pb_status_ipv6);
            this.gbox_status.Controls.Add(this.l_status_ipv6);
            this.gbox_status.Controls.Add(this.l_ipv6);
            this.gbox_status.Controls.Add(this.pb_status_ipv4);
            this.gbox_status.Location = new System.Drawing.Point(12, 44);
            this.gbox_status.Name = "gbox_status";
            this.gbox_status.Size = new System.Drawing.Size(385, 186);
            this.gbox_status.TabIndex = 2;
            this.gbox_status.TabStop = false;
            this.gbox_status.Text = "Status";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(281, 122);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(77, 28);
            this.btn_refresh.TabIndex = 21;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_hosts
            // 
            this.btn_hosts.Location = new System.Drawing.Point(281, 61);
            this.btn_hosts.Name = "btn_hosts";
            this.btn_hosts.Size = new System.Drawing.Size(77, 28);
            this.btn_hosts.TabIndex = 19;
            this.btn_hosts.Text = "Edit";
            this.btn_hosts.UseVisualStyleBackColor = true;
            this.btn_hosts.Click += new System.EventHandler(this.btn_hosts_Click);
            // 
            // l_next_chk
            // 
            this.l_next_chk.AutoSize = true;
            this.l_next_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_next_chk.Location = new System.Drawing.Point(223, 0);
            this.l_next_chk.Name = "l_next_chk";
            this.l_next_chk.Size = new System.Drawing.Size(76, 13);
            this.l_next_chk.TabIndex = 20;
            this.l_next_chk.Text = "Next check:";
            // 
            // l_status_hosts
            // 
            this.l_status_hosts.AutoSize = true;
            this.l_status_hosts.Location = new System.Drawing.Point(46, 76);
            this.l_status_hosts.Name = "l_status_hosts";
            this.l_status_hosts.Size = new System.Drawing.Size(41, 13);
            this.l_status_hosts.TabIndex = 18;
            this.l_status_hosts.Text = "0 hosts";
            // 
            // l_hosts
            // 
            this.l_hosts.AutoSize = true;
            this.l_hosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_hosts.Location = new System.Drawing.Point(46, 61);
            this.l_hosts.Name = "l_hosts";
            this.l_hosts.Size = new System.Drawing.Size(43, 13);
            this.l_hosts.TabIndex = 17;
            this.l_hosts.Text = "Hosts:";
            // 
            // l_status_next_check
            // 
            this.l_status_next_check.AutoSize = true;
            this.l_status_next_check.Location = new System.Drawing.Point(305, 0);
            this.l_status_next_check.Name = "l_status_next_check";
            this.l_status_next_check.Size = new System.Drawing.Size(49, 13);
            this.l_status_next_check.TabIndex = 10;
            this.l_status_next_check.Text = "00:00:00";
            // 
            // pb_status_hosts
            // 
            this.pb_status_hosts.BackColor = System.Drawing.Color.Red;
            this.pb_status_hosts.Location = new System.Drawing.Point(12, 61);
            this.pb_status_hosts.Name = "pb_status_hosts";
            this.pb_status_hosts.Size = new System.Drawing.Size(28, 28);
            this.pb_status_hosts.TabIndex = 16;
            this.pb_status_hosts.TabStop = false;
            // 
            // btn_acc
            // 
            this.btn_acc.Location = new System.Drawing.Point(281, 19);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(77, 28);
            this.btn_acc.TabIndex = 15;
            this.btn_acc.Text = "Edit";
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // l_status_acc
            // 
            this.l_status_acc.AutoSize = true;
            this.l_status_acc.Location = new System.Drawing.Point(46, 34);
            this.l_status_acc.Name = "l_status_acc";
            this.l_status_acc.Size = new System.Drawing.Size(16, 13);
            this.l_status_acc.TabIndex = 14;
            this.l_status_acc.Text = "...";
            // 
            // l_account
            // 
            this.l_account.AutoSize = true;
            this.l_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_account.Location = new System.Drawing.Point(46, 19);
            this.l_account.Name = "l_account";
            this.l_account.Size = new System.Drawing.Size(58, 13);
            this.l_account.TabIndex = 13;
            this.l_account.Text = "Account:";
            // 
            // pb_status_acc
            // 
            this.pb_status_acc.BackColor = System.Drawing.Color.Red;
            this.pb_status_acc.Location = new System.Drawing.Point(12, 19);
            this.pb_status_acc.Name = "pb_status_acc";
            this.pb_status_acc.Size = new System.Drawing.Size(28, 28);
            this.pb_status_acc.TabIndex = 12;
            this.pb_status_acc.TabStop = false;
            // 
            // l_status_ipv4
            // 
            this.l_status_ipv4.AutoSize = true;
            this.l_status_ipv4.Location = new System.Drawing.Point(46, 163);
            this.l_status_ipv4.Name = "l_status_ipv4";
            this.l_status_ipv4.Size = new System.Drawing.Size(16, 13);
            this.l_status_ipv4.TabIndex = 9;
            this.l_status_ipv4.Text = "...";
            // 
            // l_ipv4
            // 
            this.l_ipv4.AutoSize = true;
            this.l_ipv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ipv4.Location = new System.Drawing.Point(46, 148);
            this.l_ipv4.Name = "l_ipv4";
            this.l_ipv4.Size = new System.Drawing.Size(37, 13);
            this.l_ipv4.TabIndex = 7;
            this.l_ipv4.Text = "IPv4:";
            // 
            // pb_status_ipv6
            // 
            this.pb_status_ipv6.BackColor = System.Drawing.Color.Red;
            this.pb_status_ipv6.Location = new System.Drawing.Point(12, 148);
            this.pb_status_ipv6.Name = "pb_status_ipv6";
            this.pb_status_ipv6.Size = new System.Drawing.Size(28, 28);
            this.pb_status_ipv6.TabIndex = 6;
            this.pb_status_ipv6.TabStop = false;
            // 
            // l_status_ipv6
            // 
            this.l_status_ipv6.AutoSize = true;
            this.l_status_ipv6.Location = new System.Drawing.Point(46, 119);
            this.l_status_ipv6.Name = "l_status_ipv6";
            this.l_status_ipv6.Size = new System.Drawing.Size(16, 13);
            this.l_status_ipv6.TabIndex = 3;
            this.l_status_ipv6.Text = "...";
            // 
            // l_ipv6
            // 
            this.l_ipv6.AutoSize = true;
            this.l_ipv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ipv6.Location = new System.Drawing.Point(46, 104);
            this.l_ipv6.Name = "l_ipv6";
            this.l_ipv6.Size = new System.Drawing.Size(37, 13);
            this.l_ipv6.TabIndex = 1;
            this.l_ipv6.Text = "IPv6:";
            // 
            // pb_status_ipv4
            // 
            this.pb_status_ipv4.BackColor = System.Drawing.Color.Red;
            this.pb_status_ipv4.Location = new System.Drawing.Point(12, 104);
            this.pb_status_ipv4.Name = "pb_status_ipv4";
            this.pb_status_ipv4.Size = new System.Drawing.Size(28, 28);
            this.pb_status_ipv4.TabIndex = 0;
            this.pb_status_ipv4.TabStop = false;
            // 
            // notifyIconNoIP
            // 
            this.notifyIconNoIP.ContextMenuStrip = this.trayMenu;
            this.notifyIconNoIP.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconNoIP.Icon")));
            this.notifyIconNoIP.Text = "No-IP Updater";
            this.notifyIconNoIP.Visible = true;
            this.notifyIconNoIP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconNoIP_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.copyIPv4ToolStripMenuItem,
            this.copyIPv6ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(128, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // copyIPv4ToolStripMenuItem
            // 
            this.copyIPv4ToolStripMenuItem.Name = "copyIPv4ToolStripMenuItem";
            this.copyIPv4ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyIPv4ToolStripMenuItem.Text = "Copy IPv4";
            this.copyIPv4ToolStripMenuItem.Click += new System.EventHandler(this.copyIPv4ToolStripMenuItem_Click);
            // 
            // copyIPv6ToolStripMenuItem
            // 
            this.copyIPv6ToolStripMenuItem.Name = "copyIPv6ToolStripMenuItem";
            this.copyIPv6ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyIPv6ToolStripMenuItem.Text = "Copy IPv6";
            this.copyIPv6ToolStripMenuItem.Click += new System.EventHandler(this.copyIPv6ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ipUpdater
            // 
            this.ipUpdater.Interval = 1000;
            this.ipUpdater.Tick += new System.EventHandler(this.ipUpdater_Tick);
            // 
            // l_log
            // 
            this.l_log.AutoSize = true;
            this.l_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_log.Location = new System.Drawing.Point(16, 232);
            this.l_log.Name = "l_log";
            this.l_log.Size = new System.Drawing.Size(32, 13);
            this.l_log.TabIndex = 23;
            this.l_log.Text = "Log:";
            // 
            // l_status_log
            // 
            this.l_status_log.AutoSize = true;
            this.l_status_log.Location = new System.Drawing.Point(53, 232);
            this.l_status_log.Name = "l_status_log";
            this.l_status_log.Size = new System.Drawing.Size(10, 13);
            this.l_status_log.TabIndex = 22;
            this.l_status_log.Text = "-";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 253);
            this.Controls.Add(this.l_log);
            this.Controls.Add(this.l_status_log);
            this.Controls.Add(this.gbox_status);
            this.Controls.Add(this.actionMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.actionMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic DNS Update Client - IPv4 & IPv6";
            this.Load += new System.EventHandler(this.Main_Load);
            this.actionMenu.ResumeLayout(false);
            this.actionMenu.PerformLayout();
            this.gbox_status.ResumeLayout(false);
            this.gbox_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_hosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_ipv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status_ipv4)).EndInit();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip actionMenu;
        private System.Windows.Forms.ToolStripMenuItem einstelllungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flushDNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicIPv4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicIPv6ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbox_status;
        private System.Windows.Forms.PictureBox pb_status_ipv4;
        private System.Windows.Forms.Label l_status_ipv6;
        private System.Windows.Forms.Label l_ipv6;
        private System.Windows.Forms.Label l_status_acc;
        private System.Windows.Forms.Label l_account;
        private System.Windows.Forms.PictureBox pb_status_acc;
        private System.Windows.Forms.Label l_status_next_check;
        private System.Windows.Forms.Label l_status_ipv4;
        private System.Windows.Forms.Label l_ipv4;
        private System.Windows.Forms.PictureBox pb_status_ipv6;
        private System.Windows.Forms.Button btn_hosts;
        private System.Windows.Forms.Label l_status_hosts;
        private System.Windows.Forms.Label l_hosts;
        private System.Windows.Forms.PictureBox pb_status_hosts;
        private System.Windows.Forms.Button btn_acc;
        private System.Windows.Forms.Label l_next_chk;
        private System.Windows.Forms.NotifyIcon notifyIconNoIP;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyIPv4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyIPv6ToolStripMenuItem;
        private System.Windows.Forms.Timer ipUpdater;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label l_log;
        private System.Windows.Forms.Label l_status_log;
    }
}


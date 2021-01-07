namespace NoIP_Updater
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.cbox_run_background = new System.Windows.Forms.CheckBox();
            this.cbox_autostart = new System.Windows.Forms.CheckBox();
            this.gbox_startup = new System.Windows.Forms.GroupBox();
            this.gbox_net_opts_ipv4 = new System.Windows.Forms.GroupBox();
            this.rbtn_local_net_adapter_ipv4 = new System.Windows.Forms.RadioButton();
            this.cbox_remote_alternate_ipv4 = new System.Windows.Forms.CheckBox();
            this.rbtn_remote_ipv4 = new System.Windows.Forms.RadioButton();
            this.combox_adapt = new System.Windows.Forms.ComboBox();
            this.l_net_adapt_ipv4 = new System.Windows.Forms.Label();
            this.gbox_net_opts_ipv6 = new System.Windows.Forms.GroupBox();
            this.rbtn_wanip_adapter_tmp = new System.Windows.Forms.RadioButton();
            this.rbtn_local_net_adapter_ipv6 = new System.Windows.Forms.RadioButton();
            this.rbtn_wanip_adapter = new System.Windows.Forms.RadioButton();
            this.cbox_remote_alternate_ipv6 = new System.Windows.Forms.CheckBox();
            this.rbtn_remote_ipv6 = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.gbox_net_opts_adapter = new System.Windows.Forms.GroupBox();
            this.gbox_startup.SuspendLayout();
            this.gbox_net_opts_ipv4.SuspendLayout();
            this.gbox_net_opts_ipv6.SuspendLayout();
            this.gbox_net_opts_adapter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_run_background
            // 
            this.cbox_run_background.AutoSize = true;
            this.cbox_run_background.Enabled = false;
            this.cbox_run_background.Location = new System.Drawing.Point(6, 19);
            this.cbox_run_background.Name = "cbox_run_background";
            this.cbox_run_background.Size = new System.Drawing.Size(301, 17);
            this.cbox_run_background.TabIndex = 0;
            this.cbox_run_background.Text = "Enable background system service (Administrator required)";
            this.cbox_run_background.UseVisualStyleBackColor = true;
            // 
            // cbox_autostart
            // 
            this.cbox_autostart.AutoSize = true;
            this.cbox_autostart.Location = new System.Drawing.Point(6, 42);
            this.cbox_autostart.Name = "cbox_autostart";
            this.cbox_autostart.Size = new System.Drawing.Size(181, 17);
            this.cbox_autostart.TabIndex = 1;
            this.cbox_autostart.Text = "Start automatically with Windows";
            this.cbox_autostart.UseVisualStyleBackColor = true;
            // 
            // gbox_startup
            // 
            this.gbox_startup.Controls.Add(this.cbox_run_background);
            this.gbox_startup.Controls.Add(this.cbox_autostart);
            this.gbox_startup.Location = new System.Drawing.Point(12, 12);
            this.gbox_startup.Name = "gbox_startup";
            this.gbox_startup.Size = new System.Drawing.Size(316, 65);
            this.gbox_startup.TabIndex = 2;
            this.gbox_startup.TabStop = false;
            this.gbox_startup.Text = "Startup";
            // 
            // gbox_net_opts_ipv4
            // 
            this.gbox_net_opts_ipv4.Controls.Add(this.rbtn_local_net_adapter_ipv4);
            this.gbox_net_opts_ipv4.Controls.Add(this.cbox_remote_alternate_ipv4);
            this.gbox_net_opts_ipv4.Controls.Add(this.rbtn_remote_ipv4);
            this.gbox_net_opts_ipv4.Location = new System.Drawing.Point(12, 152);
            this.gbox_net_opts_ipv4.Name = "gbox_net_opts_ipv4";
            this.gbox_net_opts_ipv4.Size = new System.Drawing.Size(316, 87);
            this.gbox_net_opts_ipv4.TabIndex = 3;
            this.gbox_net_opts_ipv4.TabStop = false;
            this.gbox_net_opts_ipv4.Text = "IPv4 Options";
            // 
            // rbtn_local_net_adapter_ipv4
            // 
            this.rbtn_local_net_adapter_ipv4.AutoSize = true;
            this.rbtn_local_net_adapter_ipv4.Location = new System.Drawing.Point(9, 64);
            this.rbtn_local_net_adapter_ipv4.Name = "rbtn_local_net_adapter_ipv4";
            this.rbtn_local_net_adapter_ipv4.Size = new System.Drawing.Size(171, 17);
            this.rbtn_local_net_adapter_ipv4.TabIndex = 8;
            this.rbtn_local_net_adapter_ipv4.Text = "Use the IP of the local network";
            this.rbtn_local_net_adapter_ipv4.UseVisualStyleBackColor = true;
            this.rbtn_local_net_adapter_ipv4.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // cbox_remote_alternate_ipv4
            // 
            this.cbox_remote_alternate_ipv4.AutoSize = true;
            this.cbox_remote_alternate_ipv4.Location = new System.Drawing.Point(27, 41);
            this.cbox_remote_alternate_ipv4.Name = "cbox_remote_alternate_ipv4";
            this.cbox_remote_alternate_ipv4.Size = new System.Drawing.Size(105, 17);
            this.cbox_remote_alternate_ipv4.TabIndex = 5;
            this.cbox_remote_alternate_ipv4.Text = "Try alternate API";
            this.cbox_remote_alternate_ipv4.UseVisualStyleBackColor = true;
            this.cbox_remote_alternate_ipv4.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // rbtn_remote_ipv4
            // 
            this.rbtn_remote_ipv4.AutoSize = true;
            this.rbtn_remote_ipv4.Checked = true;
            this.rbtn_remote_ipv4.Location = new System.Drawing.Point(9, 18);
            this.rbtn_remote_ipv4.Name = "rbtn_remote_ipv4";
            this.rbtn_remote_ipv4.Size = new System.Drawing.Size(142, 17);
            this.rbtn_remote_ipv4.TabIndex = 4;
            this.rbtn_remote_ipv4.TabStop = true;
            this.rbtn_remote_ipv4.Text = "Detect IP via remote API";
            this.rbtn_remote_ipv4.UseVisualStyleBackColor = true;
            this.rbtn_remote_ipv4.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // combox_adapt
            // 
            this.combox_adapt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_adapt.FormattingEnabled = true;
            this.combox_adapt.Location = new System.Drawing.Point(9, 32);
            this.combox_adapt.Name = "combox_adapt";
            this.combox_adapt.Size = new System.Drawing.Size(298, 21);
            this.combox_adapt.TabIndex = 1;
            // 
            // l_net_adapt_ipv4
            // 
            this.l_net_adapt_ipv4.AutoSize = true;
            this.l_net_adapt_ipv4.Location = new System.Drawing.Point(6, 16);
            this.l_net_adapt_ipv4.Name = "l_net_adapt_ipv4";
            this.l_net_adapt_ipv4.Size = new System.Drawing.Size(87, 13);
            this.l_net_adapt_ipv4.TabIndex = 0;
            this.l_net_adapt_ipv4.Text = "Network Adapter";
            // 
            // gbox_net_opts_ipv6
            // 
            this.gbox_net_opts_ipv6.Controls.Add(this.rbtn_wanip_adapter_tmp);
            this.gbox_net_opts_ipv6.Controls.Add(this.rbtn_local_net_adapter_ipv6);
            this.gbox_net_opts_ipv6.Controls.Add(this.rbtn_wanip_adapter);
            this.gbox_net_opts_ipv6.Controls.Add(this.cbox_remote_alternate_ipv6);
            this.gbox_net_opts_ipv6.Controls.Add(this.rbtn_remote_ipv6);
            this.gbox_net_opts_ipv6.Location = new System.Drawing.Point(12, 245);
            this.gbox_net_opts_ipv6.Name = "gbox_net_opts_ipv6";
            this.gbox_net_opts_ipv6.Size = new System.Drawing.Size(316, 147);
            this.gbox_net_opts_ipv6.TabIndex = 9;
            this.gbox_net_opts_ipv6.TabStop = false;
            this.gbox_net_opts_ipv6.Text = "IPv6 Options";
            // 
            // rbtn_wanip_adapter_tmp
            // 
            this.rbtn_wanip_adapter_tmp.AutoSize = true;
            this.rbtn_wanip_adapter_tmp.Location = new System.Drawing.Point(9, 121);
            this.rbtn_wanip_adapter_tmp.Name = "rbtn_wanip_adapter_tmp";
            this.rbtn_wanip_adapter_tmp.Size = new System.Drawing.Size(220, 17);
            this.rbtn_wanip_adapter_tmp.TabIndex = 10;
            this.rbtn_wanip_adapter_tmp.Text = "Get public IPv6 from Adapter (Temporary)";
            this.rbtn_wanip_adapter_tmp.UseVisualStyleBackColor = true;
            this.rbtn_wanip_adapter_tmp.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // rbtn_local_net_adapter_ipv6
            // 
            this.rbtn_local_net_adapter_ipv6.AutoSize = true;
            this.rbtn_local_net_adapter_ipv6.Location = new System.Drawing.Point(9, 71);
            this.rbtn_local_net_adapter_ipv6.Name = "rbtn_local_net_adapter_ipv6";
            this.rbtn_local_net_adapter_ipv6.Size = new System.Drawing.Size(171, 17);
            this.rbtn_local_net_adapter_ipv6.TabIndex = 9;
            this.rbtn_local_net_adapter_ipv6.Text = "Use the IP of the local network";
            this.rbtn_local_net_adapter_ipv6.UseVisualStyleBackColor = true;
            this.rbtn_local_net_adapter_ipv6.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // rbtn_wanip_adapter
            // 
            this.rbtn_wanip_adapter.AutoSize = true;
            this.rbtn_wanip_adapter.Location = new System.Drawing.Point(9, 96);
            this.rbtn_wanip_adapter.Name = "rbtn_wanip_adapter";
            this.rbtn_wanip_adapter.Size = new System.Drawing.Size(161, 17);
            this.rbtn_wanip_adapter.TabIndex = 8;
            this.rbtn_wanip_adapter.Text = "Get public IPv6 from Adapter";
            this.rbtn_wanip_adapter.UseVisualStyleBackColor = true;
            this.rbtn_wanip_adapter.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // cbox_remote_alternate_ipv6
            // 
            this.cbox_remote_alternate_ipv6.AutoSize = true;
            this.cbox_remote_alternate_ipv6.Location = new System.Drawing.Point(27, 44);
            this.cbox_remote_alternate_ipv6.Name = "cbox_remote_alternate_ipv6";
            this.cbox_remote_alternate_ipv6.Size = new System.Drawing.Size(105, 17);
            this.cbox_remote_alternate_ipv6.TabIndex = 5;
            this.cbox_remote_alternate_ipv6.Text = "Try alternate API";
            this.cbox_remote_alternate_ipv6.UseVisualStyleBackColor = true;
            this.cbox_remote_alternate_ipv6.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // rbtn_remote_ipv6
            // 
            this.rbtn_remote_ipv6.AutoSize = true;
            this.rbtn_remote_ipv6.Checked = true;
            this.rbtn_remote_ipv6.Location = new System.Drawing.Point(9, 21);
            this.rbtn_remote_ipv6.Name = "rbtn_remote_ipv6";
            this.rbtn_remote_ipv6.Size = new System.Drawing.Size(142, 17);
            this.rbtn_remote_ipv6.TabIndex = 4;
            this.rbtn_remote_ipv6.TabStop = true;
            this.rbtn_remote_ipv6.Text = "Detect IP via remote API";
            this.rbtn_remote_ipv6.UseVisualStyleBackColor = true;
            this.rbtn_remote_ipv6.CheckedChanged += new System.EventHandler(this.rbtn_local_net_adapter_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 398);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(316, 31);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gbox_net_opts_adapter
            // 
            this.gbox_net_opts_adapter.Controls.Add(this.l_net_adapt_ipv4);
            this.gbox_net_opts_adapter.Controls.Add(this.combox_adapt);
            this.gbox_net_opts_adapter.Location = new System.Drawing.Point(12, 83);
            this.gbox_net_opts_adapter.Name = "gbox_net_opts_adapter";
            this.gbox_net_opts_adapter.Size = new System.Drawing.Size(316, 63);
            this.gbox_net_opts_adapter.TabIndex = 11;
            this.gbox_net_opts_adapter.TabStop = false;
            this.gbox_net_opts_adapter.Text = "Adapter Options";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 438);
            this.Controls.Add(this.gbox_net_opts_adapter);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gbox_net_opts_ipv6);
            this.Controls.Add(this.gbox_net_opts_ipv4);
            this.Controls.Add(this.gbox_startup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbox_startup.ResumeLayout(false);
            this.gbox_startup.PerformLayout();
            this.gbox_net_opts_ipv4.ResumeLayout(false);
            this.gbox_net_opts_ipv4.PerformLayout();
            this.gbox_net_opts_ipv6.ResumeLayout(false);
            this.gbox_net_opts_ipv6.PerformLayout();
            this.gbox_net_opts_adapter.ResumeLayout(false);
            this.gbox_net_opts_adapter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbox_run_background;
        private System.Windows.Forms.CheckBox cbox_autostart;
        private System.Windows.Forms.GroupBox gbox_startup;
        private System.Windows.Forms.GroupBox gbox_net_opts_ipv4;
        private System.Windows.Forms.Label l_net_adapt_ipv4;
        private System.Windows.Forms.ComboBox combox_adapt;
        private System.Windows.Forms.RadioButton rbtn_remote_ipv4;
        private System.Windows.Forms.RadioButton rbtn_local_net_adapter_ipv4;
        private System.Windows.Forms.CheckBox cbox_remote_alternate_ipv4;
        private System.Windows.Forms.GroupBox gbox_net_opts_ipv6;
        private System.Windows.Forms.RadioButton rbtn_wanip_adapter;
        private System.Windows.Forms.CheckBox cbox_remote_alternate_ipv6;
        private System.Windows.Forms.RadioButton rbtn_remote_ipv6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RadioButton rbtn_local_net_adapter_ipv6;
        private System.Windows.Forms.RadioButton rbtn_wanip_adapter_tmp;
        private System.Windows.Forms.GroupBox gbox_net_opts_adapter;
    }
}
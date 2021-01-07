namespace NoIP_Updater
{
    partial class Hosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hosts));
            this.l_info = new System.Windows.Forms.Label();
            this.rtxt_list = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Location = new System.Drawing.Point(21, 20);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(290, 39);
            this.l_info.TabIndex = 0;
            this.l_info.Text = "Please enter the hosts you want to associate with this client.\r\n\r\nEnter the hostn" +
    "ames and seperate them with a new line.";
            // 
            // rtxt_list
            // 
            this.rtxt_list.Location = new System.Drawing.Point(24, 66);
            this.rtxt_list.Name = "rtxt_list";
            this.rtxt_list.Size = new System.Drawing.Size(287, 175);
            this.rtxt_list.TabIndex = 1;
            this.rtxt_list.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(24, 247);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(287, 25);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Hosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 291);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rtxt_list);
            this.Controls.Add(this.l_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Groups/Hosts";
            this.Load += new System.EventHandler(this.Hosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.RichTextBox rtxt_list;
        private System.Windows.Forms.Button btn_save;
    }
}
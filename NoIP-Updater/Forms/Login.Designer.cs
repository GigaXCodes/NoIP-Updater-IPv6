namespace NoIP_Updater
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.l_usrname = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.l_passwd = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_usrname
            // 
            this.l_usrname.AutoSize = true;
            this.l_usrname.Location = new System.Drawing.Point(31, 37);
            this.l_usrname.Name = "l_usrname";
            this.l_usrname.Size = new System.Drawing.Size(92, 13);
            this.l_usrname.TabIndex = 0;
            this.l_usrname.Text = "Username/E-Mail:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(34, 53);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(204, 20);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(34, 92);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(204, 20);
            this.txt_password.TabIndex = 3;
            // 
            // l_passwd
            // 
            this.l_passwd.AutoSize = true;
            this.l_passwd.Location = new System.Drawing.Point(31, 76);
            this.l_passwd.Name = "l_passwd";
            this.l_passwd.Size = new System.Drawing.Size(56, 13);
            this.l_passwd.TabIndex = 2;
            this.l_passwd.Text = "Password:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(34, 118);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(204, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 173);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.l_passwd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.l_usrname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_usrname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label l_passwd;
        private System.Windows.Forms.Button btn_save;
    }
}
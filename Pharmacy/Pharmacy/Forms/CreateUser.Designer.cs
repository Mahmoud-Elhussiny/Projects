namespace Pharmacy.Forms
{
    partial class CreateUser
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Homepanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.loginpanel.SuspendLayout();
            this.Homepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginpanel.Controls.Add(this.label2);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Controls.Add(this.loginbtn);
            this.loginpanel.Controls.Add(this.password);
            this.loginpanel.Controls.Add(this.username);
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(800, 450);
            this.loginpanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbtn.BackColor = System.Drawing.Color.Silver;
            this.loginbtn.Location = new System.Drawing.Point(238, 248);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(249, 25);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "تسجيل الدخــــول";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(238, 175);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password.Size = new System.Drawing.Size(249, 23);
            this.password.TabIndex = 0;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Location = new System.Drawing.Point(238, 112);
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.Size = new System.Drawing.Size(249, 23);
            this.username.TabIndex = 0;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Homepanel
            // 
            this.Homepanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Homepanel.Controls.Add(this.label3);
            this.Homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Homepanel.Location = new System.Drawing.Point(0, 0);
            this.Homepanel.Name = "Homepanel";
            this.Homepanel.Size = new System.Drawing.Size(800, 450);
            this.Homepanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(358, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Homepanel);
            this.Controls.Add(this.loginpanel);
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.Homepanel.ResumeLayout(false);
            this.Homepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginpanel;
        private Button loginbtn;
        private TextBox password;
        private TextBox username;
        private Label label2;
        private Label label1;
        private Panel Homepanel;
        private Label label3;
    }
}
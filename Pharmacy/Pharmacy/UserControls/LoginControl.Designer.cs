namespace Pharmacy.UserControls
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.userName_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.AccountType_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName_text
            // 
            resources.ApplyResources(this.userName_text, "userName_text");
            this.userName_text.BackColor = System.Drawing.SystemColors.Window;
            this.userName_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName_text.Name = "userName_text";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Password_text
            // 
            resources.ApplyResources(this.Password_text, "Password_text");
            this.Password_text.BackColor = System.Drawing.SystemColors.Window;
            this.Password_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_text.Name = "Password_text";
            this.Password_text.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Login_Btn
            // 
            resources.ApplyResources(this.Login_Btn, "Login_Btn");
            this.Login_Btn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // AccountType_combo
            // 
            resources.ApplyResources(this.AccountType_combo, "AccountType_combo");
            this.AccountType_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountType_combo.FormattingEnabled = true;
            this.AccountType_combo.Name = "AccountType_combo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // LoginControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.AccountType_combo);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.userName_text);
            this.Name = "LoginControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userName_text;
        private Label label1;
        private TextBox Password_text;
        private Label label2;
        private Button Login_Btn;
        private ComboBox AccountType_combo;
        private Label label3;
    }
}

namespace Pharmacy.UserControls
{
    partial class CreateCatigory
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
            this.label1 = new System.Windows.Forms.Label();
            this.CatigoryName_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateCatigory_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "إضافة فئة جديدة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatigoryName_Text
            // 
            this.CatigoryName_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CatigoryName_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatigoryName_Text.Location = new System.Drawing.Point(225, 104);
            this.CatigoryName_Text.Name = "CatigoryName_Text";
            this.CatigoryName_Text.Size = new System.Drawing.Size(279, 25);
            this.CatigoryName_Text.TabIndex = 1;
            this.CatigoryName_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(504, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الفئة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description_Text
            // 
            this.Description_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_Text.Location = new System.Drawing.Point(225, 158);
            this.Description_Text.Multiline = true;
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.Size = new System.Drawing.Size(279, 113);
            this.Description_Text.TabIndex = 3;
            this.Description_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(504, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "الوصف";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateCatigory_Btn
            // 
            this.CreateCatigory_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateCatigory_Btn.BackColor = System.Drawing.Color.LightGray;
            this.CreateCatigory_Btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateCatigory_Btn.Location = new System.Drawing.Point(225, 305);
            this.CreateCatigory_Btn.Name = "CreateCatigory_Btn";
            this.CreateCatigory_Btn.Size = new System.Drawing.Size(279, 41);
            this.CreateCatigory_Btn.TabIndex = 4;
            this.CreateCatigory_Btn.Text = "حـــفــــــــظ";
            this.CreateCatigory_Btn.UseVisualStyleBackColor = false;
            this.CreateCatigory_Btn.Click += new System.EventHandler(this.CreateCatigory_Btn_Click);
            // 
            // CreateCatigory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.CreateCatigory_Btn);
            this.Controls.Add(this.Description_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatigoryName_Text);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CreateCatigory";
            this.Size = new System.Drawing.Size(830, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox CatigoryName_Text;
        private Label label2;
        private TextBox Description_Text;
        private Label label3;
        private Button CreateCatigory_Btn;
    }
}

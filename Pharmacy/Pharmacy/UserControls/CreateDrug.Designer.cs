namespace Pharmacy.UserControls
{
    partial class CreateDrug
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.expirDate_Text = new System.Windows.Forms.DateTimePicker();
            this.Catigory_Combo = new System.Windows.Forms.ComboBox();
            this.CreateDrug_Btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfPice_Text = new System.Windows.Forms.TextBox();
            this.Quantity_Text = new System.Windows.Forms.TextBox();
            this.DrugCode_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.price_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DrugName_text = new System.Windows.Forms.TextBox();
            this.Manufacturer_Compo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "اضافة منتج جديد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Manufacturer_Compo);
            this.panel1.Controls.Add(this.expirDate_Text);
            this.panel1.Controls.Add(this.Catigory_Combo);
            this.panel1.Controls.Add(this.CreateDrug_Btn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numOfPice_Text);
            this.panel1.Controls.Add(this.Quantity_Text);
            this.panel1.Controls.Add(this.DrugCode_Text);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.price_Text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DrugName_text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 407);
            this.panel1.TabIndex = 1;
            // 
            // expirDate_Text
            // 
            this.expirDate_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expirDate_Text.Location = new System.Drawing.Point(227, 106);
            this.expirDate_Text.Name = "expirDate_Text";
            this.expirDate_Text.Size = new System.Drawing.Size(258, 25);
            this.expirDate_Text.TabIndex = 22;
            // 
            // Catigory_Combo
            // 
            this.Catigory_Combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Catigory_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Catigory_Combo.FormattingEnabled = true;
            this.Catigory_Combo.Location = new System.Drawing.Point(227, 266);
            this.Catigory_Combo.Name = "Catigory_Combo";
            this.Catigory_Combo.Size = new System.Drawing.Size(258, 28);
            this.Catigory_Combo.TabIndex = 21;
            // 
            // CreateDrug_Btn
            // 
            this.CreateDrug_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateDrug_Btn.BackColor = System.Drawing.Color.SeaGreen;
            this.CreateDrug_Btn.Location = new System.Drawing.Point(227, 358);
            this.CreateDrug_Btn.Name = "CreateDrug_Btn";
            this.CreateDrug_Btn.Size = new System.Drawing.Size(258, 44);
            this.CreateDrug_Btn.TabIndex = 20;
            this.CreateDrug_Btn.Text = "تسجيل";
            this.CreateDrug_Btn.UseVisualStyleBackColor = false;
            this.CreateDrug_Btn.Click += new System.EventHandler(this.CreateDrug_Btn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.CausesValidation = false;
            this.label8.Location = new System.Drawing.Point(485, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "الفئة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(485, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "عدد الشرائط";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(485, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "الكمية";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(485, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "كود المنتج";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfPice_Text
            // 
            this.numOfPice_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numOfPice_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfPice_Text.Location = new System.Drawing.Point(227, 226);
            this.numOfPice_Text.Name = "numOfPice_Text";
            this.numOfPice_Text.Size = new System.Drawing.Size(258, 25);
            this.numOfPice_Text.TabIndex = 13;
            this.numOfPice_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quantity_Text
            // 
            this.Quantity_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantity_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity_Text.Location = new System.Drawing.Point(227, 146);
            this.Quantity_Text.Name = "Quantity_Text";
            this.Quantity_Text.Size = new System.Drawing.Size(258, 25);
            this.Quantity_Text.TabIndex = 14;
            this.Quantity_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DrugCode_Text
            // 
            this.DrugCode_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrugCode_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrugCode_Text.Location = new System.Drawing.Point(227, 66);
            this.DrugCode_Text.Name = "DrugCode_Text";
            this.DrugCode_Text.Size = new System.Drawing.Size(258, 25);
            this.DrugCode_Text.TabIndex = 15;
            this.DrugCode_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(485, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "السعر";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_Text
            // 
            this.price_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_Text.Location = new System.Drawing.Point(227, 186);
            this.price_Text.Name = "price_Text";
            this.price_Text.Size = new System.Drawing.Size(258, 25);
            this.price_Text.TabIndex = 7;
            this.price_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(485, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "تاريخ الانتهاء";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(485, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "اسم المنتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrugName_text
            // 
            this.DrugName_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrugName_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrugName_text.Location = new System.Drawing.Point(227, 26);
            this.DrugName_text.Name = "DrugName_text";
            this.DrugName_text.Size = new System.Drawing.Size(258, 25);
            this.DrugName_text.TabIndex = 9;
            this.DrugName_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Manufacturer_Compo
            // 
            this.Manufacturer_Compo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Manufacturer_Compo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Manufacturer_Compo.FormattingEnabled = true;
            this.Manufacturer_Compo.Location = new System.Drawing.Point(227, 306);
            this.Manufacturer_Compo.Name = "Manufacturer_Compo";
            this.Manufacturer_Compo.Size = new System.Drawing.Size(258, 28);
            this.Manufacturer_Compo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.CausesValidation = false;
            this.label9.Location = new System.Drawing.Point(485, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "اسم الشركة";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateDrug";
            this.Size = new System.Drawing.Size(833, 452);
            this.Load += new System.EventHandler(this.CreateDrug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox Catigory_Combo;
        private Button CreateDrug_Btn;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox numOfPice_Text;
        private TextBox Quantity_Text;
        private TextBox DrugCode_Text;
        private Label label6;
        private TextBox price_Text;
        private Label label4;
        private Label label2;
        private TextBox DrugName_text;
        private DateTimePicker expirDate_Text;
        private ComboBox Manufacturer_Compo;
        private Label label9;
    }
}

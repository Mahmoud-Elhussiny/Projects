namespace Pharmacy.UserControls
{
    partial class CreateOrderItem
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
            this.DrugName_Label = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.price_Label = new System.Windows.Forms.Label();
            this.Type_Lable = new System.Windows.Forms.Label();
            this.type_panal = new System.Windows.Forms.Panel();
            this.pice_radio = new System.Windows.Forms.RadioButton();
            this.box_radio = new System.Windows.Forms.RadioButton();
            this.type_panal.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrugName_Label
            // 
            this.DrugName_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrugName_Label.BackColor = System.Drawing.SystemColors.GrayText;
            this.DrugName_Label.Location = new System.Drawing.Point(378, 3);
            this.DrugName_Label.Name = "DrugName_Label";
            this.DrugName_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DrugName_Label.Size = new System.Drawing.Size(130, 57);
            this.DrugName_Label.TabIndex = 0;
            this.DrugName_Label.Text = "اسم المنتج";
            this.DrugName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn.Size = new System.Drawing.Size(100, 57);
            this.btn.TabIndex = 1;
            this.btn.Text = "حذف";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // price_Label
            // 
            this.price_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_Label.BackColor = System.Drawing.SystemColors.GrayText;
            this.price_Label.Location = new System.Drawing.Point(107, 3);
            this.price_Label.Name = "price_Label";
            this.price_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.price_Label.Size = new System.Drawing.Size(130, 57);
            this.price_Label.TabIndex = 0;
            this.price_Label.Text = "السعر";
            this.price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Type_Lable
            // 
            this.Type_Lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Type_Lable.BackColor = System.Drawing.SystemColors.GrayText;
            this.Type_Lable.Location = new System.Drawing.Point(243, 3);
            this.Type_Lable.Name = "Type_Lable";
            this.Type_Lable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Type_Lable.Size = new System.Drawing.Size(130, 57);
            this.Type_Lable.TabIndex = 0;
            this.Type_Lable.Text = "علبة";
            this.Type_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_panal
            // 
            this.type_panal.BackColor = System.Drawing.SystemColors.Control;
            this.type_panal.Controls.Add(this.pice_radio);
            this.type_panal.Controls.Add(this.box_radio);
            this.type_panal.Location = new System.Drawing.Point(243, 3);
            this.type_panal.Name = "type_panal";
            this.type_panal.Size = new System.Drawing.Size(129, 56);
            this.type_panal.TabIndex = 2;
            // 
            // pice_radio
            // 
            this.pice_radio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pice_radio.BackColor = System.Drawing.SystemColors.Control;
            this.pice_radio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pice_radio.Location = new System.Drawing.Point(3, 15);
            this.pice_radio.Name = "pice_radio";
            this.pice_radio.Size = new System.Drawing.Size(67, 27);
            this.pice_radio.TabIndex = 0;
            this.pice_radio.Text = "شريط";
            this.pice_radio.UseVisualStyleBackColor = false;
            // 
            // box_radio
            // 
            this.box_radio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.box_radio.BackColor = System.Drawing.SystemColors.Control;
            this.box_radio.Checked = true;
            this.box_radio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.box_radio.Location = new System.Drawing.Point(76, 15);
            this.box_radio.Name = "box_radio";
            this.box_radio.Size = new System.Drawing.Size(50, 27);
            this.box_radio.TabIndex = 0;
            this.box_radio.TabStop = true;
            this.box_radio.Text = "علبة";
            this.box_radio.UseVisualStyleBackColor = false;
            // 
            // CreateOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.type_panal);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.price_Label);
            this.Controls.Add(this.Type_Lable);
            this.Controls.Add(this.DrugName_Label);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateOrderItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(511, 62);
            this.type_panal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label DrugName_Label;
        private Button btn;
        private Label price_Label;
        private Label Type_Lable;
        private Panel type_panal;
        private RadioButton box_radio;
        private RadioButton pice_radio;
    }
}

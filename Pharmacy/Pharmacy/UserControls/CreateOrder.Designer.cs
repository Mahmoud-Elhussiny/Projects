namespace Pharmacy.UserControls
{
    partial class CreateOrder
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
            this.OrderTitle_panal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DrugCode_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrugName_Text = new System.Windows.Forms.TextBox();
            this.totalprice_text = new System.Windows.Forms.Label();
            this.AddItem_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Items_flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderTitle_panal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderTitle_panal
            // 
            this.OrderTitle_panal.BackColor = System.Drawing.Color.Silver;
            this.OrderTitle_panal.Controls.Add(this.panel1);
            this.OrderTitle_panal.Controls.Add(this.totalprice_text);
            this.OrderTitle_panal.Controls.Add(this.AddItem_Btn);
            this.OrderTitle_panal.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderTitle_panal.Location = new System.Drawing.Point(0, 0);
            this.OrderTitle_panal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderTitle_panal.Name = "OrderTitle_panal";
            this.OrderTitle_panal.Size = new System.Drawing.Size(850, 83);
            this.OrderTitle_panal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DrugCode_Text);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DrugName_Text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(98, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 83);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(295, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "كود المنتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrugCode_Text
            // 
            this.DrugCode_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrugCode_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrugCode_Text.Location = new System.Drawing.Point(149, 50);
            this.DrugCode_Text.Name = "DrugCode_Text";
            this.DrugCode_Text.Size = new System.Drawing.Size(146, 25);
            this.DrugCode_Text.TabIndex = 4;
            this.DrugCode_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(295, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrugName_Text
            // 
            this.DrugName_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrugName_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrugName_Text.Location = new System.Drawing.Point(149, 10);
            this.DrugName_Text.Name = "DrugName_Text";
            this.DrugName_Text.Size = new System.Drawing.Size(146, 25);
            this.DrugName_Text.TabIndex = 5;
            this.DrugName_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalprice_text
            // 
            this.totalprice_text.BackColor = System.Drawing.Color.DarkGray;
            this.totalprice_text.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalprice_text.Location = new System.Drawing.Point(662, 0);
            this.totalprice_text.Name = "totalprice_text";
            this.totalprice_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalprice_text.Size = new System.Drawing.Size(188, 83);
            this.totalprice_text.TabIndex = 1;
            this.totalprice_text.Text = "الاجمــــــالـى :  0.00";
            this.totalprice_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalprice_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddItem_Btn
            // 
            this.AddItem_Btn.BackColor = System.Drawing.Color.RosyBrown;
            this.AddItem_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddItem_Btn.Location = new System.Drawing.Point(0, 0);
            this.AddItem_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddItem_Btn.Name = "AddItem_Btn";
            this.AddItem_Btn.Size = new System.Drawing.Size(98, 83);
            this.AddItem_Btn.TabIndex = 0;
            this.AddItem_Btn.Text = "إضافة عنصر";
            this.AddItem_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddItem_Btn.UseVisualStyleBackColor = false;
            this.AddItem_Btn.Click += new System.EventHandler(this.AddItem_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(850, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "تاكيد الطلب";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Items_flowLayout
            // 
            this.Items_flowLayout.AutoScroll = true;
            this.Items_flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Items_flowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Items_flowLayout.Location = new System.Drawing.Point(0, 83);
            this.Items_flowLayout.Name = "Items_flowLayout";
            this.Items_flowLayout.Size = new System.Drawing.Size(850, 511);
            this.Items_flowLayout.TabIndex = 4;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Items_flowLayout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderTitle_panal);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(850, 641);
            this.OrderTitle_panal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel OrderTitle_panal;
        private Label totalprice_text;
        private Button AddItem_Btn;
        private Panel panel1;
        private Label label2;
        private TextBox DrugCode_Text;
        private Label label1;
        private TextBox DrugName_Text;
        private Button button1;
        private FlowLayoutPanel Items_flowLayout;
    }
}

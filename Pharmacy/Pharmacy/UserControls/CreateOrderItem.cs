using Pharmacy.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.UserControls
{
    public partial class CreateOrderItem : UserControl
    {
        public CreateOrderItem()
        {
            InitializeComponent();


        }

        public DrugDto GetDrugDto { get; set; }
        
        
        public void addData()
        {
            
            DrugName_Label.Text = GetDrugDto.DrugName;
            price_Label.Text = GetDrugDto.Price.ToString();
            btn.Name = GetDrugDto.DrugCode;
            if (GetDrugDto.numofpices == null)
            {
                type_panal.Visible = false;
                Type_Lable.Visible = true;
            }
            else
            {
                Type_Lable.Visible = false;
                type_panal.Visible = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            CreateOrder.drugsItem.Remove(GetDrugDto);
            CreateOrder.totalprice -= GetDrugDto.Price;
            CreateOrder.ChangeTotalPriceLable();

            MessageBox.Show(CreateOrder.drugsItem.Count.ToString());
            this.Visible = false;
        }
    }
}

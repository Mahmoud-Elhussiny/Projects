using Pharmacy.Dtos;
using Pharmacy.Forms;
using Pharmacy.Model.Entities;
using Pharmacy.Services;
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
    public partial class CreateOrder : UserControl
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static decimal totalprice  = 0;
        public static List<DrugDto> drugsItem = new List<DrugDto>();


     



        public static void ChangeTotalPriceLable()
        {
           //totalprice_text.Text = "الاجمالى :" + (totalprice).ToString();
        }

        private void AddItem_Btn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(DrugCode_Text.Text) && String.IsNullOrEmpty(DrugName_Text.Text))
            {
                MessageBox.Show("ادخل اسم المنتج او كود المنتج");
                return;
            }
            if(!String.IsNullOrEmpty(DrugCode_Text.Text) && !String.IsNullOrEmpty(DrugName_Text.Text))
            {
                MessageBox.Show("يجب ادخل اسم المنتج فقط او كود المنتج قفط");
                DrugCode_Text.Text = "";
                DrugName_Text.Text = "";
                return;
            }
            if (!String.IsNullOrEmpty(DrugCode_Text.Text))
            {
                var result = DrugServices.searchByDrugCode(DrugCode_Text.Text);
                drugsItem.Add(result);
                drugsItem.IndexOf(result);
                
                if(result.status == false)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                CreateOrderItem orderItem = new CreateOrderItem();
                orderItem.GetDrugDto = result;
                orderItem.addData();
                totalprice += result.Price;
                totalprice_text.Text = "الاجمالى :" + (totalprice).ToString();
                Items_flowLayout.Controls.Add(orderItem);


            }
           
        }
    }
}

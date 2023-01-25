using Pharmacy.Dtos;
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
    public partial class CreateDrug : UserControl
    {
        public CreateDrug()
        {
            InitializeComponent();
        }
        public List<CatigoryDto> catigories { get; set; }
        public List<ManufacturerDto> manufacturers { get; set; }
        private void CreateDrug_Load(object sender, EventArgs e)
        {
            catigories = CatigoryServices.GetAllCatigories();
            manufacturers = ManufacturerServices.GetAllManufacturers();
            Catigory_Combo.Items.Clear();
            foreach(var item in catigories)
            {
                Catigory_Combo.Items.Add(item.CatigoryName);
            }

            Manufacturer_Compo.Items.Clear();
            foreach(var item in manufacturers)
            {
                Manufacturer_Compo.Items.Add(item.ManufacturerName);
            }

        }

        private void CreateDrug_Btn_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(DrugName_text.Text))
            {
                MessageBox.Show("يجب إدخال اسم الدواء");
                return;
            }
            if (String.IsNullOrEmpty(DrugCode_Text.Text))
            {
                MessageBox.Show("يجب إدخال كود الدواء");
                return;
            }
            if (String.IsNullOrEmpty(expirDate_Text.Text))
            {
                MessageBox.Show("يجب إدخال تاريخ الانتهاء");
                return;
            }
            
            if (String.IsNullOrEmpty(price_Text.Text))
            {
                MessageBox.Show("يجب إدخال سعر الدواء");
                return;
            }
            if (String.IsNullOrEmpty(Quantity_Text.Text))
            {
                MessageBox.Show("يجب إدخال الكمية ");
                return;
            }

            if(Catigory_Combo.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار الفئة");
                return;
            }

            DrugDto drug = new DrugDto();

            drug.DrugName = DrugName_text.Text;
            drug.DrugCode = DrugCode_Text.Text;
            drug.ExpireDate = expirDate_Text.Value.Date;
            drug.Quantity = int.Parse(Quantity_Text.Text);
            drug.Price = decimal.Parse(price_Text.Text);
            if (string.IsNullOrEmpty(numOfPice_Text.Text))
                drug.numofpices = null;
            else
                drug.numofpices = int.Parse(numOfPice_Text.Text);
            drug.CatigoryId = catigories[Catigory_Combo.SelectedIndex].CatigoryId;
            drug.ManufacturerId = manufacturers[Manufacturer_Compo.SelectedIndex].ManufacturerId;
            MessageBox.Show(DrugServices.CreateDrug(drug));
            this.Visible = false;
        }
    }
}

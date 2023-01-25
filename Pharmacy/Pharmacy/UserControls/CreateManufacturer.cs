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
    public partial class CreateManufacturer : UserControl
    {
        public CreateManufacturer()
        {
            InitializeComponent();
        }

        private void createMznufaturer_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ManufacturerName_Text.Text))
            {
                MessageBox.Show("يجب إدخال اسم الشركة");
            }

            var manufacturer = new ManufacturerDto();

            manufacturer.ManufacturerName = ManufacturerName_Text.Text;
            if (!String.IsNullOrEmpty(Address_text.Text))
            {
                manufacturer.Address = Address_text.Text;
            }
            if (!String.IsNullOrEmpty(Phone1_text.Text))
            {
                manufacturer.PhoneNum1 = Phone1_text.Text;
            }
            if (!String.IsNullOrEmpty(Phone2_Text.Text))
            {
                manufacturer.PhoneNum2 = Phone2_Text.Text;
            }

            MessageBox.Show(ManufacturerServices.CreateManufacturer(manufacturer));
            this.Visible = false;
        }
    }
}

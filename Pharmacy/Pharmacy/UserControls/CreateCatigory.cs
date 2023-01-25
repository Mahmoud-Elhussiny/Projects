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
    public partial class CreateCatigory : UserControl
    {
        public CreateCatigory()
        {
            InitializeComponent();
        }

        private void CreateCatigory_Btn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Description_Text.Text))
               MessageBox.Show(CatigoryServices.CreateCatigory(CatigoryName_Text.Text));
            else
                MessageBox.Show(CatigoryServices.CreateCatigory(CatigoryName_Text.Text,Description_Text.Text));
            
            this.Visible = false;
            
        }
    }
}

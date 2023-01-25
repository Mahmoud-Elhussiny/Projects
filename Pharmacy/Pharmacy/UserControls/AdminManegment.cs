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
    public partial class AdminManegment : UserControl
    {
        public AdminManegment()
        {
            InitializeComponent();
        }

        private void AddUser_Btn_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Dock = DockStyle.Fill;
            Admin_panel.Controls.Clear();
            Admin_panel.Controls.Add(createUser);
        }

        private void Catigory_Btn_Click(object sender, EventArgs e)
        {
            CreateCatigory createCatigory = new CreateCatigory();
            createCatigory.Dock = DockStyle.Fill;
            createCatigory.Visible = true;
            Admin_panel.Controls.Clear();
            Admin_panel.Controls.Add(createCatigory);
        }

        private void AddDrug_Btn_Click(object sender, EventArgs e)
        {
            CreateDrug createDrug = new CreateDrug();
            createDrug.Dock = DockStyle.Fill;
            createDrug.Visible = true;
            Admin_panel.Controls.Clear();
            Admin_panel.Controls.Add(createDrug);
        }

        private void AddManufacturer_Btn_Click(object sender, EventArgs e)
        {
            CreateManufacturer manufacturer = new CreateManufacturer();
            manufacturer.Dock = DockStyle.Fill;
            manufacturer.Visible = true;
            Admin_panel.Controls.Clear();
            Admin_panel.Controls.Add(manufacturer);
        }
    }
}

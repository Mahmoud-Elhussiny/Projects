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

namespace Pharmacy.Forms
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            UserServices userServices = new UserServices();
            if(userServices.Loginservice(username.Text, password.Text))
            {
                loginpanel.Visible = false;
                Homepanel.Visible = true;
            }
            else
            {
                MessageBox.Show("un correct username or password");
            }

        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            
            Homepanel.Visible=false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

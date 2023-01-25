using Pharmacy.Forms;
using Pharmacy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.UserControls
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            
            AccountType_combo.Visible = false;
            add_item_to_compo();

        }

        public void add_item_to_compo()
        {
            var accounts = UserServices.GetAllAccounts();
            foreach(var item in accounts)
            {
                AccountType_combo.Items.Add(item.AccountName);
            }
        }

       

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            var user = UserServices.Loginservice(userName_text.Text, Password_text.Text);
            if (AccountType_combo.Visible == false)
            {
                if (user.result)
                {
                    if(user.typeAccount.Count>1) 
                        AccountType_combo.Visible = true;
                    else
                    {
                        if (user.typeAccount.Contains(1))
                        {
                            addadminpanal();
                        }
                        else
                        {
                            adduserpanel();
                        }
                    }



                }
                else
                {
                    MessageBox.Show("UserName Or Password is not coorrect");
                    userName_text.Text = "";
                    Password_text.Text = "";
                    userName_text.Focus();
                }
            }
            else
            {
                
                if (AccountType_combo.SelectedIndex == 0)
                {
                    addadminpanal();
                }
                else
                {
                    adduserpanel();
                }
            }
        }


        private void addadminpanal()
        {
            AdminManegment adminManegment = new AdminManegment();
            adminManegment.Dock = DockStyle.Fill;
            ManegmentForm.instance.login_.Visible = false;
            ManegmentForm.instance.Controls.Add(adminManegment);
        }

        private void adduserpanel()
        {
            UserManegment userManegment = new UserManegment();
            userManegment.Dock = DockStyle.Fill;
            ManegmentForm.instance.login_.Visible = false;
            ManegmentForm.instance.Controls.Add(userManegment);
        }

    }
}

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
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void createUser_Btn_Click(object sender, EventArgs e)
        {
            var newuser = new UserDto();
            newuser.FirstName = FirstName_text.Text;
            newuser.LastName = LastName_text.Text;
            newuser.UserName = UserName_Text.Text;
            newuser.Password = Password_text.Text;
            newuser.Address = Address_text.Text;
            newuser.PhoneNum1 = Phone1_text.Text;
            newuser.PhoneNum2 = Phone2_text.Text;

            if(String.IsNullOrEmpty(FirstName_text.Text)|| String.IsNullOrEmpty(LastName_text.Text))
            {
                MessageBox.Show("يجب ادخال الاسم الاول والاسم الاخير للمستخدم");
                return;
            }


            if(!(userType_Check.Checked || adminType_Check.Checked))
            {
                MessageBox.Show("يجب تحديد نوع حساب المستخدم");
                return;
            }

            if (String.IsNullOrEmpty(UserName_Text.Text) || String.IsNullOrEmpty(Password_text.Text))
            {
                MessageBox.Show("يجب ادخال اسم المسخدم وكلمة المرور");
                return;
            }

            if (userType_Check.Checked)
            {
                newuser.IsUser = true;
            }

            if (adminType_Check.Checked)
            {
                newuser.IsAdmin = true;
            }
            
            MessageBox.Show(UserServices.CreateUserservice(newuser));

            this.Visible = false;
            return;
        }
    }
}

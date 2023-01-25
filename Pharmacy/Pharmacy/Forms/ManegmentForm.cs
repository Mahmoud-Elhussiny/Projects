using Pharmacy.UserControls;
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
    public partial class ManegmentForm : Form
    {
        public ManegmentForm()
        {
            InitializeComponent();
        }

        static ManegmentForm opj_;

        public static ManegmentForm instance {
            get
            {
                if(opj_== null)
                    opj_ = new ManegmentForm();
                return opj_;
            }
             
        }

        public LoginControl login_;

        private void ManegmentForm_Load(object sender, EventArgs e)
        {
            opj_ = this;
            login_ = new LoginControl();
            login_.Dock = DockStyle.Fill;
           
            opj_.Controls.Add(login_);
        }


        
    }
}

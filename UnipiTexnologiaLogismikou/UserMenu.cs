using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipiTexnologiaLogismikou
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void emailbutton_Click(object sender, EventArgs e)
        {
            EmailForm emailform = new EmailForm();
            //h deyterh forma emfanizetai,tis exv syndesh mesw tou this.h deyterh forma exei owner thn prwth
            emailform.Show(this);
            //twra h prwth form kryvetai
            this.Hide();
        }
    }
}

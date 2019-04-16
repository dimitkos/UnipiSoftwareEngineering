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
    public partial class ProgressForm : Form
    {

        ProgressInfo grd = new ProgressInfo();
        ProgressInfoDal grddal = new ProgressInfoDal();

        public ProgressForm()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show(this);
            this.Hide();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = ProgressInfoDal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}

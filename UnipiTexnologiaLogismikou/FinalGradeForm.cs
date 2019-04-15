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
    public partial class FinalGradeForm : Form
    {
        GradesInfo grd = new GradesInfo();
        GradeInfoDal grddal = new GradeInfoDal();

        public FinalGradeForm()
        {
            InitializeComponent();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = grddal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}

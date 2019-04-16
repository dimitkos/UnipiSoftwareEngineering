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
    public partial class ForumForm : Form
    {
        public ForumForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu Form1 = new UserMenu();
            Form1.Show(this);
            this.Hide();
        }

        private void ForumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ForumForm_Load(object sender, EventArgs e)
        {

        }
    }
}

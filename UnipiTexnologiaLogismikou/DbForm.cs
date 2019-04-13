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
    public partial class DbForm : Form
    {
        public DbForm()
        {
            InitializeComponent();
        }

        StudentInfo std = new StudentInfo();
        studentinfodal stddal = new studentinfodal();

        private void button1_Click(object sender, EventArgs e)
        {
            std.id = amtxt.Text;
            std.namesurname = nametxt.Text;
            std.thesis = thesistxt.Text;
            std.startdate = DateTime.Now;
            std.languages = languagestxt.Text;
            std.framework = frameworktxt.Text;

            bool success = stddal.Insert(std);
            if (success == true)
            {
                //Data successfully Inserted
                MessageBox.Show("Data added successfully");
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add data");
            }
        }
    }
}

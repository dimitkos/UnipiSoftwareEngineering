﻿using System;
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

        private void addbutton_Click(object sender, EventArgs e)
        {
            grd.id = idtextBox.Text;
            grd.grades = gradetextBox.Text;


            bool success = grddal.Insert(grd);
            if (success == true)
            {
                //Data successfully Inserted
                MessageBox.Show("Data added successfully");
                //clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add data");
            }
        }
    }
}

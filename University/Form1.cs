using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Department department;
        private void btnSaveDept_Click(object sender, EventArgs e)
        {
            department = new Department(txtCodeDept.Text, txtNameDept.Text);
            MessageBox.Show("Department Added");
        }

        private void btnSaveStd_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtEmailStd.Text, txtNameStd.Text, txtRegnoStd.Text);
            bool isStudentAdded = department.AddStudent(student);

            if (isStudentAdded)
            {
                MessageBox.Show("Student Added");
            }
        }

        private void btnShoDetails_Click(object sender, EventArgs e)
        {
            string detailsInfo = department.GetDetails();
            MessageBox.Show(detailsInfo);
        }
    }
}

using ADO_NET_PROJECT.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_PROJECT
{
    public partial class Form4 : Form
    {

        EmployeeLogic emp;

        public Form4()
        {
            InitializeComponent();
            emp = new EmployeeLogic();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = emp.getEmpDetails().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {


            float salary = float.Parse(tbsalary.Text.ToString());

            dataGridView1.DataSource = emp.getEmpDataBySalary(salary).Tables[0];

            tbsalary.Text = "";





        }
    }
}

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
    public partial class Form3 : Form
    {
        EmployeeLogic emp;

        public Form3()
        {
            InitializeComponent();
            emp = new EmployeeLogic();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = emp.getEmpDetails().Tables[0];


        }

        private void btndata_Click(object sender, EventArgs e)
        {

            string name = tbename.Text.ToString();

            dataGridView1.DataSource = emp.getEmpDataByName(name).Tables[0];

            
            
            tbename.Text = "";

        }
    }
}

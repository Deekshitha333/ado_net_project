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
    public partial class Form2 : Form
    {
        EmployeeLogic emp;
        public Form2()
        {
            InitializeComponent();
            emp = new EmployeeLogic();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;


            dataGridView1.DataSource = emp.getEmpDetails().Tables[0];


        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            Employee e1 = new Employee();

            e1.EmpId = Convert.ToInt32(tbid.Text);
            e1.EmpName = tbname.Text.ToString();
            e1.Dob = Convert.ToDateTime(tbdob.Text);
            e1.Phone = tbphone.Text.ToString();
            e1.Mail = tbmail.Text.ToString();
            e1.Salary = float.Parse(tbsal.Text);
            e1.DeptId = Convert.ToInt32(tbdid.Text);
        


            string msg = emp.insertEmp(e1);


            MessageBox.Show(msg);

            dataGridView1.DataSource = emp.getEmpDetails().Tables[0];


            tbid.Text = "";
            tbname.Text = "";
            tbdob.Text = "";
            tbphone.Text = "";
            tbmail.Text = "";
            tbsal.Text = "";
            tbdid.Text = "";



        }
    }
}

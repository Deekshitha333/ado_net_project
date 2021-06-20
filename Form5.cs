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
    public partial class Form5 : Form
    {
        EmployeeLogic emp;

        public Form5()
        {
            InitializeComponent();
            emp = new EmployeeLogic();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            tbname.Visible = false;
            tbdob.Visible = false;
            tbphone.Visible = false;
            tbmail.Visible = false;
            tbsal.Visible = false;
            tbdid.Visible = false;
            btnupdate.Visible = false;


        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            string iid = tbid.Text.ToString();
            
            if (iid !="")
            { 
                int id = Convert.ToInt32(tbid.Text);

                Employee e2 = emp.findDataById(id);

                if (e2 != null)
                {
                    List<Employee> li = new List<Employee>();
                    li.Add(e2);

                    MessageBox.Show("record found");

                    dataGridView1.DataSource = li;
                    dataGridView1.Visible = true;
                    label1.Visible = false;
                    tbid.Visible = false;
                    btncheck.Visible = false;

                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;

                    tbname.Visible = true;
                    tbdob.Visible = true;
                    tbphone.Visible = true;
                    tbmail.Visible = true;
                    tbsal.Visible = true;
                    tbdid.Visible = true;
                    btnupdate.Visible = true;



                }
                else
                {
                    MessageBox.Show("data not found");
                    tbid.Text = "";
                }
            }
            else
            {
                MessageBox.Show("enter empid");
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            Employee e1 = new Employee();

            e1.EmpId = Convert.ToInt32(tbid.Text);
            e1.EmpName = tbname.Text.ToString();
            e1.Dob = Convert.ToDateTime(tbdob.Text);
            e1.Phone = tbphone.Text.ToString();
            e1.Mail = tbmail.Text.ToString();
            e1.Salary = float.Parse(tbsal.Text);
            e1.DeptId = Convert.ToInt32(tbdid.Text);

            string msg = emp.updateRecord(e1);

            MessageBox.Show(msg);

            Employee e3 = emp.findDataById(e1.EmpId);

            List<Employee> list = new List<Employee>();
            list.Add(e3);

            dataGridView1.DataSource = list;

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

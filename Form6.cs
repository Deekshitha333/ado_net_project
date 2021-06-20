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
    public partial class Form6 : Form
    {
        EmployeeLogic emp;
        public Form6()
        {
            InitializeComponent();
            emp = new EmployeeLogic();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;

            btndelete.Visible = false;


        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            string iid = tbid.Text.ToString();

            if (iid != "")
            {

                int id = Convert.ToInt32(tbid.Text);

                Employee e2 = emp.findDataById(id);

                if (e2 != null)
                {
                    List<Employee> li = new List<Employee>();
                    li.Add(e2);

                    MessageBox.Show("record found");

                    dataGridView1.DataSource = li;

                    btndelete.Visible = true;

                    btncheck.Visible = false;

                   // dataGridView1.DataSource = emp.findDataById(id);
                    dataGridView1.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("record not found");
                    tbid.Text = "";
                }

            }
            else
            {
                MessageBox.Show("enter emp id");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(tbid.Text);

            string msg = emp.deleteRecordById(id);

            MessageBox.Show(msg);


            dataGridView1.DataSource = emp.getEmpDetails().Tables[0];


            tbid.Text = "";


        }
    }
}

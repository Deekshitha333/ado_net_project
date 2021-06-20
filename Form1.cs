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
    public partial class Form1 : Form
    {
        DeptLogic db;

        public Form1()
        {
            InitializeComponent();
            db = new DeptLogic();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;


            dataGridView1.DataSource = db.getDeptDetails().Tables[0];


        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            Dept dpt = new Dept();

            dpt.DeptId = Convert.ToInt32(tbid.Text);
            dpt.DeptName = tbname.Text.ToString();
            dpt.DeptLoc = tbloc.Text.ToString();
            dpt.MgrId = Convert.ToInt32(tbmgr.Text);

            string msg = db.insertData(dpt);

            MessageBox.Show(msg);

            dataGridView1.DataSource = db.getDeptDetails().Tables[0];

            tbid.Text = "";
            tbname.Text = "";
            tbloc.Text = "";
            tbmgr.Text = "";

        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }*/
    }
}

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
    public partial class Form7 : Form
    {
        JoinsLogic join;

        public Form7()
        {
            InitializeComponent();
            join = new JoinsLogic();

        }


        private void Form7_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = join.getCommonDetails();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

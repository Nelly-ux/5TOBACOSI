using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {

        static operaciones op = new operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtv1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdres_Click(object sender, EventArgs e)
        {
            lblres.Text = (op.IMC(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();



        }
    }
}

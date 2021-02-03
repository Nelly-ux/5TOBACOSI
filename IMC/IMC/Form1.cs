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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbltipo_Click(object sender, EventArgs e)
        {
            if (double.Parse(lblres.Text) < 18)
            {
                MessageBox.Show("BAJO PESO");
            }
            else if (double.Parse(lblres.Text) < 25)
            {
                MessageBox.Show("PESO NORMAL");
            }
            else if (double.Parse(lblres.Text) < 30)
            {
                MessageBox.Show("SOBRE PESO");
            }
            else
            {
                MessageBox.Show("OBESIDAD");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_11_ao_13
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        private void Frm3_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frm1 = new frmprincipal();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f, c, r ;
            int i;
          
            c = Convert.ToDouble(txtc.Text);

            f = (c * 1.8) + 32;
            for (i = 10; i <= 100; i = i + 10)
            {
                r = i + f;
                txtR.Text = String.Concat(txtR.Text + "\n \r" + r.ToString());
               
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtR.Clear();
            txtc.Focus();
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            double f, c, r;
           int i;


            i = 1;
            do
            {
                c = Convert.ToDouble(txtc.Text);
                f = (c * 1.8) + 32;
                r = i + f;
                txtR.Text = String.Concat(txtR.Text + "\n \r" + r.ToString());
                i = i+10;
            } while (i <= 100);
        }

        private void btnen_Click(object sender, EventArgs e)
        {
            double f, c, r;
            int i;

            c = Convert.ToDouble(txtc.Text);
            i = 1;

            while (i <= 100)
            {
                f = (c * 1.8) + 32;
                r = i + f;
                txtR.Text = String.Concat(txtR.Text + "\n \r" + r.ToString());
                i = i + 10;
            }

        }
    }
}


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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double num, i, r;

            for (i = 1; i <= 10; i++)
            {
                num = Convert.ToDouble(txtnum.Text);
                r = num * i;
                txtresultado.Text = String.Concat(txtresultado.Text + "\n \r" + r.ToString()) ;
            }


        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double num, i, r;
            num = Convert.ToDouble(txtnum.Text);
            i = 1;
            while (i <= 10)
            {
                r = num * i;
                txtresultado.Text = String.Concat(txtresultado.Text + "\n \r" + r.ToString());
                i++;
            }
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double num, i, r;
            i = 1;
            do
            {
                num = Convert.ToDouble(txtnum.Text);
                r = num * i;
                txtresultado.Text = String.Concat(txtresultado.Text + "\n \r" + r.ToString());
                i++;
            } while (i <= 10);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresultado.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
              this.Hide();
            frmprincipal frm1 = new frmprincipal();
            frm1.Show();
        }
    }
}

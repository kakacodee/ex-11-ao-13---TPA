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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }
        double areatotal;

        private void btnen_Click(object sender, EventArgs e)
        {
            double area, c, l;

            c = Convert.ToDouble(txtcomprimento.Text);
            l = Convert.ToDouble(txtlarg.Text);

            area = c * l;
            areatotal += area;
            txtresultado.Text = area.ToString();
            var resultado = MessageBox.Show("Gostaria de adicionar mais um cômodo para o cálculo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                txtcom.Clear();
                txtcomprimento.Clear();
                txtlarg.Clear();
                txtresultado.Clear();
                txtcom.Focus();
            }
            else
            {
                lblarea.Visible = true;
                txtat.Visible = true;
                txtat.Text = areatotal.ToString();

                
            }
        }
    }
}

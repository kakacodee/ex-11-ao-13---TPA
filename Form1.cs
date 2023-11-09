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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabuadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2 tabuada = new frm2();
            tabuada.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm3 CºparaFº = new Frm3();
            CºparaFº.Show();
        }

        private void areaDaCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4 AreadaCasa = new frm4();
            AreadaCasa.Show();
        }
    }
}

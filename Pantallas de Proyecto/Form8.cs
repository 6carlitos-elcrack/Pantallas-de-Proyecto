using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_de_Proyecto
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void rbnLegalCliente_CheckedChanged(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();

        }

        private void rbnLegalAval_CheckedChanged(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();
        }

        private void rbnEmbargo_CheckedChanged(object sender, EventArgs e)
        {
            
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }
    }
}

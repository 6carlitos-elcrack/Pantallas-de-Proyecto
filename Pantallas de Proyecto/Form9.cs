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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Hide();
        }
    }
}

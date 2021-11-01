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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Close();
        }

        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();

        }
    }
}

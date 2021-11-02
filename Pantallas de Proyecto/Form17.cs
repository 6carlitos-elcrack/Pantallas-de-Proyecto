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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            frm18.Show();
            this.Close();
        }
    }
}

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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaGestion_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            frmMenu frm2 = new frmMenu();
            frm2.Show();
            this.Hide();

        }

        private void btnSeguroYSeguimientos_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
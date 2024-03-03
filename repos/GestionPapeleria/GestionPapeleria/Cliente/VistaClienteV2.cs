using GestionPapeleria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPapeleria.Cliente
{
    public partial class VistaClienteV2 : Form

    {
        public static ClienteAplicacion clienteLogueado;

        public VistaClienteV2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_cliente_v2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void lbl_altaProducto_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bn_login_v2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}

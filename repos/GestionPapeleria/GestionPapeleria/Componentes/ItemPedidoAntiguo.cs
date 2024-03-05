using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPapeleria.Componentes
{

    public partial class ItemPedidoAntiguo : UserControl
    {

        public int id_pedido;
        public ItemPedidoAntiguo(int id)
        {
            id_pedido = id;
            InitializeComponent();

        }
        private void volveraPedir(object sender, EventArgs e)
        {
            int id_cliente = Login.clienteLogueado.id_cliente;

            DialogResult dialogResult = MessageBox.Show("¿Quieres pedir de nuevo el pedido "+id_pedido +" ?", "Confirmar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               
                try
                {

                SqlConnection con = new SqlConnection(Form1.connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("PedirDeNuevo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@id_pedido", id_pedido);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pedido realizado, se enviará en las próximas 48 horas", "Pedido confirmado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
           
        }

    }
}

using GestionPapeleria.Clases;
using GestionPapeleria.Componentes;
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

namespace GestionPapeleria.Cliente
{
    public partial class VistaCarrito : Form
    {
        public int id_pedido = Carrito.ObtenerIdCarritoCliente(Login.clienteLogueado.id_cliente);
        public VistaCarrito()
        {
            InitializeComponent();
        }

        public void llenarVistaCarrito()
        {
            float total = 0;

            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                con.Open();

                SqlCommand cmd = new SqlCommand("pedidosTicket", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_cliente ", Login.clienteLogueado.id_cliente));
                cmd.Parameters.Add(new SqlParameter("@id_pedido ", id_pedido));
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    int id_articulo = Convert.ToInt32(row["id_articulo"]);
                    ItemCarrito item = new ItemCarrito(id_pedido, id_articulo, this);

                    item.Size = new Size(280, 95);
                    item.lbl_cantidad.Text = row["cantidad"].ToString();
                    item.lbl_nombre_producto.Text = row["nombre"].ToString();
                    item.lbl_precio.Text = float.Parse(row["precio"].ToString()).ToString("0.00") + " $";

                    total += Convert.ToSingle(row["cantidad"]) * Convert.ToSingle(row["precio"]);

                    lbl_total.Text = total.ToString("0.00") + " $";
                    flp_carrito.Controls.Add(item);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            try
            {
                Carrito.RealizarPedido(id_pedido);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        private void close_carrito_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

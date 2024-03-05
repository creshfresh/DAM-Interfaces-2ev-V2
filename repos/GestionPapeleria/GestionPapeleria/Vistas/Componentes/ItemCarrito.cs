using GestionPapeleria.Clases;
using GestionPapeleria.Cliente;
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
    public partial class ItemCarrito : UserControl
    {

        public int id_pedido;
        public int id_producto;
        public static VistaCarrito vista;
        public ItemCarrito(int idped, int idProd, VistaCarrito vc)
        {
            id_pedido = idped;
            id_producto = idProd;
            vista = vc;
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Carrito.borrarArticulo(id_producto, id_pedido);
            vista.Close();

        }

        public static void reducirCantidadLineaPedido(int id_pedido, int id_articulo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    con.Open();

                    // Reducir la cantidad de la línea de pedido
                    string updateQuery = "UPDATE lineaPedido SET cantidad = cantidad - 1 WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@idPedido", id_pedido);
                        cmdUpdate.Parameters.AddWithValue("@idArticulo", id_articulo);
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Verificar si la cantidad se ha reducido a 0
                            string checkCantidadQuery = "SELECT cantidad FROM lineaPedido WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";
                            using (SqlCommand cmdCheckCantidad = new SqlCommand(checkCantidadQuery, con))
                            {
                                cmdCheckCantidad.Parameters.AddWithValue("@idPedido", id_pedido);
                                cmdCheckCantidad.Parameters.AddWithValue("@idArticulo", id_articulo);
                                int cantidad = Convert.ToInt32(cmdCheckCantidad.ExecuteScalar());

                                if (cantidad == 0)
                                {
                                    // Eliminar la línea de pedido si la cantidad es 0
                                    string deleteLineaPedidoQuery = "DELETE FROM lineaPedido WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";
                                    using (SqlCommand cmdDeleteLineaPedido = new SqlCommand(deleteLineaPedidoQuery, con))
                                    {
                                        cmdDeleteLineaPedido.Parameters.AddWithValue("@idPedido", id_pedido);
                                        cmdDeleteLineaPedido.Parameters.AddWithValue("@idArticulo", id_articulo);
                                        cmdDeleteLineaPedido.ExecuteNonQuery();

                                        // Verificar si quedan más líneas de pedido asociadas al pedido
                                        string countLineasPedidoQuery = "SELECT COUNT(*) FROM lineaPedido WHERE id_pedido = @idPedido";
                                        using (SqlCommand cmdCountLineasPedido = new SqlCommand(countLineasPedidoQuery, con))
                                        {
                                            cmdCountLineasPedido.Parameters.AddWithValue("@idPedido", id_pedido);
                                            int countLineasPedido = Convert.ToInt32(cmdCountLineasPedido.ExecuteScalar());

                                            if (countLineasPedido == 0)
                                            {
                                                // Eliminar el pedido si no quedan más líneas de pedido asociadas
                                                string deletePedidoQuery = "DELETE FROM pedidos WHERE id_pedido = @idPedido";
                                                using (SqlCommand cmdDeletePedido = new SqlCommand(deletePedidoQuery, con))
                                                {
                                                    cmdDeletePedido.Parameters.AddWithValue("@idPedido", id_pedido);
                                                    cmdDeletePedido.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Cantidad reducida.", "Éxito");
                    vista.Refresh();
                    vista.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reducir la cantidad de la línea de pedido: " + ex.Message, "Error");
            }
        }
        public static void aumentarCantidadLineaPedido(int id_pedido, int id_articulo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    con.Open();

                    // Aumentar la cantidad de la línea de pedido
                    string updateQuery = "UPDATE lineaPedido SET cantidad = cantidad + 1 WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@idPedido", id_pedido);
                        cmdUpdate.Parameters.AddWithValue("@idArticulo", id_articulo);
                        cmdUpdate.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
                MessageBox.Show("Cantidad reducida.", "Éxito");

                vista.Refresh();
                vista.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aumentar la cantidad de la línea de pedido: " + ex.Message, "Error");
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            reducirCantidadLineaPedido(id_pedido, id_producto);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            aumentarCantidadLineaPedido(id_pedido, id_producto);
        }
    }
}

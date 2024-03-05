using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Clases
{
    public class Carrito
    {

        //Metodo cargar Cesta

        public static void AddArticulo(int idArticulo,int idCliente, float importeArticulo)
        {
          int idCarrito = ObtenerIdCarritoCliente(idCliente);
          //comprobar si el cliente tiene ya un carrito creado,de no ser asi le creamos uno
          if (idCarrito == -1) {
                //crear pedido y obtener su id
                idCarrito = InsertarPedido(idCliente, DateTime.Now, importeArticulo);
                AddLineaPedido(idCarrito, idArticulo);
          }
          else
          {
                //el carrito ya existe , añadir el articulo
                AddLineaPedido(idCarrito, idArticulo);
            }

        }

        private static void AddLineaPedido(int idPedido, int idArticulo)
        {
            try
            {
                string sqlQueryCheck = "SELECT COUNT(*) FROM lineaPedido WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";
                string sqlQueryInsert = "INSERT INTO lineaPedido (id_pedido, id_articulo, cantidad) VALUES (@idPedido, @idArticulo, 1)";
                string sqlQueryUpdate = "UPDATE lineaPedido SET cantidad = cantidad + 1 WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";
                string sqlQueryUpdateImporte = "UPDATE pedidos SET importe = (SELECT SUM(lp.cantidad * a.precio) FROM lineaPedido lp INNER JOIN articulos a ON lp.id_articulo = a.id_articulo WHERE lp.id_pedido = @idPedido) WHERE id_pedido = @idPedido";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    con.Open();

                    // Comprobar si el artículo ya existe para ese pedido
                    using (SqlCommand cmdCheck = new SqlCommand(sqlQueryCheck, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@idPedido", idPedido);
                        cmdCheck.Parameters.AddWithValue("@idArticulo", idArticulo);
                        int count = (int)cmdCheck.ExecuteScalar();

                        // Si el artículo ya existe, actualizar la cantidad
                        if (count > 0)
                        {
                            using (SqlCommand cmdUpdate = new SqlCommand(sqlQueryUpdate, con))
                            {
                                cmdUpdate.Parameters.AddWithValue("@idPedido", idPedido);
                                cmdUpdate.Parameters.AddWithValue("@idArticulo", idArticulo);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        // De lo contrario, insertar un nuevo registro
                        else
                        {
                            using (SqlCommand cmdInsert = new SqlCommand(sqlQueryInsert, con))
                            {
                                cmdInsert.Parameters.AddWithValue("@idPedido", idPedido);
                                cmdInsert.Parameters.AddWithValue("@idArticulo", idArticulo);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                    // Actualizar el importe total del pedido
                    using (SqlCommand cmdUpdateImporte = new SqlCommand(sqlQueryUpdateImporte, con))
                    {
                        cmdUpdateImporte.Parameters.AddWithValue("@idPedido", idPedido);
                        cmdUpdateImporte.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar detalle de pedido: " + ex.Message, "Error");
            }
        }

        private static int InsertarPedido(int idCliente, DateTime fechaPedido, float importe)
        {
            try
            {
                string estado = "carrito"; 
                int idPedido = -1; // ID predeterminado

                string sqlQuery = "INSERT INTO pedidos (id_cliente, fecha_pedido, importe, estado) OUTPUT INSERTED.id_pedido VALUES (@idCliente, @fechaPedido, @importe, @estado)";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@fechaPedido", fechaPedido);
                        cmd.Parameters.AddWithValue("@importe", importe);
                        cmd.Parameters.AddWithValue("@estado", estado); // Establecer el estado como "CARRITO"

                        con.Open();

                        // Ejecutar la consulta de inserción y obtener el ID del pedido insertado
                        idPedido = (int)cmd.ExecuteScalar();
                    }
                }

                return idPedido; // Devolver el ID del pedido insertado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar pedido: " + ex.Message, "Error");
                return -1; // Devolver -1 si la inserción falló
            }
        }

        public static int ObtenerIdCarritoCliente(int idCliente)
        {
            int idPedido = -1; // Valor predeterminado si no se encuentra un carrito para el cliente

            try
            {
                //
                string sqlQuery = "SELECT id_pedido FROM pedidos WHERE id_cliente = @idCliente AND estado = 'CARRITO'";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);

                        con.Open();

                        // Ejecutar la consulta y obtener el resultado (id del pedido)
                        object result = cmd.ExecuteScalar();

                        // Comprobar si se encontró un pedido para el cliente
                        if (result != null && result != DBNull.Value)
                        {
                            idPedido = Convert.ToInt32(result); // Convertir el resultado a un entero
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

            return idPedido;
        }
        //comprobar si el cliente tiene ya un carrito creado

        public static void RealizarPedido(int idPedido)
        {
            try
            {
                string sqlQuery = "UPDATE pedidos SET estado = 'pagado' WHERE id_pedido = @idPedido";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);

                        con.Open();
                        cmd.ExecuteNonQuery(); // Ejecutar la consulta de actualización
                    }
                }

                MessageBox.Show("Pedido realizado con éxito.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el pedido: " + ex.Message, "Error");
            }
        }

        public void borrarPedido(int idPedido)
        {
            try
            {
                string sqlQuery = "DELETE FROM pedidos WHERE id_pedido = @idPedido";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);

                        con.Open();
                        cmd.ExecuteNonQuery(); // Ejecutar la consulta de eliminación
                    }
                }

                MessageBox.Show("Pedido borrado con éxito.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el pedido: " + ex.Message, "Error");
            }
        }


        public static void borrarArticulo(int id_Articulo, int id_pedido)
        {
            try
            {
                // Eliminar la línea de pedido con el id_Articulo
                string deleteLineaPedidoQuery = "DELETE FROM lineaPedido WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmdDeleteLineaPedido = new SqlCommand(deleteLineaPedidoQuery, con))
                    {
                        cmdDeleteLineaPedido.Parameters.AddWithValue("@idPedido", id_pedido);
                        cmdDeleteLineaPedido.Parameters.AddWithValue("@idArticulo", id_Articulo);
                        con.Open();
                        int rowsAffected = cmdDeleteLineaPedido.ExecuteNonQuery(); // Ejecutar la consulta de eliminación de la línea de pedido

                        if (rowsAffected > 0)
                        {
                            // Si se eliminó la línea de pedido, comprobar si quedan más artículos en el pedido
                            string countArticulosQuery = "SELECT COUNT(*) FROM lineaPedido WHERE id_pedido = @idPedido";

                            int countArticulos = 0;

                            using (SqlCommand cmdCountArticulos = new SqlCommand(countArticulosQuery, con))
                            {
                                cmdCountArticulos.Parameters.AddWithValue("@idPedido", id_pedido);
                                countArticulos = (int)cmdCountArticulos.ExecuteScalar(); // Obtener el número de artículos en el pedido
                            }

                            // Si no quedan más artículos en el pedido, borrar el pedido
                            if (countArticulos == 0)
                            {
                                string deletePedidoQuery = "DELETE FROM pedidos WHERE id_pedido = @idPedido";

                                using (SqlCommand cmdDeletePedido = new SqlCommand(deletePedidoQuery, con))
                                {
                                    cmdDeletePedido.Parameters.AddWithValue("@idPedido", id_pedido);
                                    cmdDeletePedido.ExecuteNonQuery(); // Ejecutar la consulta de eliminación del pedido
                                }

                                MessageBox.Show("Pedido y línea de pedido borrados.", "Éxito");
                            }
                            else
                            {
                                MessageBox.Show("Línea de pedido borrada.", "Éxito");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la línea de pedido para el artículo especificado.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la línea de pedido o el pedido: " + ex.Message, "Error");
            }
        }


        public void modificarCantidad(int idPedido, int idArticulo, int nuevaCantidad, float precioArticulo)
        {
            try
            {
                // Paso 1: Actualizar la cantidad del artículo en la tabla lineaPedido
                string sqlQueryUpdateCantidad = "UPDATE lineaPedido SET cantidad = @nuevaCantidad WHERE id_pedido = @idPedido AND id_articulo = @idArticulo";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmdUpdateCantidad = new SqlCommand(sqlQueryUpdateCantidad, con))
                    {
                        cmdUpdateCantidad.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                        cmdUpdateCantidad.Parameters.AddWithValue("@idPedido", idPedido);
                        cmdUpdateCantidad.Parameters.AddWithValue("@idArticulo", idArticulo);

                        con.Open();
                        cmdUpdateCantidad.ExecuteNonQuery(); // Ejecutar la consulta de actualización de cantidad
                    }
                }

                // Paso 2: Recalcular el precio total del pedido y actualizarlo en la tabla pedidos
                string sqlQueryUpdatePrecioTotal = "UPDATE pedidos SET importe = (SELECT SUM(d.cantidad * a.precio) FROM detalles_pedido d INNER JOIN articulos a ON d.id_articulo = a.id_articulo WHERE d.id_pedido = @idPedido) WHERE id_pedido = @idPedido";

                using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                {
                    using (SqlCommand cmdUpdatePrecioTotal = new SqlCommand(sqlQueryUpdatePrecioTotal, con))
                    {
                        cmdUpdatePrecioTotal.Parameters.AddWithValue("@idPedido", idPedido);

                        con.Open();
                        cmdUpdatePrecioTotal.ExecuteNonQuery(); // Ejecutar la consulta de actualización de precio total
                    }
                }

                MessageBox.Show("Cantidad modificada con éxito.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la cantidad del artículo: " + ex.Message, "Error");
            }
        }
    }
}

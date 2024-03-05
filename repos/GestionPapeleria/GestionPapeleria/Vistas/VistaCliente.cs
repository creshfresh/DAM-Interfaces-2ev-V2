using GestionPapeleria.Clases; // Importa las clases necesarias
using GestionPapeleria.Componentes; // Importa los componentes necesarios
using Microsoft.Data.SqlClient; // Importa el proveedor de datos SQL
using System;
using System.Data; // Importa los tipos de datos de DataTable y CommandType
using System.Drawing;
using System.Windows.Forms;

namespace GestionPapeleria.Cliente
{
    // Definición de la clase VistaCliente
    public partial class VistaCliente : Form
    {
        // Constructor de la clase
        public VistaCliente()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            PopulateItemsArticulos(); // Llama al método para poblar los artículos
        }

        // Método para comprobar si hay un cliente logueado
        public static void comprobarHayCliente()
        {
            // Verifica si hay un cliente logueado y muestra u oculta paneles en consecuencia
            if (Login.clienteLogueado != null)
            {
                pnl_sinlogin.Visible = false;
                pnl_anitguosped.Visible = true;
            }
        }

        // Método para poblar los items de artículos
        public static void PopulateItemsArticulos()
        {
            // Consulta SQL para obtener información de los artículos
            string sqlQuery = "Select a.id_articulo,a.nombre,a.id_categoria, c.nombre as nombre_categoria, a.marca, a.precio, a.stock , a.id_proveedor , a.id_almacen from articulos a, categorias c where a.id_categoria = c.id_categoria";

            try
            {
                // Establece la conexión con la base de datos
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Itera sobre las filas del DataTable para crear y agregar objetos ItemArticulo
                foreach (DataRow row in dt.Rows)
                {
                    int idArticulo = Convert.ToInt32(row["id_articulo"]);
                    float precioArticulo = Convert.ToInt32(row["precio"]);
                    ItemArticulo item = new ItemArticulo(idArticulo, precioArticulo);
                    item.Size = new Size(225, 240);
                    item.lbl_nombre_art.Text = row["nombre"].ToString();
                    item.lbl_precio.Text = Convert.ToDecimal(row["precio"]).ToString() + " $";

                    flowLayoutPanel1.Controls.Add(item); // Agrega el item al flowLayoutPanel1
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Muestra un mensaje en caso de error
                throw;
            }
        }

        // Método para cerrar la aplicación
        private void close_cliente_v2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        // Método para cargar los pedidos antiguos del cliente
        public static void cargarAntiguosPedidos()
        {
            btn_carrito.Visible = true; // Muestra el botón de carrito
            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                con.Open();

                SqlCommand cmd = new SqlCommand("ObtenerPedidosCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_cliente ", Login.clienteLogueado.id_cliente));
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Itera sobre las filas del DataTable para mostrar los pedidos antiguos
                foreach (DataRow row in dt.Rows)
                {
                    flowLayoutPanel2.Controls.Remove(pb_nopedidoAntiguo);
                    int id = Convert.ToInt32(row["id_pedido"]);
                    ItemPedidoAntiguo item = new ItemPedidoAntiguo(id);
                    item.Size = new Size(245, 52);
                    item.lbl_pedido_antiguo.Text += " " + row["id_pedido"].ToString();
                    item.lbl_precioTotal.Text = " $" + Convert.ToDecimal(row["importe"]).ToString();
                    item.lbl_fecha.Text = row["fecha_pedido"].ToString();
                    flowLayoutPanel2.Controls.Add(item); // Agrega el item al flowLayoutPanel2
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar los paneles antiguos");
            }
        }

        // Manejador de eventos para el botón de iniciar sesión
        private void bn_login_v2_Click(object sender, EventArgs e)
        {
            Login lg = new Login("cliente");
            lg.Show();
            this.Show();
        }

        // Manejador de eventos para el botón de iniciar sesión como administrador
        private void btn_login_admin_Click(object sender, EventArgs e)
        {
            Login lg = new Login("admin");
            lg.Show();
            this.Hide();
        }

        // Manejador de eventos para el botón de ver el carrito
        private void btn_carrito_Click(object sender, EventArgs e)
        {
            //comprobar si el cliente tiene un carrito asociado
            int idCarrito = Carrito.ObtenerIdCarritoCliente(Login.clienteLogueado.id_cliente);
            if (idCarrito != -1)
            {
                VistaCarrito cart = new VistaCarrito();
                cart.llenarVistaCarrito();
                cart.Show();
            }
            else
            {
                MessageBox.Show("No tiene ningún producto en el carrito", "Info");
            }
        }

        // Manejador de eventos para el botón de ajustes de cuenta
        private void btn_ajustes_cuenta_Click(object sender, EventArgs e)
        {
            AjustesCuenta ac = new AjustesCuenta(Login.clienteLogueado.id_cliente);
            ac.Show();
        }
    }
}

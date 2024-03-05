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
    public partial class VistaClienteV2 : Form

    {
        //ClienteAplicacion usuario;
        public VistaClienteV2()
        {

            InitializeComponent();
            populateItemsArticulos();
        }
        public static void comprobarHayCliente()
        {
            if (Login.clienteLogueado != null)
            {
                pnl_sinlogin.Visible = false;

                pnl_anitguosped.Visible = true;
                // ItemArticulo.btn_comprar.Enabled = true;
            }
        }
        //Popular los items de articulos 

        public static void populateItemsArticulos()
        {
            string sqlQuery = "Select a.id_articulo,a.nombre,a.id_categoria, c.nombre as nombre_categoria, a.marca, a.precio, a.stock , a.id_proveedor , a.id_almacen from articulos a, categorias c where a.id_categoria = c.id_categoria";

            try
            {
                SqlConnection con = new SqlConnection(Form1.connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, Form1.connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int idArticulo = Convert.ToInt32(row["id_articulo"]);
                    float precioArticulo = Convert.ToInt32(row["precio"]);
                    ItemArticulo item = new ItemArticulo(idArticulo, precioArticulo);
                    item.Size = new Size(225, 240);


                    item.lbl_nombre_art.Text = row["nombre"].ToString();
                    item.lbl_precio.Text = Convert.ToDecimal(row["precio"]).ToString() + " $";

                    flowLayoutPanel1.Controls.Add(item);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void close_cliente_v2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public static void cargarAntiguosPedidos()
        {
            btn_carrito.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection(Form1.connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("ObtenerPedidosCliente", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_cliente ", Login.clienteLogueado.id_cliente));
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    flowLayoutPanel2.Controls.Remove(pb_nopedidoAntiguo);

                    int id = Convert.ToInt32(row["id_pedido"]);

                    ItemPedidoAntiguo item = new ItemPedidoAntiguo(id);
                    item.Size = new Size(262, 52);

                    item.lbl_pedido_antiguo.Text += " " + row["id_pedido"].ToString();
                    item.lbl_precioTotal.Text = " $" + Convert.ToDecimal(row["importe"]).ToString();
                    item.lbl_fecha.Text = row["fecha_pedido"].ToString();

                    flowLayoutPanel2.Controls.Add(item);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error al cargar los paneles antiguos");
            }
        }
        private void bn_login_v2_Click(object sender, EventArgs e)
        {
            Login lg = new Login("cliente");
            lg.Show();
        }

        private void btn_login_admin_Click(object sender, EventArgs e)
        {
            Login lg = new Login("admin");
            lg.Show();
            this.Hide();
        }

        private void btn_carrito_Click(object sender, EventArgs e)
        {
            int resultado = Carrito.ObtenerIdCarritoCliente(Login.clienteLogueado.id_cliente);
            
            if (resultado != -1)
            {
                VistaCarrito cart = new VistaCarrito();
                cart.llenarVistaCarrito();
                cart.Show();

            } else
            {
                MessageBox.Show("No tiene ningún producto en el carrito");
            }
        }
     
    }
}

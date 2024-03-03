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
        public VistaClienteV2()
        {
            InitializeComponent();
            populateItemsArticulos();
            

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
                    ItemArticulo item = new ItemArticulo();
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

        
        /*
        public static void populateAntiguosPedidos ()
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
                    ItemArticulo item = new ItemArticulo();
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
        }*/
        private void close_cliente_v2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void cargarAntiguosPedidos()
        {
            try {
                SqlConnection con = new SqlConnection(Form1.connetionString);
                SqlCommand cmd = new SqlCommand("ObtenerPedidosCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ItemPedidoAntiguo item = new ItemPedidoAntiguo();
                    item.Size = new Size(225, 240);

                    item.lbl_pedido_antiguo.Text = row["id_pedido"].ToString();
                    item.lbl_precioTotal.Text = Convert.ToDecimal(row["precio"]).ToString() + " $";
                    item.lbl_fecha.Text = row["fecha_pedido"].ToString();

                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

      
    }
}

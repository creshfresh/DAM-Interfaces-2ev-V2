using GestionPapeleria.Clases;
using GestionPapeleria.Cliente;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionPapeleria
{
    public partial class Form1 : Form
    {
        public static string connetionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        //Variables para Articulos
        public static string nombreArt, marcaArt, categoriaArt, precioArt, stockArt, proveedorArt, almacenArt, idCatArt;
        public static int idArt, id_almacenArt, id_proveedorArt;
        public static string filtro_cat, filtro_nombre, filtro_marca;

        public bool estaEditando = false;


        //Variables para Categorias
        public static string nombreCatCat;
        public static int idCat;
        public static string filtro_nombre_cat;

        //Variables para Pedidos 
        public static string nombreClientePedido, fechaPedido, estadoPedido;
        public static int idPedido, idClientePedido, importePedido, filtro_idcliente_pedido;
        public static string filtro_estado;

        //Variables para Clientes

        public static string nombreClienteCompleto, correo, direccion, usernamecliente, telefono;
        public static int id_cliente;
        public static string filtro_nombre_completo, filtro_correo, filtro_username_cliente, filtro_direccion;


        //Variables para Roles Usuario
        public static string usernameadmin, rol, contrasenaadmin;
        public static int id_admin;
        public static string filtro_username_admin;




        public Form1()
        {
            InitializeComponent();
            cargarComboBoxAlmacenes();
            cargarComboBoxProveedores();
            filtroMarca();
            filtroCategoria();
            cargarArticulos();
            cargarCategorias();
            llevar_cb_categoria();
            cargarComboBoxMarcas();
            cargarPedidos();
            cargarClientes();
            llenarFiltroEstado();
        }

        private void cargarArticulos()
        {
            string sqlQuery = "Select a.id_articulo,a.nombre,a.id_categoria, c.nombre as nombre_categoria, a.marca, a.precio, a.stock , a.id_proveedor , a.id_almacen from articulos a, categorias c where a.id_categoria = c.id_categoria";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }


        private void cargarPedidos()
        {

            string sqlQuery = "Select a.id_pedido, a.id_cliente, a.fecha_pedido, a.importe, a.estado, c.id_cliente from pedidos a, clientes c where a.id_cliente = c.id_cliente";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_pedidos.DataSource = dt;


                //MessageBox.Show("Exito", "Succes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }
        private void cargarCategorias()
        {

            string sqlQuery = "Select * from categorias";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_categorias.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }


        private void cargarClientes()
        {
            string sqlQuery = "Select id_cliente, nombreCompleto , correo, telefono, direccion, username from clientes";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_clientes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }

        private void setEstaEditando()
        {

            if (estaEditando)
            {
                btn_insertar_art.Text = "EDITAR";
                lbl_altaProducto.Text = "Editar articulo";
            }
            else
            {
                btn_insertar_art.Text = "INSERTAR";
                lbl_altaProducto.Text = "Alta de producto";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Select a.id_articulo,a.nombre,a.id_categoria, c.nombre as nombre_categoria, a.marca, a.precio, a.stock , a.id_proveedor , a.id_almacen from articulos a, categorias c where a.id_categoria = c.id_categoria";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                MessageBox.Show("Exito", "Succes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            setEstaEditando();
            //Está creando un articulo
            if (btn_insertar_art.Text.Equals("INSERTAR"))
            {
                insertarArticulo();
                cargarArticulos();
            }
            else
            {
                //Está editando un articulo seleccionado
                try
                {
                    editarArticulo();
                    lb_ir_alta_art.Hide();
                    estaEditando = false;
                    setEstaEditando();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }

            }

        }

        private void insertarArticulo()
        {

            if (tb_nombre.Text != "" || cb_marca.Text != "" || cb_categoria.SelectedValue != null || tb_precio.Text != "" || tb_stock.Text != "" || cb_proveedor.SelectedValue != null || cb_almacen.SelectedValue != null)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connetionString);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("GuardarArticulo", con);

                    //Indicamos que el comando va a ser un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Comprobar que los campos estén rellenos
                    string nombreArticulo = tb_nombre.Text;
                    string marcaArticulo = cb_marca.Text;
                    int id_categoria = Convert.ToInt32(cb_categoria.SelectedValue);
                    //string nombre_categoria = cb_categoria.SelectedItem.ToString();
                    float precio = float.Parse(tb_precio.Text);
                    int sotck = int.Parse(tb_stock.Text);
                    int proveedor = Convert.ToInt32(cb_proveedor.SelectedValue);
                    int alamacen = Convert.ToInt32(cb_almacen.SelectedValue);

                    cmd.Parameters.Add(new SqlParameter("@nombre", nombreArticulo));
                    cmd.Parameters.Add(new SqlParameter("@id_categoria", id_categoria));
                    cmd.Parameters.Add(new SqlParameter("@marca", marcaArticulo));
                    cmd.Parameters.Add(new SqlParameter("@precio", precio));
                    cmd.Parameters.Add(new SqlParameter("@stock", sotck));
                    cmd.Parameters.Add(new SqlParameter("@id_proveedor", proveedor));
                    cmd.Parameters.Add(new SqlParameter("@id_almacen", alamacen));


                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Éxito");
                    limpiarDatos();





                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo");
                    throw;
                }
            }

            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message");

            }




        }

        private void editarArticulo()

        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("AlterarArticulo", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                // Comprobar que los campos estén rellenos
                int id_articulo = idArt;
                string nombreArticulo = tb_nombre.Text;
                string marcaArticulo = cb_marca.Text;
                int id_categoria = Convert.ToInt32(cb_categoria.SelectedValue);
                float precio = float.Parse(tb_precio.Text);
                int sotck = int.Parse(tb_stock.Text);
                int proveedor = Convert.ToInt32(cb_proveedor.SelectedValue);
                int alamacen = Convert.ToInt32(cb_almacen.SelectedValue);
                if (tb_nombre.Text != "" || cb_marca.Text != "")
                {
                    cmd.Parameters.Add(new SqlParameter("@id_articulo", id_articulo));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombreArticulo));
                    cmd.Parameters.Add(new SqlParameter("@id_categoria", id_categoria));
                    cmd.Parameters.Add(new SqlParameter("@marca", marcaArticulo));
                    cmd.Parameters.Add(new SqlParameter("@precio", precio));
                    cmd.Parameters.Add(new SqlParameter("@stock", sotck));
                    cmd.Parameters.Add(new SqlParameter("@id_proveedor", proveedor));
                    cmd.Parameters.Add(new SqlParameter("@id_almacen", alamacen));


                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Éxito");
                    limpiarDatos();
                    cargarArticulos();

                }
                else
                {
                    MessageBox.Show("Los campos deben estar rellenos", "Error Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo");
                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void cargarComboBoxProveedores()
        {
            string sqlQuery = "Select * from proveedores";

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_proveedor.DataSource = dt;
                cb_proveedor.DisplayMember = "nombre";
                cb_proveedor.ValueMember = "id_proveedor";
                cb_proveedor.SelectedIndex = -1;

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void llevar_cb_categoria()
        {
            //Lenar el comboBox con los almacenes con el id de proveedor que nos pasan por parámetro

            string sqlQuery = "Select * from categorias";

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_categoria.DataSource = dt;
                cb_categoria.DisplayMember = "nombre";
                cb_categoria.ValueMember = "id_categoria";
                cb_categoria.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        private void cargarComboBoxMarcas()
        {
            //Lenar el comboBox con los almacenes con el id de proveedor que nos pasan por parámetro

            string sqlQuery = "Select DISTINCT marca from articulos";

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_marca.DataSource = dt;
                cb_marca.DisplayMember = "marca";
                cb_marca.ValueMember = "marca";
                cb_marca.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cargarComboBoxAlmacenes()
        {
            //Lenar el comboBox con los almacenes con el id de proveedor que nos pasan por parámetro

            string sqlQuery = "Select * from almacenes";

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_almacen.DataSource = dt;
                cb_almacen.DisplayMember = "nombre";
                cb_almacen.ValueMember = "id_almacen";
                cb_almacen.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        //Seleccionar los datos de la tabla Articulos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[currentRowIndex].Selected = true;

            //Almacenar todos los datos en variables para poder editarlos

            //id
            idArt = int.Parse(dataGridView1.Rows[currentRowIndex].Cells[0].Value.ToString());

            //Nombre
            nombreArt = dataGridView1.Rows[currentRowIndex].Cells[1].Value.ToString();

            //Id categoria
            idCatArt = dataGridView1.Rows[currentRowIndex].Cells[2].Value.ToString();

            //Nombre categoria
            categoriaArt = dataGridView1.Rows[currentRowIndex].Cells[3].Value.ToString();

            //Marca
            marcaArt = dataGridView1.Rows[currentRowIndex].Cells[4].Value.ToString();

            //Precio
            precioArt = dataGridView1.Rows[currentRowIndex].Cells[5].Value.ToString();

            //Stock
            stockArt = dataGridView1.Rows[currentRowIndex].Cells[6].Value.ToString();

            //Proveedor 
            id_proveedorArt = int.Parse(dataGridView1.Rows[currentRowIndex].Cells[7].Value.ToString());

            //Almacen 
            id_almacenArt = int.Parse(dataGridView1.Rows[currentRowIndex].Cells[8].Value.ToString());

            MessageBox.Show("Datos seleccionados", "Seleccionado");

        }

        //Seleccionar los datos de la tabla Categorias
        private void dataGridView_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView_categorias.CurrentCell.RowIndex;
            dataGridView_categorias.Rows[currentRowIndex].Selected = true;
            //id
            idCat = int.Parse(dataGridView_categorias.Rows[currentRowIndex].Cells[0].Value.ToString());
            //Nombre
            nombreCatCat = dataGridView_categorias.Rows[currentRowIndex].Cells[1].Value.ToString();
            MessageBox.Show("Datos seleccionados", "Seleccionado");

        }

        //Seleccionar los datos de la tabla pedidos
        private void dataGridView_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView_categorias.CurrentCell.RowIndex;
            dataGridView_pedidos.Rows[currentRowIndex].Selected = true;

            //id pedido
            idPedido = int.Parse(dataGridView_pedidos.Rows[currentRowIndex].Cells[0].Value.ToString());

            // id cliente
            idClientePedido = int.Parse(dataGridView_pedidos.Rows[currentRowIndex].Cells[1].Value.ToString());

            // fecha pedido
            fechaPedido = dataGridView_pedidos.Rows[currentRowIndex].Cells[2].Value.ToString();

            // importe
            importePedido = int.Parse(dataGridView_pedidos.Rows[currentRowIndex].Cells[3].Value.ToString());

            //estado 
            estadoPedido = dataGridView_pedidos.Rows[currentRowIndex].Cells[4].Value.ToString();

        }


        private void dataGridView_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView_categorias.CurrentCell.RowIndex;
            dataGridView_pedidos.Rows[currentRowIndex].Selected = true;

            //id cliente
            id_cliente = int.Parse(dataGridView_clientes.Rows[currentRowIndex].Cells[0].Value.ToString());

            // nombreCompleto
            nombreClienteCompleto = dataGridView_clientes.Rows[currentRowIndex].Cells[1].Value.ToString();
            // correo
            correo = dataGridView_clientes.Rows[currentRowIndex].Cells[2].Value.ToString();

            // telefono
            telefono = dataGridView_clientes.Rows[currentRowIndex].Cells[3].Value.ToString();
            //direccion 
            direccion = dataGridView_clientes.Rows[currentRowIndex].Cells[4].Value.ToString();

            //username 
            estadoPedido = dataGridView_clientes.Rows[currentRowIndex].Cells[5].Value.ToString();

        }
        private void llenarDatosFormularioEditarArticulo(object sender, EventArgs e)
        {

            estaEditando = true;
            setEstaEditando();

            cb_categoria.Text = categoriaArt;
            cb_marca.Text = marcaArt;
            tb_nombre.Text = nombreArt;
            tb_precio.Text = precioArt;
            tb_stock.Text = stockArt;
            cb_almacen.SelectedValue = id_almacenArt;
            cb_proveedor.SelectedValue = id_proveedorArt;
            lb_ir_alta_art.Show();

        }

        private void llenarDatosFormularioEditarCategoria(object sender, EventArgs e)
        {
            tb_nombre_editar_cat.Text = nombreCatCat;
        }

        private void elminarRegistroArticulo(object sender, EventArgs e)
        {
            //Procedimiento almacenado para borrar un articulo  
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("eliminarArticulo", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                if (idArt != 0 && idArt != null)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar el articulo seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@Cid_articulo", idArt);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Éxito");
                        cargarArticulos();
                        //  filtroMarca();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Eliminación cancelada");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar el articulo a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo");
                throw;
            }

        }

        private void filtroMarca()
        {
            string query = "SELECT DISTINCT marca from articulos ";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_buscar_marca_art.DataSource = dt;
                cb_buscar_marca_art.DisplayMember = "marca";
                cb_buscar_marca_art.ValueMember = "marca";
                cb_buscar_marca_art.SelectedIndex = -1;

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }


        private void filtroCategoria()
        {
            string query = "SELECT nombre, id_categoria from categorias ";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_buscar_categoria_art.DataSource = dt;
                cb_buscar_categoria_art.DisplayMember = "nombre";
                cb_buscar_categoria_art.ValueMember = "nombre";
                cb_buscar_categoria_art.SelectedIndex = -1;

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        private void cb_filtro_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se guarda la variable seleccionada
            filtro_marca = cb_buscar_marca_art.SelectedValue as string;

        }

        private void cb_buscar_estado_ped_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se guarda la variable seleccionada
            filtro_estado = cb_buscar_estado_ped.SelectedValue as string;

        }
        private void tb_filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            filtro_nombre = tb_buscar_nombre_art.Text;
        }

        private void tb_filtro_nombre_cat_TextChanged(object sender, EventArgs e)
        {
            filtro_nombre_cat = tb_filtro_nombre_cat.Text;
        }

        private void btn_buscar_nombre_cat_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorNombreCat", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombreCategoria", filtro_nombre_cat));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_categorias.DataSource = dt;
                tb_filtro_nombre_cat.Text = string.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }
        private void btn_buscar_Nombre_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorNombre", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombre", filtro_nombre));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                cargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }

        private void llenarFiltroEstado()
        {

            string sqlQuery = "Select DISTINCT estado from pedidos";

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_buscar_estado_ped.DataSource = dt;
                cb_buscar_estado_ped.DisplayMember = "estado";
                cb_buscar_estado_ped.ValueMember = "estado";
                cb_buscar_estado_ped.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void cb_filtro_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro_cat = cb_buscar_categoria_art.SelectedValue as string;
        }

        private void tb_buscar_nombre_ped_TextChanged(object sender, EventArgs e)
        {
            filtro_idcliente_pedido = int.Parse( tb_buscar_nombre_ped.Text);
        }
        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                cargarCategorias();

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorCategoria", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombreCategoria", filtro_cat));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                borrar_filtros_art();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido categoria para filtrar ");
            }
        }


        private void btn_buscar_estado_ped_Click(object sender, EventArgs e)
        {
            try
            {
                cargarCategorias();

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltraPorEstado", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@estado", filtro_estado));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_pedidos.DataSource = dt;
                borrar_filtros_art();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido estado de pedido para filtrar ");
            }
        }

        private void btn_buscar_marca_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorMarca", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@marca", filtro_marca));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                borrar_filtros_art();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido marca para filtrar ");
            }
        }

        private void btn_borrar_filtros_Click(object sender, EventArgs e)
        {
            borrar_filtros_art();
            cargarArticulos();
        }

        private void borrar_filtros_art()
        {
            cb_buscar_marca_art.SelectedIndex = -1;
            cb_buscar_categoria_art.SelectedIndex = -1;
            tb_buscar_nombre_art.Text = string.Empty;

        }

        private void borrar_filtros_cat()
        {
            tb_filtro_nombre_cat.Text = string.Empty;

        }

        private void limpiarDatos()
        {
            tb_nombre.Text = string.Empty;
            cb_marca.Text = string.Empty;
            cb_categoria.Text = string.Empty;
            tb_stock.Text = string.Empty;
            tb_precio.Text = string.Empty;
            cb_categoria.SelectedIndex = -1;
            cb_almacen.SelectedIndex = -1;
            cb_proveedor.SelectedIndex = -1;
            tb_nombre_cat.Text = string.Empty;
            tb_nombre_editar_cat.Text = string.Empty;
//tb_nombreCliente_ped.Text = string.Empty;
            cb_descuento_ped.SelectedIndex = -1;
            tb_importeEditado_ped.Text = string.Empty;


        }

        private void btn_VistaCliente_prov_Click(object sender, EventArgs e)
        {
            VistaClienteV2 vc = new VistaClienteV2();
            vc.Show();
            this.Hide();
        }

        private void lb_ir_alta_Arti_Click(object sender, EventArgs e)
        {
            estaEditando = false;
            limpiarDatos();
            setEstaEditando();
            lb_ir_alta_art.Hide();
        }

        private void btn_borrar_filtros_cat_Click(object sender, EventArgs e)
        {
            borrar_filtros_cat();
        }

        private void bt_insertar_cat_Click(object sender, EventArgs e)
        {

            insertarCategoria();
        }

        private void insertarCategoria()
        {
            if (tb_nombre_cat.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(connetionString);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("[GuardarCategoria]", con);


                    cmd.CommandType = CommandType.StoredProcedure;
                    nombreCatCat = tb_nombre_cat.Text;
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombreCatCat));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Éxito");
                    cargarCategorias();
                    limpiarDatos();
                    llevar_cb_categoria();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo");
                    throw;
                }
            }

            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message");

            }
        }

        private void btn_borrar_insertar_cat_Click(object sender, EventArgs e)
        {
            limpiarDatos();

        }

        private void btn_borrar_editar_ped_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btn_borrar_editar_cat_Click(object sender, EventArgs e)
        {
            tb_nombre_editar_cat.Text = string.Empty;
        }


        //Editar categoria seleccionada
        private void btn_editar_cat_Click(object sender, EventArgs e)
        {
            editarCategoria();
        }

        private void editarCategoria()
        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);

                con.Open();

                SqlCommand cmd = new SqlCommand("EditarCategoria", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                string nombre = tb_nombre_editar_cat.Text;
                int id_categoria = idCat;
                if (tb_nombre_editar_cat.Text != "" && idCat != null)
                {

                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@id_categoria", id_categoria));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Éxito");

                    limpiarDatos();

                    //Recargar todos los combobox donde aparecen las categorias
                    cargarCategorias();
                    llevar_cb_categoria();
                    filtroCategoria();
                }
                else
                {
                    MessageBox.Show("Los campos deben estar rellenos", "Error Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }

        private void eliminarCategoria()
        {
            //Procedimiento almacenado para borrar un articulo  
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("eliminarCategoria", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                if (idCat != 0 && idCat != null)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar la categoría seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@id_categoria", idCat);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Éxito");
                        cargarArticulos();
                        //  filtroMarca();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Eliminación cancelada");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar el articulo a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }

        private void btn_eliminar_cat_Click(object sender, EventArgs e)
        {
            eliminarCategoria();
            cargarCategorias();
        }

        private void btn_borrar_filtros_cat_Click_1(object sender, EventArgs e)
        {
            tb_filtro_nombre_cat.Text = string.Empty;
            cargarCategorias();
        }

        private void btn_borrar_filtros_ped_Click(object sender, EventArgs e)
        {
            tb_buscar_nombre_ped.Text = string.Empty;
            cb_buscar_estado_ped.SelectedIndex = -1;
            dtp_buscar_fecha_ped.CustomFormat = " ";
            cargarPedidos();
        }

        private void btn_buscar_idcliente_ped_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPedidoPorIdCliente", con);

                cmd.CommandType = CommandType.StoredProcedure;

                //idClientePedido
                cmd.Parameters.Add(new SqlParameter("@id_cliente", filtro_idcliente_pedido));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                cargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }
    }



}

//Unused code

/*
string sqlQuery = "INSERT INTO articulos (nombre, marca) VALUES (@nombre, @marca ) ";

try
{ 

    SqlConnection con = new SqlConnection(connetionString);
    con.Open();

    SqlCommand cmd = new SqlCommand(sqlQuery, con);
    ///////
    //Creamos los parametros


    var nombreArticulo = new SqlParameter("nombre", System.Data.SqlDbType.VarChar);

    nombreArticulo.Value = textBox1.Text; 
    cmd.Parameters.Add(nombreArticulo);


    var marcaArticulo = new SqlParameter("marca", System.Data.SqlDbType.VarChar);

    marcaArticulo.Value = textBox2.Text;
    cmd.Parameters.Add(marcaArticulo);

    cmd.ExecuteNonQuery();
    con.Close();

    MessageBox.Show("Éxito");

}
catch(Exception ex)
{
    MessageBox.Show("Fallo");
    throw;

}
*/

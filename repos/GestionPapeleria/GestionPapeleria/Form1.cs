using GestionPapeleria.Cliente;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace GestionPapeleria
{
    public partial class Form1 : Form
    {
        public static string rolUser;
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
        public static int idPedido, idClientePedido, filtro_idcliente_pedido;
        public static float importePedido, descuento, nuevoTotal;
        public static string filtro_estado;

        //Variables para Clientes

        public static string nombreClienteCompleto, correo, direccion, usernamecliente, telefono;
        public static int id_cliente;
        public static string filtro_nombre_completo, filtro_correo, filtro_username_cliente, filtro_direccion, filtro_telefono;


        //Variables para Roles Usuario
        public static string usernameadmin, rol, contrasenaadmin;
        public static int id_admin;
        public static string filtro_username_admin, filtro_rol_admin;




        public Form1(String rol)
        {
            rolUser = rol;
            InitializeComponent();

            if (rolUser.Contains("worker")) tabcontrol.TabPages.Remove(tabPage1);

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
            cargarUsuarios();
        }

        //Método para mostrar todos los articulos
        public static void cargarArticulos()
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
        //Método para mostrar todos los usuarios
        private void cargarUsuarios()
        {
            string sqlQuery = " Select id_usuario, nombre, rol from usuariosAdministradores";
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connetionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_rolesUsuarios.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }

        //Método para mostrar todos los pedidos
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

        //Método para mostrar todas las categorias
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

        //Método para mostrar todos los clientes

        public void cargarClientes()
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

        private void setEstaEditandoClientes()
        {

            if (estaEditando)
            {
                btn_alta_cliente.Text = "EDITAR";
                lbl_altaCliente.Text = "Editar cliente";
            }
            else
            {
                btn_alta_cliente.Text = "INSERTAR";
                lbl_altaCliente.Text = "Alta de cliente";
                tb_contrasena_cli.Enabled = true;


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

        //Boón de insertar articulos (Comprueba si se está editando o no)
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
        /*
        private void insertarCliente()
        {

            if (tb_nombre_cli.Text != "" || tb_correo_cli.Text != "" || tb_direccion_cli.Text != "" || tb_username_cli.Text != "" || tb_contrasena_cli.Text != "")
            {
                try
                {



                    if (tb_contrasena_cli.Text.Length >= 4)
                    {
                        //DEbo comprobar que ser username no está cogido
                        SqlConnection con = new SqlConnection(connetionString);

                        con.Open();

                        SqlCommand cmd = new SqlCommand("insertarCliente", con);

                        //Indicamos que el comando va a ser un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Comprobar que los campos estén rellenos
                        string nombreCompleto = tb_nombre_cli.Text;
                        string correo = tb_correo_cli.Text;
                        string telefono = tb_telefono_cli.Text;

                        string direccion = tb_direccion_cli.Text;
                        string username = tb_username_cli.Text;

                        // Contraseña cifrada
                        string password = AesCrypt.Encrypt(tb_contrasena_cli.Text);


                        cmd.Parameters.Add(new SqlParameter("@nombreCompleto", nombreCompleto));
                        cmd.Parameters.Add(new SqlParameter("@correo", correo));
                        cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                        cmd.Parameters.Add(new SqlParameter("@direccion", direccion));
                        cmd.Parameters.Add(new SqlParameter("@username", username));
                        cmd.Parameters.Add(new SqlParameter("@passwordclient", password));


                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Éxito");
                        limpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe ser de 4 carácteres o más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   

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


        }*/
        private void insertarCliente()
        {
            if (tb_nombre_cli.Text != "" || tb_correo_cli.Text != "" || tb_direccion_cli.Text != "" || tb_username_cli.Text != "" || tb_contrasena_cli.Text != "")
            {
                try
                {
                    if (tb_contrasena_cli.Text.Length >= 4)
                    {
                        string username = tb_username_cli.Text;

                        // Verificar si el usuario ya existe en la base de datos
                        bool usuarioExiste = ExisteUsuario.VerificarClienteExistente(username);

                        if (!usuarioExiste)
                        {
                            // El usuario no existe, proceder con la inserción
                            SqlConnection con = new SqlConnection(connetionString);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insertarCliente", con);
                            cmd.CommandType = CommandType.StoredProcedure;

                   
                            // Comprobar que los campos estén rellenos
                            string nombreCompleto = tb_nombre_cli.Text;
                            string correo = tb_correo_cli.Text;
                            string telefono = tb_telefono_cli.Text;
                            string direccion = tb_direccion_cli.Text;
                      

                            // Contraseña cifrada
                            string password = AesCrypt.Encrypt(tb_contrasena_cli.Text);


                            cmd.Parameters.Add(new SqlParameter("@nombreCompleto", nombreCompleto));
                            cmd.Parameters.Add(new SqlParameter("@correo", correo));
                            cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                            cmd.Parameters.Add(new SqlParameter("@direccion", direccion));
                            cmd.Parameters.Add(new SqlParameter("@username", username));
                            cmd.Parameters.Add(new SqlParameter("@passwordclient", password));


                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Éxito");
                            limpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario ya está en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe ser de 4 caracteres o más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message");
            }
        }
        private void insertarUsuarioAdmin()
        {
            if (tb_username_user.Text != "" || tb_contrasena_user.Text != "")
            {
                if (tb_contrasena_user.Text.Length >= 4)
                {
                    string username = tb_username_user.Text;

                    // Verificar si el nombre de usuario de administrador ya existe en la base de datos
                    bool usuarioAdminExiste = ExisteUsuario.VerificarUsuarioExistente(username);

                    if (!usuarioAdminExiste)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(connetionString);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("InsertarUsuarioAdmin", con);
                            cmd.CommandType = CommandType.StoredProcedure;

                            // CIFRAR contraseña
                            string password = AesCrypt.Encrypt(tb_contrasena_user.Text);

                            cmd.Parameters.Add(new SqlParameter("@usernameAdmin", username));
                            cmd.Parameters.Add(new SqlParameter("@contrasenaAdmin", password));

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
                        MessageBox.Show("El nombre de usuario de administrador ya está en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe ser de 4 caracteres o más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message");
            }
        }

        /*

        private bool VerificarClienteExistente(string username)
        {
            bool usuarioExiste = false;

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("ComprobarClienteExiste", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);

                int count = (int)cmd.ExecuteScalar(); // Obtiene el número de clientes con ese nombre de usuario

                if (count > 0)
                {
                    usuarioExiste = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario existente");
                throw;
            }

            return usuarioExiste;
        }
        private bool VerificarUsuarioExistente(string username)
        {
            bool usuarioExiste = false;

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("ComprobarUserAdminExiste", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);

                int count = (int)cmd.ExecuteScalar(); // Obtiene el número de clientes con ese nombre de usuario

                if (count > 0)
                {
                    usuarioExiste = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario existente");
                throw;
            }

            return usuarioExiste;
        }
        /*
        private void insertarUsuarioAdmin()
        {

            if (tb_username_user.Text != "" || tb_contrasena_user.Text != "") { 

                if (tb_contrasena_user.Text.Length >= 4 ) {

                    try
                    {
                        SqlConnection con = new SqlConnection(connetionString);

                        con.Open();

                        SqlCommand cmd = new SqlCommand("InsertarUsuarioAdmin", con);

                        //Indicamos que el comando va a ser un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Comprobar que los campos estén rellenos
                        string username = tb_username_user.Text;


                        //CIFRARLAAAAAAAAAAAA
                        string password = AesCrypt.Encrypt(tb_contrasena_user.Text);


                        cmd.Parameters.Add(new SqlParameter("@usernameAdmin", username));
                        cmd.Parameters.Add(new SqlParameter("@contrasenaAdmin", password));



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
                    MessageBox.Show("La contraseña debe ser de 4 carácteres o más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }

            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message");

            }

        }
        */
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

                    MessageBox.Show("Articulo Editado", "Info");

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


        private void editarPedido()
        {
            try
            {
                //Seleccionar el id 
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("EditarPedido", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                //Seleccionar el descuento
                descuento = Convert.ToSingle(cb_descuento_ped.SelectedValue);

                int id_pedido = Convert.ToInt32(tb_idpedido_ped.Text);

                // Mostrar el precio con el descuento

                if (tb_idpedido_ped != null && tb_importeEditado_ped != null && cb_descuento_ped != null)
                {

                    cmd.Parameters.Add(new SqlParameter("@id_pedido", id_pedido));
                    cmd.Parameters.Add(new SqlParameter("@nuevo_importe", nuevoTotal));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Pedido Editado", "Éxito");

                    cargarPedidos();

                }


            }
            catch
            { MessageBox.Show("Fallo al editar el pedido"); }
        }

        private void editarCliente()
        {

            if (tb_nombre_cli.Text != "" || tb_correo_cli.Text != "" || tb_direccion_cli.Text != "" || tb_username_cli.Text != "" || tb_contrasena_cli.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(connetionString);

                    con.Open();

                    SqlCommand cmd = new SqlCommand("editarCliente", con);

                    //Indicamos que el comando va a ser un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Comprobar que los campos estén rellenos
                    
                    string nombreCompleto = tb_nombre_cli.Text;
                    string correo = tb_correo_cli.Text;
                    string telefono = tb_telefono_cli.Text;
                    string direccion = tb_direccion_cli.Text;
                    string username = tb_username_cli.Text;

                    // Contraseña cifrada
                    // string password = tb_contrasena_cli.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", id_cliente));

                    cmd.Parameters.Add(new SqlParameter("@nombreCompleto", nombreCompleto));
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                    cmd.Parameters.Add(new SqlParameter("@direccion", direccion));
                    cmd.Parameters.Add(new SqlParameter("@username", username));



                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                    MessageBox.Show("Cliente Editado", "Éxito");
                    cargarClientes();
                    limpiarDatos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message");

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login("admin");
            this.Hide();
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
            int currentRowIndex = dataGridView_pedidos.CurrentCell.RowIndex;
            dataGridView_pedidos.Rows[currentRowIndex].Selected = true;

            //id pedido
            idPedido = int.Parse(dataGridView_pedidos.Rows[currentRowIndex].Cells[0].Value.ToString());

            // id cliente
            idClientePedido = int.Parse(dataGridView_pedidos.Rows[currentRowIndex].Cells[1].Value.ToString());

            // fecha pedido
            fechaPedido = dataGridView_pedidos.Rows[currentRowIndex].Cells[2].Value.ToString();

            // importe
            importePedido = float.Parse(dataGridView_pedidos.Rows[currentRowIndex].Cells[3].Value.ToString());

            //estado 
            estadoPedido = dataGridView_pedidos.Rows[currentRowIndex].Cells[4].Value.ToString();

            MessageBox.Show("Datos seleccionados", "Seleccionado");
        }

        private void dataGridView_rolesUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView_rolesUsuarios.CurrentCell.RowIndex;
            dataGridView_rolesUsuarios.Rows[currentRowIndex].Selected = true;

            //id usuario
            id_admin = int.Parse(dataGridView_rolesUsuarios.Rows[currentRowIndex].Cells[0].Value.ToString());
            //username

            usernameadmin = dataGridView_rolesUsuarios.Rows[currentRowIndex].Cells[1].Value.ToString();
            // rol

            rol = dataGridView_rolesUsuarios.Rows[currentRowIndex].Cells[2].Value.ToString();

            MessageBox.Show("Datos seleccionados", "Seleccionado");
        }

        private void dataGridView_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView_clientes.CurrentCell.RowIndex;
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
            usernamecliente = dataGridView_clientes.Rows[currentRowIndex].Cells[5].Value.ToString();

            MessageBox.Show("Datos seleccionados", "Seleccionado");

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

        private void llenarDatosFormularioEditarPedido(object sender, EventArgs e)
        {
            tb_idpedido_ped.Text = idPedido.ToString();
        }


        private void llenarDatosFormularioEditarCliente(object sender, EventArgs e)
        {

            estaEditando = true;
            setEstaEditandoClientes();
            tb_nombre_cli.Text = nombreClienteCompleto;
            tb_correo_cli.Text = correo;
            tb_direccion_cli.Text = direccion;
            tb_telefono_cli.Text = telefono;
            tb_username_cli.Text = usernamecliente;
            tb_contrasena_cli.Enabled = false;

            lb_ir_alta_cli.Show();
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
                        MessageBox.Show("Eliminación cancelada", "Cancelado");
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

        private void eliminarPedido(object sender, EventArgs e)
        {
            //Procedimiento almacenado para borrar un articulo  
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarPedido", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                if (idPedido != 0 && idPedido != null)
                {
                    if (estadoPedido.Contains("enviado"))
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar el pedido seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            cmd.Parameters.AddWithValue("@id_pedido", idPedido);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Éxito");
                            cargarArticulos();
                            //  filtroMarca();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Eliminación cancelada", "Cancelado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar un pedido sin enviar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                borrar_filtros_art();

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
            try
            {
                filtro_idcliente_pedido = int.Parse(tb_buscar_nombre_ped.Text);
            }
            catch
            {
                //Para que no salte al quitar el id de filtrado, no sé porqué pasa
            }
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
            tb_idpedido_ped.Text = string.Empty;
            cb_descuento_ped.SelectedIndex = -1;
            tb_importeEditado_ped.Text = string.Empty;
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
        private void btn_enviar_ped_Click(object sender, EventArgs e)
        {

            try
            {
                if (estadoPedido != "enviado" || idPedido == null)
                {
                    //idPedido
                    SqlConnection con = new SqlConnection(connetionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EnviarPedido", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id_pedido", idPedido));
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView_pedidos.DataSource = dt;

                    cargarPedidos();
                    MessageBox.Show("Pedido enviado");

                }
                else
                {
                    MessageBox.Show("El pedido ya ha sido enviado");
                }

            }
            catch { MessageBox.Show("Error al enviar el pedido"); };

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
                    MessageBox.Show("Categoria editada", "Éxito");

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
                        MessageBox.Show("Eliminación cancelada", "Cancelado");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar el articulo a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                int idClienteSelect = int.Parse(tb_buscar_nombre_ped.Text);
                cmd.Parameters.Add(new SqlParameter("@id_cliente", idClienteSelect));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_pedidos.DataSource = dt;

            }
            catch (Exception ex)
            {
                tb_buscar_nombre_ped.Text = string.Empty;
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }

        private void cb_descuento_ped_SelectedIndexChanged(object sender, EventArgs e)
        {

            descuento = Convert.ToSingle(cb_descuento_ped.SelectedItem);
            float nuevoDescuento = descuento / 100;
            nuevoTotal = importePedido - (nuevoDescuento * importePedido);
            nuevoTotal = (float)Math.Round(nuevoTotal, 3);
            tb_importeEditado_ped.Text = nuevoTotal.ToString();

        }

        private void btn_editar_ped_Click(object sender, EventArgs e)
        {
            editarPedido();

            tb_idpedido_ped.Text = string.Empty;
            cb_descuento_ped.SelectedIndex = -1;
            tb_importeEditado_ped.Text = string.Empty;

        }

        private void btn_editar_pedido_Click(object sender, EventArgs e)
        {
            tb_buscar_nombre_ped.Text = string.Empty;
            cb_buscar_estado_ped.SelectedIndex = -1;
  
            tb_idpedido_ped.Text = idPedido.ToString();
        }

        private void btn_borrar_filtros_cli_Click(object sender, EventArgs e)
        {
            borrarFiltrosClientes();
            cargarClientes();
        }

        private void btn_alta_cliente_Click(object sender, EventArgs e)
        {

            setEstaEditandoClientes();
            //Está creando un articulo
            if (btn_alta_cliente.Text.Equals("INSERTAR"))
            {
                insertarCliente();
                cargarClientes();
            }
            else
            {
                //Está editando un articulo seleccionado
                try
                {
                    editarCliente();
                    lb_ir_alta_cli.Hide();
                    estaEditando = false;
                    setEstaEditandoClientes();
                    borrarFormularioCliente();

                }
                catch (Exception ex)
                {
 
                }

            }
        }

        private void borrarFormularioCliente()
        {
            tb_nombre_cli.Text = string.Empty;
            tb_correo_cli.Text = string.Empty;
            tb_direccion_cli.Text = string.Empty;
            tb_telefono_cli.Text = string.Empty;
            tb_username_cli.Text = string.Empty;
            tb_contrasena_cli.Text = string.Empty;
        }

        private void btn_clear_cli_Click(object sender, EventArgs e)
        {
            borrarFormularioCliente();
        }

        private void btn_eliminar_cli_Click(object sender, EventArgs e)
        {
            //Procedimiento almacenado para borrar un articulo  
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("eliminarCliente", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                if (id_cliente != 0 && id_cliente != null)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar el cliente seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Éxito");
                        cargarClientes();
                        //  filtroMarca();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Eliminación cancelada", "Cancelado");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar el cliente a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }

        private void btn_insertar_user_Click(object sender, EventArgs e)
        {
            insertarUsuarioAdmin();
            tb_username_user.Text = string.Empty;
            tb_contrasena_user.Text = string.Empty;
            cargarUsuarios();
        }

        private void btn_clear_users_Click(object sender, EventArgs e)
        {
            tb_username_user.Text = string.Empty;
            tb_contrasena_user.Text = string.Empty;
        }

        private void btn_eliminar_user_Click(object sender, EventArgs e)
        {
            //Procedimiento almacenado para borrar un articulo  
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("eliminarUsuario", con);

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                if (id_admin != 0 && id_admin != null)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar el usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", id_admin);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Éxito");
                        cargarUsuarios();


                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Eliminación cancelada", "Cancelado");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar el usuario a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }

        private void lb_ir_alta_cli_Click(object sender, EventArgs e)
        {
            estaEditando = false;
            borrarFormularioCliente();
            setEstaEditandoClientes();
            lb_ir_alta_cli.Hide();
        }

        //Método para quitar los prilegios de administrador (solo no podrán dar de alta a itros usuarios)
        private void btn_quitarprivilegio_user_Click(object sender, EventArgs e)
        {
            //Convertir al usuario admin en worker

            try
            {
                if (rol.Contains("admin"))
                {


                    DialogResult dialogResult = MessageBox.Show("¿Quieres quitar los permisos al usuario?", "Confirmar permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection(connetionString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("QuitarPrivilegios", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@id_usuario", id_admin));
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView_pedidos.DataSource = dt;

                        cargarUsuarios();
                        MessageBox.Show("Permisos modificados");
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada", "Cancelado");
                    }

                }
                else
                {
                    MessageBox.Show("El usuario ya no tiene permisos de administrador", "Info");
                }

            }
            catch { MessageBox.Show("Error al cambiar privilegios"); };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tb_contrasena_user.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void cb_password_CheckedChanged(object sender, EventArgs e)
        {
            tb_contrasena_cli.PasswordChar = cb_password.Checked ? '\0' : '*';
        }

        private void btn_buscar_username_user_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorUserName", con);

                cmd.CommandType = CommandType.StoredProcedure;

                string usernameAdmin = tb_buscar_username_user.Text;
                cmd.Parameters.Add(new SqlParameter("@nombre", usernameAdmin));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_rolesUsuarios.DataSource = dt;

            }
            catch (Exception ex)
            {
                tb_buscar_nombre_ped.Text = string.Empty;
                MessageBox.Show("Fallo: no se ha introducido el username para filtrar ");
            }
        }

        private void tb_buscar_username_user_TextChanged(object sender, EventArgs e)
        {
            filtro_username_admin = tb_buscar_username_user.Text;
        }

        private void btn_borrar_filtros_users_Click(object sender, EventArgs e)
        {
            tb_buscar_username_user.Text = string.Empty;
            cb_buscar_rol_user.SelectedIndex = -1;

            cargarUsuarios();
        }

        //Obtener el rol de los usuarios
        private void cb_buscar_rol_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro_rol_admin = cb_buscar_rol_user.SelectedItem as string;

        }

        //Buscar por el rol de los usuarios
        private void btn_buscar_rol_user_Click(object sender, EventArgs e)
        {

            try
            {
                cargarUsuarios();

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltraPorRol", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@rol", filtro_rol_admin));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_rolesUsuarios.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido rol del usuario para filtrar ");
            }


        }

        //Botón para buscar por nombre a los clientes
        private void btn_buscar_nombre_cli_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorNombreCompletoCliente", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombreCompleto", filtro_nombre_completo));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_clientes.DataSource = dt;
                borrarFiltrosClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }
        //Botón para buscar por username a los clientes
        private void btn_buscar_username_cli_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorUsernameClientes", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", filtro_username_cliente));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_clientes.DataSource = dt; 
                borrarFiltrosClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }
        // Botón para buscar por el correo a los clientes
        private void btn_buscar_correo_cli_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorCorreo", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@correo", filtro_correo));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_clientes.DataSource = dt;
                borrarFiltrosClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }
        //Botón para buscar por la dirección a los clientes
        private void btn_buscar_direccion_cli_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorDirrecion", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@direccion", filtro_direccion));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_clientes.DataSource = dt;
                borrarFiltrosClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el nombre para filtrar ");
            }
        }
        //Botón para buscar por teléfono a los clientes
        private void btn_buscar_telefono_cli_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("FiltrarPorTelefono", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@telefono", filtro_telefono));

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_clientes.DataSource = dt;
                borrarFiltrosClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: no se ha introducido el teléfono para filtrar ");
            }
        }

        private void borrarFiltrosClientes()
        {
            tb_buscar_nombre_cli.Text = string.Empty;
            tb_buscar_username_cli.Text = string.Empty;
            tb_buscar_correo_cli.Text = string.Empty;
            tb_buscar_direccion_cli.Text = string.Empty;
            tb_buscar_telefono_cli.Text = string.Empty;

        }

        //Obtener el nombre introducido para el filtro de nombre clientes

        private void tb_buscar_nombre_cli_TextChanged(object sender, EventArgs e)
        {
            filtro_nombre_completo = tb_buscar_nombre_cli.Text;
        }

        private void tb_buscar_username_cli_TextChanged(object sender, EventArgs e)
        {
            filtro_username_cliente = tb_buscar_username_cli.Text;
        }

        private void tb_buscar_correo_cli_TextChanged(object sender, EventArgs e)
        {
            filtro_correo = tb_buscar_correo_cli.Text;
        }

        private void tb_buscar_direccion_cli_TextChanged(object sender, EventArgs e)
        {
            filtro_direccion = tb_buscar_direccion_cli.Text;
        }

        private void tb_buscar_telefono_cli_TextChanged(object sender, EventArgs e)
        {
            filtro_telefono = tb_buscar_telefono_cli.Text;
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

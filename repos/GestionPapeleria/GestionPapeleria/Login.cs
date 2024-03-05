using GestionPapeleria.Clases;
using GestionPapeleria.Cliente;
using GestionPapeleria.Componentes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPapeleria
{

    public partial class Login : Form
    {
        public static ClienteAplicacion clienteLogueado;
        public static bool esAdmin;
        public static string tipoUserLogin;
        public Login(string tipoUser)
        {
            InitializeComponent();
            tipoUserLogin = tipoUser;
            setEsAdmin();
            lbl_admin.Visible = esAdmin;
            btn_clear.Visible = !esAdmin;
    
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void setEsAdmin()
        {
            esAdmin = (tipoUserLogin != "cliente");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
        
            if (tb_password.Text == String.Empty || tb_user.Text == String.Empty)
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tb_user.Text.Length < 3 || tb_password.Text.Length <4)
                {
                    MessageBox.Show("Username o Password no válido");
                }
                else
                {
                    if (!esAdmin)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(Form1.connetionString);
                            string username = tb_user.Text;
                            string encryptedPassword = AesCrypt.Encrypt(tb_password.Text);
                            con.Open();

                            SqlCommand command = new SqlCommand("login", con);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", encryptedPassword);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                string dbUsername = reader["username"].ToString();
                                string dbPassword = reader["contrasenaCliente"].ToString();

                                if (dbUsername == username && dbPassword == encryptedPassword)
                                {
                                   
                                    MessageBox.Show("¡Bienvenido!", "Inicio");
                                    guardarClienteLogeado();
                                    //VistaClienteV2 vistaCliente = new VistaClienteV2();
                                    this.Close();
                                    //vistaCliente.Show();
                      
                         
                                }
                                else
                                {
                                    MessageBox.Show("Error en el password", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario no registrado", "Error");
                            }

                            reader.Close();
                            con.Close(); // Cierra la conexión
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fallo", "Error");
                            throw;
                        }
                    }

                    //Es usuario administrador
                   else
                    {


                        try
                        {
                            SqlConnection con = new SqlConnection(Form1.connetionString);
                            string username = tb_user.Text;
                            string password = AesCrypt.Encrypt(tb_password.Text);


                            con.Open();

                            SqlCommand command = new SqlCommand("loginadmin", con);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                string dbUsername = reader["nombre"].ToString();
                                string dbPassword = reader["passwordAdmin"].ToString();

                                if (dbUsername == username && dbPassword == password)
                                {
                                  
                                    SqlConnection dbConn = new SqlConnection(Form1.connetionString);

                                    dbConn.Open();

                                    SqlCommand commandRol = new SqlCommand("GetRole", dbConn);
                                    commandRol.CommandType = CommandType.StoredProcedure;
                                    commandRol.Parameters.AddWithValue("@username", username);


                                    SqlDataReader readerRol = commandRol.ExecuteReader();

                                    if (readerRol.Read())
                                    {
                                        string rol = readerRol["rol"].ToString();

                                        MessageBox.Show("Bienvenido " + username, "Inicio");
                                        Form1 form1 = new Form1(rol);
                                        form1.Show();
                                        this.Hide();
                                        dbConn.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error en el password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario no registrado", "Error");
                            }
                            reader.Close();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fallo", "Error");
                            throw;
                        }
                    }
                } 
             }       
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            Hide();

        }

        public void guardarClienteLogeado ()
        {
            //Select del id del cliente 
            string username = tb_user.Text;
            try
            {
                SqlConnection con = new SqlConnection(Form1.connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("BuscarClienteporUsername", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        int id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                        string nombreCompleto = reader["nombreCompleto"].ToString();
                        string correo = reader["correo"].ToString();
                        string telefono = reader["telefono"].ToString();
                        string direccion = reader["direccion"].ToString();

                        clienteLogueado = new ClienteAplicacion(id_cliente, nombreCompleto, correo, telefono, direccion, username);
                        VistaClienteV2.comprobarHayCliente();
                        VistaClienteV2.cargarAntiguosPedidos();
                      
                    }

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }
        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_password.Checked ? '\0' : '*';
        }
    }
}

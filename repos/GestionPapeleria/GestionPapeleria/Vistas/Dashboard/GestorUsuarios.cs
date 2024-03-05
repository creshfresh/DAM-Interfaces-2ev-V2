using GestionPapeleria.Auxiliar;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Vistas.Dashboard
{
    public class GestorUsuarios
    {
        public DataGridView dataGridView_clientes, dataGridView_rolesUsuarios;
        public GestorUsuarios(DataGridView dataGridView_clientes, DataGridView dataGridView_rolesUsuarios)
        {
                this.dataGridView_clientes = dataGridView_clientes;
                this.dataGridView_rolesUsuarios = dataGridView_rolesUsuarios;

        }

        public void CargarClientes()
        {
            string sqlQuery = "Select id_cliente, nombreCompleto , correo, telefono, direccion, username from clientes";
            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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

        //Método para mostrar todos los usuarios
        public void CargarUsuarios()
        {
            string sqlQuery = " Select id_usuario, nombre, rol from usuariosAdministradores";
            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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


        public bool InsertarCliente(string nombreCompleto, string correo, string telefono, string direccion, string username, string contrasena)
        {
            bool exito = false; // Variable para almacenar el resultado de la operación

            // Verifica que los campos no estén vacíos
            if (!string.IsNullOrEmpty(nombreCompleto) && !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(contrasena))
            {
                try
                {
                    // Verifica que la longitud de la contraseña sea mayor o igual a 4
                    if (contrasena.Length >= 4)
                    {
                        // Verificar si el usuario ya existe en la base de datos
                        bool usuarioExiste = ExisteUsuario.VerificarClienteExistente(username);

                        if (!usuarioExiste)
                        {
                            // El usuario no existe, proceder con la inserción
                            using (SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION))
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insertarCliente", con);
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Contraseña cifrada
                                string password = AesCrypt.Encrypt(contrasena);

                                // Agregar parámetros al comando
                                cmd.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                                cmd.Parameters.AddWithValue("@correo", correo);
                                cmd.Parameters.AddWithValue("@telefono", telefono);
                                cmd.Parameters.AddWithValue("@direccion", direccion);
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@passwordclient", password);

                                int filasAfectadas = cmd.ExecuteNonQuery(); // Ejecutar el comando y obtener el número de filas afectadas

                                exito = true;
                            }

                           
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
                    MessageBox.Show(ex.Message); // Mostrar mensaje de error
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Los campos deben estar rellenos", "Error Message"); // Mostrar mensaje de error
            }

            return exito; // Devolver el resultado de la operación
        }

    }
}

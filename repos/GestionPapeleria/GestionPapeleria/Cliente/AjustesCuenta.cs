using GestionPapeleria.Clases;
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

    public partial class AjustesCuenta : Form
    {
        public int idcliente;
        public AjustesCuenta(int idcliente)
        {
            InitializeComponent();
            this.idcliente = idcliente;
            llenarFormularioDatosBásicos();
        }

        private void close_cliente_ajutes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = cb_password.Checked ? '\0' : '*';
        }

        private void cb_password_CheckedChanged(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = cb_password.Checked ? '\0' : '*';
        }

        private void cb_passworagain_CheckedChanged(object sender, EventArgs e)
        {
            tb_repitepass.PasswordChar = cb_passworagain.Checked ? '\0' : '*';
        }


        //Método para Cambiar los datos del cliente logueado
        private void btn_guardarDatos_Click(object sender, EventArgs e)
        {

            //Primero comprobar si hay datos en la BBDD y llenar el formulario para cambiarlo

            //llenarFormularioDatosBásicos();

            try
            {
                SqlConnection con = new SqlConnection(Form1.connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("ConfiguracionCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", idcliente);
                cmd.Parameters.AddWithValue("@nombreCompleto", tb_nombreCompleto.Text);
                cmd.Parameters.AddWithValue("@correo", tb_correo.Text);
                cmd.Parameters.AddWithValue("@telefono", tb_telefono.Text);
                cmd.Parameters.AddWithValue("@direccion", tb_direccion.Text);

                // Ejecutar el procedimiento almacenado
                cmd.ExecuteNonQuery();

                MessageBox.Show("Datos guardados correctamente.", "Éxito");

            }
            //
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }

        //Método que llena los datos del cliente
        private void llenarFormularioDatosBásicos()
        {
            String query = "Select nombreCompleto, correo, telefono, direccion from clientes where id_cliente = @id_cliente";

            try
            {
                SqlConnection con = new SqlConnection(Form1.connetionString);

                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@id_cliente", idcliente);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tb_nombreCompleto.Text = (reader["nombreCompleto"] != DBNull.Value) ? reader["nombreCompleto"].ToString() : "N/A";
                    tb_correo.Text = (reader["correo"] != DBNull.Value) ? reader["correo"].ToString() : "N/A";
                    tb_telefono.Text = (reader["telefono"] != DBNull.Value) ? reader["telefono"].ToString() : "N/A";
                    tb_direccion.Text = (reader["direccion"] != DBNull.Value) ? reader["direccion"].ToString() : "N/A";
                }
                else
                {
                    tb_nombreCompleto.Text = "N/A";
                    tb_correo.Text = "N/A";
                    tb_telefono.Text = "N/A";
                    tb_direccion.Text = "N/A";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
                throw;
            }
        }
        public void cambiarContrasena()
        {

            try
            {
                SqlConnection con = new SqlConnection(Form1.connetionString);
                SqlCommand cmd = new SqlCommand("CambiarContrasena", con);
                con.Open();

                //Indicamos que el comando va a ser un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                string password = AesCrypt.Encrypt(tb_pass.Text);
                string passworrdepit = AesCrypt.Encrypt(tb_repitepass.Text);
                if (password == passworrdepit)
                {
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", idcliente));
                    cmd.Parameters.Add(new SqlParameter("@contrasenaCliente", passworrdepit));
                }

                MessageBox.Show(password);
           //     MessageBox.Show("Contraseña cambiada con éxito", "Éxito");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
                throw;
            }

        }

        private void btn_guardarnuevapass_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text != null && tb_repitepass.Text != null && tb_pass.Text == tb_repitepass.Text)
            {
                cambiarContrasena();
                
            }
            else
            {
                MessageBox.Show("Debe introducir bien los datos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

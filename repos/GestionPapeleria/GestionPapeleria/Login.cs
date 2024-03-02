﻿using Microsoft.Data.SqlClient;
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
        public static string connetionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Login()
        {
       
            InitializeComponent();
  
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == String.Empty || tb_user.Text == String.Empty)
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tb_user.Text.Length < 3 || tb_password.Text.Length < 5)
                {
                    MessageBox.Show("Username o Password no válido");
                }
                else
                {
                    try { 
                    SqlConnection con = new SqlConnection(connetionString);
                    string username = tb_user.Text;
                    string password = tb_password.Text;

                    con.Open();

                    SqlCommand command = new SqlCommand("login", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = command.ExecuteReader(); 

                    if (reader.Read())
                    {
                        string dbUsername = reader["username"].ToString();
                        string dbPassword = reader["password"].ToString();

                        if (dbUsername == username && dbPassword == password)
                        {
                            MessageBox.Show("Bienvenido");
                        }
                        else
                        {
                            MessageBox.Show("Error en el password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado");
                    }

                    reader.Close(); // Cierra el lector de datos
                    con.Close(); // Cierra la conexión

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fallo");
                        throw;
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
        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_password.Checked ? '\0' : '*';
        }
    }
}

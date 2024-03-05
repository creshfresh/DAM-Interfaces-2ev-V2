using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Auxiliar
{
    public class ExisteUsuario
    {

        public static bool VerificarUsuarioExistente(string username)
        {
            bool usuarioExiste = false;

            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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

        public static bool VerificarClienteExistente(string username)
        {
            bool usuarioExiste = false;

            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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
    }


}

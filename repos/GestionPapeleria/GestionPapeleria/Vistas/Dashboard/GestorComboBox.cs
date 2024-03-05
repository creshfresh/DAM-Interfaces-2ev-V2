using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Vistas.Dashboard
{
    public class GestorComboBox
    {

        private ComboBox cb_almacen, cb_proveedor , cb_marca;

        public GestorComboBox(ComboBox almacen , ComboBox proveedores,ComboBox cb_marca)
        {
            this.cb_almacen = almacen;
            this.cb_proveedor = proveedores;
            this.cb_marca = cb_marca;
        }

        public void CargarComboBoxAlmacenes()
        {
            //Lenar el comboBox con los almacenes con el id de proveedor que nos pasan por parámetro

            string sqlQuery = "Select * from almacenes";

            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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


        public void CargarComboBoxProveedores()
        {
            string sqlQuery = "Select * from proveedores";

            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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

        public void CargarComboBoxMarcas()
        {
            //Lenar el comboBox con los almacenes con el id de proveedor que nos pasan por parámetro

            string sqlQuery = "Select DISTINCT marca from articulos";

            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
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
    }
}

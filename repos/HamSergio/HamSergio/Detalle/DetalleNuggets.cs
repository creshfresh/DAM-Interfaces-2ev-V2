using MyBurguerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamSergio.Detalle
{
    // Formulario para mostrar los detalles de unos nuggets y permitir su agregado a la cesta
    public partial class DetalleNuggets : Form
    {
        Form2 ventana;

        // Constructor del formulario
        public DetalleNuggets()
        {
            InitializeComponent();
            // ventana = formDos; // Este código está comentado, no parece necesario aquí
        }

        // Cierra el formulario de detalles
        private void pb_close_detail_Click(object sender, EventArgs e) => this.Close();

        // Agrega unos nuggets a la cesta con la opción de añadir salsa barbacoa y muestra un mensaje de éxito
        private void button1_Click(object sender, EventArgs e)
        {
            Nuggets nuggets = new Nuggets();
            bool salsaSelected = checkedListBox2.CheckedItems.Contains("Añadir salsa barbacoa");

            Cesta.altaNugget(nuggets, salsaSelected);
            MessageBox.Show("Producto añadido con éxito", "Producto añadido");
            this.Close();
        }

        // Almacena los valores seleccionados en el CheckedListBox en una lista
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkedValues = checkedListBox2.CheckedItems.Cast<string>().ToList();
        }
    }

}

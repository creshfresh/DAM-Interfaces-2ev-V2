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
    // Formulario para mostrar los detalles de una hamburguesa "Burger Muerte" y permitir su agregado a la cesta
    public partial class DetalleBurgerrMuerte : Form
    {
        // Constructor del formulario
        public DetalleBurgerrMuerte() => InitializeComponent();

        // Cierra el formulario de detalles
        private void pb_close_detail_Click(object sender, EventArgs e) => this.Close();

        // Agrega una hamburguesa "Burger Muerte" a la cesta con las opciones de sin gluten y sin lactosa seleccionadas, y muestra un mensaje de éxito
        private void button1_Click(object sender, EventArgs e)
        {
            Hamburguesa ham = new Hamburguesa(4);
            bool sinGlutenSelected = checkedListBox2.CheckedItems.Contains("Sin gluten");
            bool sinLactosaSelected = checkedListBox2.CheckedItems.Contains("Sin lactosa");

            Cesta.altaHamburguesa(ham, sinGlutenSelected, sinLactosaSelected);
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

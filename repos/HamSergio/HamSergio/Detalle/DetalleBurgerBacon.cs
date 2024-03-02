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
    // Formulario de detalles para una hamburguesa y opción de agregar a la cesta
    public partial class DetalleBurgerBacon : Form
    {
        // Constructor del formulario
        public DetalleBurgerBacon() => InitializeComponent();

        // Cierra el formulario de detalles
        private void pb_close_detail_Click(object sender, EventArgs e) => this.Close();

        // Agrega una hamburguesa Burger Bacon a la cesta con extras seleccionados y muestra un mensaje de éxito
        private void button1_Click(object sender, EventArgs e)
        {
            Hamburguesa ham = new Hamburguesa(3);
            bool sinGlutenSelected = false, sinLactosaSelected = false;

            foreach (string item in checkedListBox2.CheckedItems)
            {
                if (item == "Sin gluten") sinGlutenSelected = true;
                else if (item == "Sin lactosa") sinLactosaSelected = true;
            }

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

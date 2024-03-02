using MyBurguerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamSergio
{
    public partial class DetalleBurger : Form
    {
        public DetalleBurger()
        {
            InitializeComponent();
        }

        // Método que se activa cuando se hace clic en el botón de cierre
        private void pb_close_detail_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        // Método que se activa cuando se hace clic en el botón "Aceptar"
        private void button1_Click(object sender, EventArgs e)
        {
            Hamburguesa ham = new Hamburguesa(1); 
            bool sinGlutenSelected = false; 
            bool sinLactosaSelected = false; 

            // Verifica los elementos seleccionados en el CheckedListBox
            foreach (string item in chk_list_extras.CheckedItems)
            {
                if (item.ToString() == "Sin gluten")
                {
                    sinGlutenSelected = true; 
                }
                else if (item.ToString() == "Sin lactosa")
                {
                    sinLactosaSelected = true; 
                }
            }

            // Agrega la hamburguesa a la cesta de compras con las opciones seleccionadas
            Cesta.altaHamburguesa(ham, sinGlutenSelected, sinLactosaSelected);

            // Muestra un mensaje de éxito
            MessageBox.Show("Producto añadido con éxito", "Producto añadido");

            this.Close(); 
        }

        // Método que se activa cuando cambia la selección en el CheckedListBox
        private void chk_list_extras_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkedValues = new List<string>(); 

            // Itera sobre los elementos seleccionados en el CheckedListBox
            foreach (string item in chk_list_extras.CheckedItems)
            {
                checkedValues.Add(item.ToString()); 
            }
        }
    }
}

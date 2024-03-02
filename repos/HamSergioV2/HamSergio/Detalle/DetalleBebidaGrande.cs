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
    // Formulario para mostrar los detalles de una bebida grande y permitir su agregado a la cesta
    public partial class DetalleBebidaGrande : Form
    {
        // Constructor del formulario
        public DetalleBebidaGrande() => InitializeComponent();

        // Cierra el formulario de detalles
        private void pb_close_detail_Click_1(object sender, EventArgs e) => this.Close();


        // Almacena los valores seleccionados en el CheckedListBox en una lista
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkedValues = new List<string>();

            foreach (string item in checkedListBox2.CheckedItems)
            {
                checkedValues.Add(item.ToString());
            }
        }
        // Agrega una bebida grande a la cesta con la opción de añadir pajita y muestra un mensaje de éxito
        private void button1_Click_1(object sender, EventArgs e)
        {

            Bebidas p = new Bebidas(2);
            bool conPajita = false;

            foreach (string item in checkedListBox2.CheckedItems)
            {
                if (item.ToString() == "Añadir pajita")
                {
                    conPajita = true;
                }
            }


            Cesta.altaBebida(p, conPajita);
            MessageBox.Show("Producto añadido con éxito", "Producto añadido");
            this.Close();
        }
    }
}


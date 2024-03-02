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
    public partial class DetalleBebidaPequeñacs : Form
    {
        Form formdos, formuno;

        public DetalleBebidaPequeñacs()
        {
            InitializeComponent();
        }

        // Método que se activa cuando se hace clic en el botón de cierre
        private void pb_close_detail_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        // Método que se activa cuando cambia la selección en el CheckedListBox
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> checkedValues = new List<string>(); 

            foreach (string item in checkedListBox2.CheckedItems)
            {
                checkedValues.Add(item.ToString()); 
            }
        }

        // Método que se activa cuando se hace clic en el botón "Aceptar"
        private void button1_Click_1(object sender, EventArgs e)
        {
            Bebidas p = new Bebidas(1); 
            bool conPajita = false; 

            // Verifica los elementos seleccionados en el CheckedListBox
            foreach (string item in checkedListBox2.CheckedItems)
            {
                if (item.ToString() == "Añadir pajita")
                {
                    conPajita = true; 
                }
            }

            // Agrega la bebida a la cesta de compras con las opciones seleccionadas
            Cesta.altaBebida(p, conPajita);

            // Muestra un mensaje de éxito
            MessageBox.Show("Producto añadido con éxito", "Producto añadido");

            this.Close(); 
        }
    }
}

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
    // Formulario para mostrar los detalles de unas patatas pequeñas y permitir su agregado a la cesta
    public partial class DetallePatatasPequeñas : Form
    {
        // Constructor del formulario
        public DetallePatatasPequeñas()
        {
            InitializeComponent();
        }

        // Cierra el formulario de detalles
        private void pb_close_detail_Click(object sender, EventArgs e) => this.Close();

        // Agrega unas patatas pequeñas a la cesta con la opción de añadir queso y muestra un mensaje de éxito
        private void button1_Click(object sender, EventArgs e)
        {
            Patatas p = new Patatas(1);
            bool conQuesoSelected = checkedListBox2.CheckedItems.Contains("Añadir queso");

            Cesta.altaPatatas(p, conQuesoSelected);
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

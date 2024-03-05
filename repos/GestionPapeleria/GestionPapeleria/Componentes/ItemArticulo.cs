using GestionPapeleria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPapeleria.Componentes
{
    public partial class ItemArticulo : UserControl
    {


        //Esta clase debe saber si el 
        public int id_producto;
        public float precio;
        public ItemArticulo(int id_Articulo, float precio_Articulo)
        {
            this.precio = precio_Articulo;
            this.id_producto = id_Articulo;
            InitializeComponent();
        }

   
        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (Login.clienteLogueado != null)
            {
                Carrito.AddArticulo(id_producto, Login.clienteLogueado.id_cliente, precio);
                MessageBox.Show("Producto añadido al carrito", "Éxito");
            } else {
                MessageBox.Show("Debe iniciar sesión para poder realizar una compra", "Inicie sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

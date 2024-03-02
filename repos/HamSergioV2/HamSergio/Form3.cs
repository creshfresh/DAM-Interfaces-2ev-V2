using HamSergio.Components;
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

namespace HamSergio
{
    public partial class Form3 : Form

    {
        int numeroPedido = 0;
        Form formdos, formuno;
        
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 ventana2, Form1 ventana1)
        {
            InitializeComponent();

            formdos = ventana2;
            formuno = ventana1;
            //Iniciar todos los métodos
            CalcularTotal();
            populateItemNuggets(Cesta.CantidadProductos, flowLayoutPanel1);
            populateItemBebida(Cesta.CantidadProductos, flowLayoutPanel1);
            populateItemPatatas(Cesta.CantidadProductos, flowLayoutPanel1);
            populateItemsHamburguesa(Cesta.CantidadProductos, flowLayoutPanel1);
            populateItemPostre(Cesta.CantidadProductos, flowLayoutPanel1);
            IsDisabled();

        }
        //Método para habilitar el botón de pago si hay algún elemento en cualquier lista
        private void IsDisabled()
        {
            v.Enabled = Cesta.gestorPatatas.Count != 0 || Cesta.gestorBebidas.Count != 0 || Cesta.gestorHamburguesas.Count != 0 || Cesta.gestorPostres.Count != 0 || Cesta.gestorNuggets.Count != 0;
        }
        //Método que obtiene el precio totoal de cada tipo de producto, lo suma y lo pone por pantalla
        private void CalcularTotal()
        {
            double total = Cesta.PrecioPos() + Cesta.PrecioBeb() + Cesta.PrecioPat() +Cesta.PrecioNug() + Cesta.PrecioHam();
            numeroPedido += 1;
            labl_num_pedido.Text = numeroPedido.ToString();
            String totalS = total.ToString("0.00");
            lbl_monto_total.Text = totalS + "€";

        }
        //Método que crea una instancia de un Item_pago dentro del panel con los datos de nuggets de la lista
        public static void populateItemNuggets(Dictionary<string, int> listadoPedidos, FlowLayoutPanel flowLayout)
        {
            //Itera sobre los elementos que contengan "Nuggets"
            foreach (string nombreProducto in Cesta.CantidadProductos.Keys.Where(p => p.StartsWith("Nuggets")))
            {
                // Obtiene la cantidad de este producto en la cesta
                int cantidad = Cesta.CantidadProductos[nombreProducto];

                // Divide el nombre del producto para obtener información sobre él
                string[] infoProducto = nombreProducto.Split(':');

                // Crea una instancia de Item_pago
                Item_pago item_pago = new Item_pago();
                item_pago.Size = new Size(400, 75);
                item_pago.lbl_nombre_pago.Text = infoProducto[0]; 
                item_pago.lbl_cantidad_pago.Text = cantidad.ToString(); 
                item_pago.lbl_precio_pago.Text = double.Parse(infoProducto[1]).ToString("F2"); // Precio del producto con formato 0.00
                item_pago.lb_icono_pago.Text = "🍗"; 

                // Se comprueban los extras y se agregan
                if (infoProducto.Length > 2)
                {
                    item_pago.lbl_extras.Text += infoProducto[2] + " ";
                }
                if (infoProducto.Length > 3)
                {
                    item_pago.lbl_extras.Text += infoProducto[3] + " ";
                }

                // Se añade el Item_pago al panel
                flowLayout.Controls.Add(item_pago);
            }
        }


        // Método que puebla el panel con los elementos de la lista de pedidos relacionados con Postre instanciando un Item_pago
        //Funciona igual que el metodo de populateItemNuggets
        public static void populateItemPostre(Dictionary<string, int> listadoPedidos, FlowLayoutPanel flowLayout)
        {
            foreach (string nombreProducto in listadoPedidos.Keys.Where(p => p.StartsWith("Postre")))
            {

                int cantidad = listadoPedidos[nombreProducto];
                string[] infoProducto = nombreProducto.Split(':');

                Item_pago item_pago = new Item_pago();
                item_pago.Size = new Size(400, 75);
                item_pago.lbl_nombre_pago.Text = infoProducto[0];
                item_pago.lbl_cantidad_pago.Text = cantidad.ToString();
                item_pago.lbl_precio_pago.Text = double.Parse(infoProducto[1]).ToString("F2");
                item_pago.lb_icono_pago.Text = "🍰";
                //Se comprueban los extras

                if (infoProducto.Length > 2)
                {
                    item_pago.lbl_extras.Text += infoProducto[2] + " ";
                }
                if (infoProducto.Length > 3)
                {
                    item_pago.lbl_extras.Text += infoProducto[3] + " ";
                }
                flowLayout.Controls.Add(item_pago);

            }
        }
        // Método que puebla el panel con los elementos de la lista de pedidos relacionados con Patatas instanciando un Item_pago
        //Funciona igual que el metodo de populateItemNuggets
        public static void populateItemPatatas(Dictionary<string, int> listadoPedidos, FlowLayoutPanel flowLayout)
        {

            foreach (string nombreProducto in listadoPedidos.Keys.Where(p => p.StartsWith("Patatas")))
            {

                int cantidad = listadoPedidos[nombreProducto];
                string[] infoProducto = nombreProducto.Split(':');

                Item_pago item_pago = new Item_pago();
                item_pago.Size = new Size(400, 75);
                item_pago.lbl_nombre_pago.Text = infoProducto[0];
                item_pago.lbl_cantidad_pago.Text = cantidad.ToString();
                item_pago.lbl_precio_pago.Text = double.Parse(infoProducto[1]).ToString("F2");
                item_pago.lb_icono_pago.Text = "🍟";
                //Se comprueban los extras
                if (infoProducto.Length > 2)
                {
                    item_pago.lbl_extras.Text += infoProducto[2] + " ";
                }
                if (infoProducto.Length > 3)
                {
                    item_pago.lbl_extras.Text += infoProducto[3] + " ";
                }
                flowLayout.Controls.Add(item_pago);

            }
         
        }
        // Método que puebla el panel con los elementos de la lista de pedidos relacionados con Bebida instanciando un Item_pago
        //Funciona igual que el metodo de populateItemNuggets
        public static void populateItemBebida(Dictionary<string, int> listadoPedidos, FlowLayoutPanel flowLayout)
        {

            foreach (string nombreProducto in listadoPedidos.Keys.Where(p => p.StartsWith("Bebida")))
            {

                int cantidad = listadoPedidos[nombreProducto];
                string[] infoProducto = nombreProducto.Split(':');

                Item_pago item_pago = new Item_pago();
                item_pago.Size = new Size(400, 75);
                item_pago.lbl_nombre_pago.Text = infoProducto[0];
                item_pago.lbl_cantidad_pago.Text = cantidad.ToString();
                item_pago.lbl_precio_pago.Text = double.Parse(infoProducto[1]).ToString("F2");
                item_pago.lb_icono_pago.Text = "🍺";
                //Se comprueban los extras
                if (infoProducto.Length > 2)
                {
                    item_pago.lbl_extras.Text += infoProducto[2] + " ";
                }
                if (infoProducto.Length > 3)
                {
                    item_pago.lbl_extras.Text += infoProducto[3] + " ";
                }
                flowLayout.Controls.Add(item_pago);

            }

        }
        // Método que puebla el panel con los elementos de la lista de pedidos relacionados con Hamburguesa instanciando un Item_pago
        //Funciona igual que el metodo de populateItemNuggets

        public static void populateItemsHamburguesa(Dictionary<string, int> listadoPedidos, FlowLayoutPanel flowLayout)
        {
            foreach (string nombreProducto in listadoPedidos.Keys.Where(p => p.StartsWith("Hamburguesa")))
            {
                int cantidad = listadoPedidos[nombreProducto];
                string[] infoProducto = nombreProducto.Split(':');

                Item_pago item_pago = new Item_pago();
                item_pago.Size = new Size(400, 75);
                item_pago.lbl_nombre_pago.Text = infoProducto[0];
                item_pago.lbl_cantidad_pago.Text = cantidad.ToString();
                item_pago.lbl_precio_pago.Text = double.Parse (infoProducto[1]).ToString("F2");
                item_pago.lb_icono_pago.Text = "🍔";
                //Se comprueban los extras
                if (infoProducto.Length > 2)
                {
                    item_pago.lbl_extras.Text += infoProducto[2] +  " ";
                }
                if (infoProducto.Length > 3)
                {
                    item_pago.lbl_extras.Text += infoProducto[3] + " ";
                }
                flowLayout.Controls.Add(item_pago); 

            }
     
        }
        //Método que cierra el ticket clickando a la X
        private void pb_close_form2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que se ejecuta cuando se clicka al botón de pago
        private void v_Click(object sender, EventArgs e)
        {
            this.Close();
            //Se guardan los elementos en el txt
            GuardarDiccionarioEnArchivo();
            MessageBox.Show("Pago realizado correctamente\n\n 🍔💪 ¡Disfruta de tu pedido! 🍟💪", "Compra realizada");
            formdos.Close();
            formuno.Close();
        }
        //Método que guarda en un archivo de texto todos los elementos del Dicionario
        private void GuardarDiccionarioEnArchivo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("./pedidoAnterior.txt"))
                {
                    foreach (KeyValuePair<string, int> kvp in Cesta.CantidadProductos)
                    {
                        writer.WriteLine($"{kvp.Key}:{kvp.Value}");
                    }
                }
                Console.WriteLine("Pedido guardado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el pedido: {ex.Message}");
            }
        }

    }
}

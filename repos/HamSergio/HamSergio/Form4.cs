using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamSergio
{
    public partial class Form4 : Form
    {
        Form ventana, ventana2;
        public static Dictionary<String, int> PedidoAnterior = new Dictionary<string, int>();

        public Form4(Form1 formuno, Form2 form2)
        {
            InitializeComponent();
            CargarPedidoAnterior();

            Form3.populateItemsHamburguesa(PedidoAnterior, flp_ultimoPedido);
            Form3.populateItemBebida(PedidoAnterior, flp_ultimoPedido);
            Form3.populateItemNuggets(PedidoAnterior, flp_ultimoPedido);
            Form3.populateItemPostre(PedidoAnterior, flp_ultimoPedido);
            Form3.populateItemPatatas(PedidoAnterior, flp_ultimoPedido);

            IsDisabled();
            CalcularTotal();
            ventana = formuno;
            ventana2 = form2;

        }

        //Metodo que habilita el botón de pagar cuando el diccionario esté con datos del 
        private void IsDisabled()
        {
            btn_pagar_UltimoPedido.Enabled = PedidoAnterior.Count() >=1;
        }
        private void CalcularTotal()

        {
            double total = 0;
            foreach (string nombreProducto in PedidoAnterior.Keys)
            {

                int cantidad = PedidoAnterior[nombreProducto];
                string[] infoProducto = nombreProducto.Split(':');
                total = total + (Convert.ToDouble(infoProducto[1]) * cantidad);
            }

            String totalS = total.ToString("0.00");
            lbl_monto_total_ultimoPedido.Text = totalS + "€";

        }

        //Metodo de lee el fichero txt y lo guarda en un Dicionario 
        private void  CargarPedidoAnterior()
        {
            try
            {
                using (StreamReader reader = new StreamReader("./pedidoAnterior.txt"))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Buscar el último delimitador ':'
                        int lastIndex = linea.LastIndexOf(':');
                        if (lastIndex != -1)
                        {
                            // Extrae la clave y el valor de la línea

                            string clave = linea.Substring(0, lastIndex);
                            string valor = linea.Substring(lastIndex + 1);

                            // Agrega la clave y el valor al diccionario PedidoAnterior
                            PedidoAnterior[clave] = Int32.Parse(valor); 
                        }
                        else
                        {
                            Console.WriteLine($"Error en el formato de la línea: {linea}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }
        }
        //Boton de pagar. Muestra un mensaje de confirmación y cierra las ventanas
        private void btn_pagar_UltimoPedido_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Pago realizado correctamente\n\n 🍔💪 ¡Disfruta de tu pedido! 🍟💪", "Compra realizada");
    
            ventana.Close();
            ventana2.Close();
        }
        //Botón de cerrar la ventana, solo cierra el form
        private void pb_close_form2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

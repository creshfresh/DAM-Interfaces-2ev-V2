using HamSergio.Components;
using HamSergio.Detalle;
using HamSergio.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HamSergio
{
    public partial class Form2 : Form
    {
        public static int actualizar_cant_producto;
        Form1 ventana;
        Form3 form3;
        Form4 form4;
        public Form2(Form1 formuno)
        {
            InitializeComponent();
            ventana = formuno;
          }

        //-------------Metodos para cerrar

        // Método para cerrar la ventana cuando se hace click en la X
        private void pb_close_form2_Click(object sender, EventArgs e)
        {
            ventana.Close();
            this.Close();
        }

        //Método para volver all form de inicio
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            ventana.Show();
        }

        // Método que abre el form del ticket
        private void btn_finaliza_Click(object sender, EventArgs e)
        {
            form3 = new Form3(this, ventana);
            form3.ShowDialog();
        }


        //Metodo para iniciar todos los valores de las miniaturas con la info de cada producto
        //Recibe un id y un item_horizontal
        private void llenarDatos(int id, UserControl item)
        {
            switch (id)
            {
                case 1:

                    item_bacon2.lbl_descripcion_producto.Text = "Para los que les gusta disfrutar; jugosa hamburguesa de vacuno con bacon ahumado. ";
                    item_bacon2.lbl_nombre_producto.Text = "BACON";
                    item_bacon2.lbl_precio.Text = "2,50 €";
                    item_bacon2.pictureBox1.Image = Image.FromFile("Resources\\bacon-cuadrado.jpg");
                    item_bacon2.id = 1;

                    break;
                case 2:
                    item_simple2.lbl_descripcion_producto.Text = "Jugoso filete de carne de res, sazonado y cocido a la parrilla, entre dos panes suaves. ";
                    item_simple2.lbl_nombre_producto.Text = "SIMPLE";
                    item_simple2.lbl_precio.Text = "1,00 €";
                    item_simple2.pictureBox1.Image = Image.FromFile("Resources\\simple._cuadrado.jpg");
                    item_simple2.id = 2;
                    break;
                case 3:
                    item_muerte2.lbl_descripcion_producto.Text = "La hamburguesa \"Muerte\" combina el fua de pato para una experiencia inigualable. ";
                    item_muerte2.lbl_nombre_producto.Text = "MUERTE";
                    item_muerte2.lbl_precio.Text = "4,70 €";
                    item_muerte2.pictureBox1.Image = Image.FromFile("Resources\\muerte_cuadrado.jpg");
                    item_muerte2.id = 3;
                    break;
                case 4:
                    item_completa2.lbl_descripcion_producto.Text = "Tu hamburguesa de siempre ahora con huevo y extra de queso. ¡Disfruta de lo bueno! ";
                    item_completa2.lbl_nombre_producto.Text = "COMPLETA";
                    item_completa2.lbl_precio.Text = "2,00 €";
                    item_completa2.pictureBox1.Image = Image.FromFile("Resources\\completa_cuadrado.jpg");
                    item_completa2.id = 4;
                    break;
                case 5:

                    item_patata_peq2.lbl_descripcion_producto.Text = "Deliciosas patatas al punto de sal, tamaño pequeño. ";
                    item_patata_peq2.lbl_nombre_producto.Text = "PATATAS PEQUEÑAS";
                    item_patata_peq2.pictureBox1.Image = Image.FromFile("Resources\\potatoes_peq_cuadrado.jpg");
                    item_patata_peq2.lbl_precio.Text = "1,00 €";
                    item_patata_peq2.id = 5;
                    break;
                case 6:
                    item_patata_grande2.lbl_descripcion_producto.Text = "Deliciosas patatas al punto de sal, tamaño grande. ";
                    item_patata_grande2.lbl_nombre_producto.Text = "PATATAS GRANDES";
                    item_patata_grande2.pictureBox1.Image = Image.FromFile("Resources\\potatoes__cuadrado.jpg");
                    item_patata_grande2.lbl_precio.Text = "2,00 €";
                    item_patata_grande2.id = 6;
                    break;
                case 7:
                    item_bebida_peq2.lbl_descripcion_producto.Text = "La bebida más delirante en tamaño pequeño";
                    item_bebida_peq2.lbl_nombre_producto.Text = "BEBIDA PEQUEÑA";
                    item_bebida_peq2.pictureBox1.Image = Image.FromFile("Resources\\bebida_vis_cuadrado.jpg");
                    item_bebida_peq2.lbl_precio.Text = "1,00 €";
                    item_bebida_peq2.id = 7;
                    break;
                case 8:
                    item_bebida_grand2.lbl_descripcion_producto.Text = "La bebida más delirante en tamaño grande";
                    item_bebida_grand2.lbl_nombre_producto.Text = "BEBIDA GRANDE";
                    item_bebida_grand2.pictureBox1.Image = Image.FromFile("Resources\\bebida_cuadrado.jpg");
                    item_bebida_grand2.lbl_precio.Text = "2,00 €";
                    item_bebida_grand2.id = 8;
                    break;
                case 9:
                    item_nuggets2.lbl_descripcion_producto.Text = "Deliciosos nuggets de pollo, ¿te los vas a perder?";
                    item_nuggets2.lbl_nombre_producto.Text = "NUGGETS";
                    item_nuggets2.pictureBox1.Image = Image.FromFile("Resources\\nuggets_cuadrado.jpg");
                    item_nuggets2.lbl_precio.Text = "3,00 €";
                    item_nuggets2.id = 9;
                    break;
                case 10:
                    item_postre2.lbl_descripcion_producto.Text = "Delicioso postre de tortitas ¡Con un toque de plátano! Muuuuy ÑAM.";
                    item_postre2.lbl_nombre_producto.Text = "POSTRE";
                    item_postre2.pictureBox1.Image = Image.FromFile("Resources\\postre_cuadrado_vis.jpg");
                    item_postre2.lbl_precio.Text = "2,00 €";
                    item_postre2.id = 10;
                    break;

            }
        }
        // Metodos para llenar los datos de las Hamburguesas de cada item_horizontal
        private void item_bacon2_Load_1(object sender, EventArgs e) { llenarDatos(1, item_bacon2); }
        private void item_simple2_Load(object sender, EventArgs e) { llenarDatos(2, item_simple2); }
        private void item_muerte2_Load_1(object sender, EventArgs e) { llenarDatos(3, item_muerte2); }
        private void item_completa2_Load_1(object sender, EventArgs e) { llenarDatos(4, item_completa2); }




        //Método para hacer la selección de cada panel con los item_horizontal de cada tipo de producto
        private async void cambiarPanel(Button botonClicado, Panel panelMostrar, String titulo)
        {
            panel_bebidas.Visible = false;
            panel_burgers.Visible = false;
            panel_patatas.Visible = false;
            panel_nuggets.Visible = false;
            panel_postre.Visible = false;
            panelMostrar.Visible = true;
            lb_tittle.Text = titulo;
        }
        //Método para cambiar el panel de hamburguesas y cambiar el titulo de la página
        private async void btn_burger_sidebar_Click(object sender, EventArgs e)
        {
            cambiarPanel(btn_burger_sidebar, panel_burgers, "HAMBURGUESA");
        }

        //Métodos para cambiar de panel, llenar los datos de los productos y cambiar el título de la página
        private void btn_nuggets_sidebar_Click(object sender, EventArgs e)
        {
            llenarDatos(9, item_nuggets2);
            cambiarPanel(btn_nuggets_sidebar, panel_nuggets, "NUGGETS");

        }
   
        private void btn_bebida_sidebar_Click(object sender, EventArgs e)
        {
            llenarDatos(7, item_bebida_peq2); llenarDatos(8, item_bebida_grand2);
            cambiarPanel(btn_bebida_sidebar, panel_bebidas, "BEBIDA");
        }

        private void btn_patatas_sidebar_Click(object sender, EventArgs e)
        {
            llenarDatos(5, item_patata_peq2);
            llenarDatos(6, item_patata_grande2);
            cambiarPanel(btn_patatas_sidebar, panel_patatas, "PATATAS");
        }

        private void btn_postre_sidebar_Click(object sender, EventArgs e)
        {
            llenarDatos(10, item_postre2);
            cambiarPanel(btn_postre_sidebar, panel_postre, "POSTRE");
        }

        // Abrir dialogo del ticket
        private void bt_volverPedir_Click(object sender, EventArgs e)
        {
            form4 = new Form4(ventana,this);
            form4.ShowDialog();
        }

   
    }
}

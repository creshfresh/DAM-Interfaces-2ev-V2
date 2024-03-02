namespace HamSergio
{
    public partial class Form1 : Form
    {
        Form2 form2;

        public Form1()
        {
            InitializeComponent();
            //Para poner el componente con el fondo transparente
            pb_ham_logo.Parent = pb_promo_image;
            pb_ham_logo.ForeColor = Color.Transparent;
            lbl_brand_nombre.BackColor = Color.FromArgb(250, Color.White);

        }

        //Método para cerrar el form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //Método para ir al form2 con los productos.
        //Envia el form actual y lo esconde. Lo envia para poder ser cerrado en el siguiene form
        private void btn_ir_pedido_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Show();
            this.Hide();

        }
        //Método para dar informacion sobre los pasos a seguir
        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ver el menú y pedir clicke sobre el botón <Pide tu hamburguesa>\n" +
                "Los paneles laterales indican el producto que quiera comprar\n" +
                "Para añadir el producto deseado, dele al + \n" +
                "Puede volver a comprar el último pedido con Volver a pedir\n" +
                "Para tramitar el pedido, clique al botón Finalizar pedido ","Info");
        }
    }
}

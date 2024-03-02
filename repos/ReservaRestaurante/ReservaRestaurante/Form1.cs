using IngresoAplicacion;
using System.Collections;

namespace ReservaRestaurante
{
    public partial class Form1 : Form
    {

        public List<String> userNames = new List<String>()
        {
            "alejandro",
            "cresh_sofresh"
        };

        private string username = "alejandro";
        private string password = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        //Declaramos las funciones

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Verificamos los datos
            if(tb_password.Text != "" && tb_username.Text != "")
            {
                if (tb_username.Text == username && tb_password.Text == password)
                {
                    MessageBox.Show("Datos correctos");
                    Form2 vista = new Form2();
                    vista.Show();
                }
                else if (tb_username.Text != username)
                {
                    MessageBox.Show("Usuario incorrecto", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_username.Text = null;
                    tb_password.Text = null;

                }
                else if (tb_password.Text != password)
                {
                    MessageBox.Show("Contraeña incorrecta");
                    tb_password.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Los datos no pueden estar vacíos","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void btn_pista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: alejandro, contraeña: 12345");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 vistaRegistro = new Form3();
            vistaRegistro.Show();
        }
    }
}

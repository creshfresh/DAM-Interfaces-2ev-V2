using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPapeleria
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registro_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Hide();
        }

        private void cb_password_CheckedChanged(object sender, EventArgs e)
        {
            tb_passwordRepeat.PasswordChar = cb_password_repeat.Checked ? '\0' : '*';
        }
        private void cb_password_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_password_reg.PasswordChar = cb_password.Checked ? '\0' : '*';
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            string diractual = tb_user_reg.Text;
            if (tb_user_reg.Text.Length < 3 || tb_password_reg.Text.Length < 5 )

               MessageBox.Show("Username o password no válido");
    
            else
            {
                if (Directory.Exists("data\\" + diractual))
                {
                    MessageBox.Show("Nombre de usuario ya registrado");
                }
                else
                {
                    string dir = tb_user_reg.Text;
                    Directory.CreateDirectory("data\\" + dir);
                    var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                    string encusr = AesCrypt.Encrypt(tb_user_reg.Text);
                    string encpss = AesCrypt.Encrypt(tb_password_reg.Text);

                    sw.WriteLine(encusr);
                    sw.WriteLine(encpss);
                    sw.Close();

                    //Mensaje de confirmación
                    MessageBox.Show("Usuario creado correctamente");
                    this.Close();
                }
                
            }
        }
    }
}

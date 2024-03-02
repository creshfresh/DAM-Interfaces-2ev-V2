using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IngresoAplicacion

{

    public partial class Form3 : Form

    {
        public List<String> userNames = new List<String>()
        {
            "alejandro"
        };

        public List<String> passwords = new List<String>()
        {

        };

        public Form3()
        {
            InitializeComponent();
        }

        private void tb_usernameReg_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_passwordReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_confirmpaswordReg_TextChanged(object sender, EventArgs e)
        {
            if (tb_passwordReg != tb_confirmpaswordReg)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        }

        private void showPasswordReg_CheckedChanged(object sender, EventArgs e)
        {
            tb_confirmpaswordReg.PasswordChar = showPasswordReg.Checked ? '\0' : '*';
            tb_passwordReg.PasswordChar = showPasswordReg.Checked ? '\0' : '*';
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {

            string nuevoUser = tb_usernameReg.Text;

            if (userNames.Contains(nuevoUser))
            {
                MessageBox.Show("Usuario ya existe, prueba con otro");
                tb_usernameReg.Text = null;
            }
            else
            {
                userNames.Add(nuevoUser);
            }
        }
    }
}

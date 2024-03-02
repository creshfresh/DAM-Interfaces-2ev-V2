using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Clases
{
    public class UsuarioAdministrador {
        public int id_usuario { get; set; }
        public string nombreUsuario { get; set;}
        public string password { get; set;}
        public string  rol { get; set; }

        public UsuarioAdministrador (int id_usuario, string nombreUsuario, string password, string rol)
        {
            this.id_usuario = id_usuario;
            this.password = password;
            this.rol = rol;
            this.nombreUsuario = nombreUsuario;
        }
    }
}

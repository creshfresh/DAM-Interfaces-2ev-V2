using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Clases
{
    public class Usuario
    {
        public int id_cliente { get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string username { get; set; }

        public Usuario(int id_cliente, string nombreCompleto , string correo, string telefono, string direccion, string username)
        {
            this.id_cliente = id_cliente;
            this.nombreCompleto = nombreCompleto; 
            this.correo = correo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.username = username;
    
        }

        public Usuario (string username) { this.username = username; }
    }
}

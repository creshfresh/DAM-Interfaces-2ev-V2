using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Clases
{
    public class Articulos
    {

        public int id_articulo {get; set;}
        public int id_categoria { get; set;}
        public string nombre { get; set;}
        public string marca { get; set; }
        public string precio { get; set; }
        public bool existe_venta {  get; set; } 
        public int  id_proveedor { get; set; }



        public Articulos() { }
    }
}

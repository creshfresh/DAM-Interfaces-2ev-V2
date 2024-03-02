using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Clases
{
    public class Pedido
    {
        public int id_pedido { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha_pedido { get; set; }
        public float importe { get; set; }   
      
        public Pedido()
        {

        }
    }
}

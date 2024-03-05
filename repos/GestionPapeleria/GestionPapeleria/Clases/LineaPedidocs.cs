using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Clases
{
    public class LineaPedidocs
    {
        public int id_pedido { get; set; }
        public int id_articulo { get; set; }
        public int cantidad { get; set; }

        public LineaPedidocs( int id_pedido, int id_articulo, int cantidad) { 

            this.id_pedido = id_pedido;
            this.id_articulo = id_articulo;
            this.cantidad = cantidad;
        }
    }
}

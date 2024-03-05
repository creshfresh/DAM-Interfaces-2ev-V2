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

        public List<LineaPedidocs> articulosComprados { get; set; }
        public Pedido()
        {
            this.id_pedido = 0;
            this.id_cliente = 0;
            this.fecha_pedido = DateTime.Now;
            this.importe = 0;
            this.articulosComprados = new List<LineaPedidocs>();
        }

        public void addArticulo(int idArticulo)
        {

        }



    }
}

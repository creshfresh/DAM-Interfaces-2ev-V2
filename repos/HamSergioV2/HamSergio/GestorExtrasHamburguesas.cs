using MyBurguerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamSergio
{    //Clase que añade los extras a la clase Hamburguesa
    internal class GestorHamburguesaExtras
    {
        public Hamburguesa hamburguesa { get; set; }
        
        public bool sinGluten { get; set; }
        public bool sinLactosa { get; set; }

    }
      
}

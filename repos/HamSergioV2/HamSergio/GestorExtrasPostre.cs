using MyBurguerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamSergio
{
    //Clase que añade los extras a la clase Postre
    internal class GestorExtrasPostre
    {
        public Postre postre { get; set; }

        public bool sinPlatano { get; set; }
        public bool conNata { get; set; }
    }
}

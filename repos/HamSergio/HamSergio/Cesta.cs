using HamSergio.Components;
using MyBurguerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamSergio
{
    internal class Cesta

    {

        // Listas para almacenar diferentes tipos de productos

        public static List<Nuggets> Nuggets = new List<Nuggets>();
        public static List<Hamburguesa> Hamburguesas = new List<Hamburguesa>();
        public static List<Bebidas> Bebidas = new List<Bebidas>();
        public static List<Patatas> Patatas = new List<Patatas>();
        public static List<Postre> Postres = new List<Postre>();

        // Listas para gestionar los extras de cada producto
        public static List<GestorExtrasBebidas> gestorBebidas= new List<GestorExtrasBebidas>();
        public static List<GestorExtrasNuggets> gestorNuggets= new List<GestorExtrasNuggets>();
        public static List<GestorExtrasPatatas> gestorPatatas= new List<GestorExtrasPatatas>();
        public static List<GestorExtrasPostre> gestorPostres = new List<GestorExtrasPostre>();
        public static List<GestorHamburguesaExtras> gestorHamburguesas = new List<GestorHamburguesaExtras>();

        // Diccionario para mantener un registro de la cantidad de cada producto en la cesta
        public static Dictionary<String,int> CantidadProductos = new Dictionary<string, int>();


        public static void altaHamburguesa(Hamburguesa Ham)
        {

            Hamburguesas.Add(Ham);
        }
        // Método para agregar una hamburguesa con las opciones de los extras
        // Las opciones están listadas en checkbox por cada detalle de producto
        public static void altaHamburguesa(Hamburguesa Ham, bool sinGluten, bool sinLactosa)
        {
            GestorHamburguesaExtras hamburguesaExtras= new GestorHamburguesaExtras() { };
            hamburguesaExtras.hamburguesa = Ham;
            hamburguesaExtras.sinGluten = sinGluten;
            hamburguesaExtras.sinLactosa = sinLactosa;

            gestorHamburguesas.Add(hamburguesaExtras);

            // Se construye una cadena que representa la hamburguesa y sus extras
            string valorHamburguesa = "";
            switch (hamburguesaExtras.hamburguesa.getPrecio())
            {
                // Se asigna el nombre de la hamburguesa según su precio
                case 1:
                    valorHamburguesa = "Hamburguesa simple";
                    break;
                case 2:
                    valorHamburguesa = "Hamburguesa completa";
                    break;
                case 2.5:
                    valorHamburguesa = "Hamburguesa bacon";
                    break;
                case 4.70:
                    valorHamburguesa = "Hamburguesa Muerte";
                    break;
            }
            //Se comprueban los atributos de las hamburguesas creadas y se añaden a la cadena
            valorHamburguesa = valorHamburguesa + ":" + hamburguesaExtras.hamburguesa.getPrecio();
            if (hamburguesaExtras.sinGluten)
            {
                valorHamburguesa += ":Sin Gluten";

            }
            if (hamburguesaExtras.sinLactosa)
            {
                valorHamburguesa += ":Sin Lactosa";
            }

            // Se actualiza el registro de cantidad de productos con la hamburguesa y sus extras
            if (CantidadProductos.ContainsKey(valorHamburguesa))
            {
                CantidadProductos[valorHamburguesa] = CantidadProductos[valorHamburguesa] + 1;
            }else
            {
                CantidadProductos.Add(valorHamburguesa, 1);
            }

        }

        //Metodo para conseguir el precio de cada hamburguesa de la lista
        public static double PrecioHam()
        {
            double total = 0;
         
            foreach (GestorHamburguesaExtras ham in gestorHamburguesas)
            {
                total = total + ham.hamburguesa.getPrecio();
            }
            return total;

        }
        //Metodo para dar de alta los postres y sus extras. Igual con las hamburguesas
        public static void altaPostre(Postre Pos, bool sinPlatano, bool conNata)
        {
            GestorExtrasPostre postresExtras = new GestorExtrasPostre() { };
            postresExtras.postre = Pos;
            postresExtras.sinPlatano = sinPlatano;
            postresExtras.conNata = conNata;

            gestorPostres.Add(postresExtras);

            //Añadir el postre en el pedido con sus extras
            string valorPostre = "Postre";

            valorPostre = valorPostre + ":" + postresExtras.postre.getPrecio();
            if (postresExtras.sinPlatano)
            {
                valorPostre += ":Sin plátano";

            }
            if (postresExtras.conNata)
            {
                valorPostre += ":Añadir nata";
            }

            if (CantidadProductos.ContainsKey(valorPostre))
            {
                CantidadProductos[valorPostre] = CantidadProductos[valorPostre] + 1;
            }
            else
            {
                CantidadProductos.Add(valorPostre, 1);
            }

        }

        //Conseguir el precio de cada postre de la lista
        public static double PrecioPos()
        {
            double total = 0;
            foreach (GestorExtrasPostre pos in gestorPostres)
            {
                total = total + pos.postre.getPrecio();
            }
            return total;
      
        }

        //Metodo para añadir los nuggets y sus extras. Igual que el metodo de hamburguesas
        public static void altaNugget(Nuggets Nug, bool conQueso)
        {
            GestorExtrasNuggets nuggetsExtras = new GestorExtrasNuggets() { };
            nuggetsExtras. nuggets = Nug;
            nuggetsExtras.conSalsaBarbacoa = conQueso;
          

            gestorNuggets.Add(nuggetsExtras);

            string valorNuggets = "Nuggets";

            valorNuggets = valorNuggets + ":" + nuggetsExtras.nuggets.getPrecio();
            if (nuggetsExtras.conSalsaBarbacoa)
            {
                valorNuggets += ":Con salsa barbacoa";

            }

            if (CantidadProductos.ContainsKey(valorNuggets))
            {
                CantidadProductos[valorNuggets] = CantidadProductos[valorNuggets] + 1;
            }
            else
            {
                CantidadProductos.Add(valorNuggets, 1);
            }
        }
        //Conseguir el precio de los nuggets
        public static double PrecioNug()
        {
            double total = 0;
            foreach (GestorExtrasNuggets nug in gestorNuggets)
            {
                total = total + nug.nuggets.getPrecio();
            }
            return total;
            

        }
        //Metodo para dar de alta a la bebidas y sus extras. De la misma manera que las hamburguesas
        public static void altaBebida(Bebidas beb, bool conPajita)
        {
            GestorExtrasBebidas bebidasExtras = new GestorExtrasBebidas() { };
            bebidasExtras.bebida = beb;
            bebidasExtras.conPajita = conPajita;

            gestorBebidas.Add(bebidasExtras);
            string valorBebida = "";
            switch (bebidasExtras.bebida.getPrecio())
            {
                case 1:
                    valorBebida = "Bebida pequeña";
                    break;
                case 2:
                    valorBebida = "Bebida grande";
                    break;
             
            }
            valorBebida = valorBebida + ":" + bebidasExtras.bebida.getPrecio();
            if (bebidasExtras.conPajita)
            {
                valorBebida += ":Con Pajita";

            }

            if (CantidadProductos.ContainsKey(valorBebida))
            {
                CantidadProductos[valorBebida] = CantidadProductos[valorBebida] + 1;
            }
            else
            {
                CantidadProductos.Add(valorBebida, 1);
            }
        

    }
        //Metodo para conseguir el precio de cada bebida
        public static double PrecioBeb()
        {
            double total = 0;
            foreach (GestorExtrasBebidas beb in gestorBebidas)
            {
                total = total + beb.bebida.getPrecio();
            }
            return total;

        }
        //Metodo para dar de alta a las patatas con y sus extras. Igual que las hambuguesas
        public static void altaPatatas(Patatas pat, bool conQueso)
        {
            GestorExtrasPatatas patatasExtras = new GestorExtrasPatatas() { };
            patatasExtras.patatas = pat;
            patatasExtras.conQueso = conQueso;

            gestorPatatas.Add(patatasExtras);

            //poner la hamburguesa en el pedido con sus extras
            string valorPatatas = "";
            switch (patatasExtras.patatas.getPrecio())
            {
                case 1:
                    valorPatatas = "Patatas pequeña";
                    break;
                case 2:
                    valorPatatas = "Patatas grande";
                    break;

            }
            valorPatatas = valorPatatas + ":" + patatasExtras.patatas.getPrecio();
            if (patatasExtras.conQueso)
            {
                valorPatatas += ":Con Queso";

            }

            if (CantidadProductos.ContainsKey(valorPatatas))
            {
                CantidadProductos[valorPatatas] = CantidadProductos[valorPatatas] + 1;
            }
            else
            {
                CantidadProductos.Add(valorPatatas, 1);
            }
        }
     
        public static double PrecioPat()
        {
            double total = 0;
            foreach (GestorExtrasPatatas pat in gestorPatatas)
            {
                total = total + pat.patatas.getPrecio();
            }
            return total;
        }

    }
}

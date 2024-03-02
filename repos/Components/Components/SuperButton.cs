using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public partial class SuperButton : Button 
    {

        //-> Atributos para redimensionar
        private bool redimiensionar = true;

       
        //-> Getters y setters

        private bool Redimensionar{
            get
            {
                return redimiensionar;
            }set
            {
                redimiensionar=value;
            }
        }

        // -> Cuando el boton entra en el espacio del boton

        protected override void OnMouseEnter(EventArgs e)
        {
            if (redimiensionar)
            {
                this.Size = new System.Drawing.Size(150, 150);

            }
            base.OnMouseEnter(e);
        }



        //public LabelBottonCheck()
        //{
        //    InitializeComponent();
        //}

        //public LabelBottonCheck(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}

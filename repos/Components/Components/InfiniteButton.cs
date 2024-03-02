using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public partial class InfiniteButton : Button
    {
        protected override void OnClick( EventArgs e)
        {
            //Se declara un nueva instancia de Form1 y se asigna a la variable myForm
            var myForm =  new Form1();
            //Se utiliza el metodo show() para mostar la nueva instancia de Form1
            myForm.Show();
               
        }
        //public InfiniteButton()
        //{
        //    InitializeComponent();
        //}

        //public InfiniteButton(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}

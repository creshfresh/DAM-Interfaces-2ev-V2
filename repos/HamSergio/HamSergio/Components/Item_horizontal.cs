using HamSergio.Detalle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HamSergio
{
    public partial class Item_horizontal : UserControl
    {

        public int id;
        Form2 ventana;
        public Item_horizontal( )
        {
            InitializeComponent();
         
        }
       

        public void btn_anyadir_Click(object sender, EventArgs e)
        {
         
            DetalleBurger db = new DetalleBurger();
            DetalleBurgerBacon dbac =  new DetalleBurgerBacon();
            DetalleBurgerCompleta dbcomp =  new DetalleBurgerCompleta();
            DetalleBurgerrMuerte dbmuerte = new DetalleBurgerrMuerte();
            
            DetalleBebidaGrande dbbgrnd = new DetalleBebidaGrande();
            DetalleBebidaPequeñacs dbbpeq= new DetalleBebidaPequeñacs();

            DetallePatatasGrande dpapgrad = new DetallePatatasGrande();
            DetallePatatasPequeñas dpappeq =  new DetallePatatasPequeñas();

            DetalleNuggets dn =  new DetalleNuggets();

            DetallePostrecs dp = new DetallePostrecs();
            switch (id)
            {
                case 1:
                    dbac.Show();
                 break;
                case 2:
                    db.Show();
                break;

                case 3:
                    dbmuerte.Show();
                    break;
                case 4:
                    dbcomp.Show();
                break;
                case 5: 
                    dpappeq.Show();
                break;
                case 6:   
                    dpapgrad.Show();
                break; 
                case 7:
                    dbbpeq.Show();  
                break; 
                case 8:
                    dbbgrnd.Show();
                break; 
                case 9:
                    dn.Show();
                break; 
                case 10:
                    dp.Show();
                break;
            }
        }
    }
            
        
    
}

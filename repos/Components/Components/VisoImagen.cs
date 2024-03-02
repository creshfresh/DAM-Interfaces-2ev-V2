using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public partial class VisoImagen : Panel //Hereda de otro componente existente, Panel
    {
        //Clase de tipo controlador para repesentar imagenes
        PictureBox pictureBox;
        Button button;
        public VisoImagen()
        {
            InitializeComponent();
            pictureBox = new PictureBox(); 
            this.Controls.Add(pictureBox);
        }
        // Esto afecta a como se va a ver al cuadro de herramientas, como unos metados
        // No afecta a su funcionalidad
        [Category("Custom")]
        [Browsable(true)]
        [Description("Set path to image")]
        [Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor), typeof(System.Drawing.Design.UITypeEditor))]
       

        public string ImageFile { set
            {
                Image img = Image.FromFile(value);
                pictureBox.Image = img;
                pictureBox.Size = img.Size;

            } 
        }
        
        public VisoImagen(IContainer container)
        {
           container.Add(this);

           InitializeComponent();
        }
    }
}

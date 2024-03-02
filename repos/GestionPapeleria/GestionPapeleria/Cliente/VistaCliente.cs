using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPapeleria
{
    public partial class VistaCliente : Form
    {
        public VistaCliente()
        {
            InitializeComponent();
        }

        private void bn_login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void close_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //Cosa para que se vea todo al lado
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Brush _textBrush;
            Brush _backBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Active tab with a white background and regular text.
                _textBrush = new SolidBrush(Color.Black);
                _backBrush = new SolidBrush(Color.White);
                g.FillRectangle(_backBrush, _tabBounds);
            }
            else
            {
                // Inactive tab with a gray background and bold text.
                _textBrush = new SolidBrush(Color.Black);
                _backBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
                g.FillRectangle(_backBrush, _tabBounds);
            }

            // Use our own font, bold for inactive, regular for active.
            FontStyle fontStyle = e.State == DrawItemState.Selected ? FontStyle.Bold : FontStyle.Bold;
            Font _tabFont = new Font("Nirmala UI", 14.0f, fontStyle, GraphicsUnit.Pixel);
      
            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, _stringFlags);

            // Dispose of brushes and fonts.
            _textBrush.Dispose();
            _backBrush.Dispose();
            _tabFont.Dispose();

        }
    }
}

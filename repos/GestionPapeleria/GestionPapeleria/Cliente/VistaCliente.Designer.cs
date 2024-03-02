namespace GestionPapeleria
{
    partial class VistaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCliente));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            close_cliente = new PictureBox();
            bn_login = new Button();
            pb_logo_cliente = new PictureBox();
            pnl_topmenu_cliente = new Panel();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_cliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_logo_cliente).BeginInit();
            pnl_topmenu_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(55, 200);
            tabControl1.Location = new Point(-1, 57);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1387, 842);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 9;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(204, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1179, 834);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(134, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1249, 834);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // close_cliente
            // 
            close_cliente.ErrorImage = (Image)resources.GetObject("close_cliente.ErrorImage");
            close_cliente.Image = (Image)resources.GetObject("close_cliente.Image");
            close_cliente.Location = new Point(1345, 12);
            close_cliente.Name = "close_cliente";
            close_cliente.Size = new Size(23, 19);
            close_cliente.SizeMode = PictureBoxSizeMode.Zoom;
            close_cliente.TabIndex = 6;
            close_cliente.TabStop = false;
            close_cliente.Click += close_cliente_Click;
            // 
            // bn_login
            // 
            bn_login.Location = new Point(1228, 12);
            bn_login.Name = "bn_login";
            bn_login.Size = new Size(89, 29);
            bn_login.TabIndex = 5;
            bn_login.Text = "login";
            bn_login.UseVisualStyleBackColor = true;
            bn_login.Click += bn_login_Click;
            // 
            // pb_logo_cliente
            // 
            pb_logo_cliente.Image = (Image)resources.GetObject("pb_logo_cliente.Image");
            pb_logo_cliente.Location = new Point(31, 5);
            pb_logo_cliente.Name = "pb_logo_cliente";
            pb_logo_cliente.Size = new Size(173, 54);
            pb_logo_cliente.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo_cliente.TabIndex = 7;
            pb_logo_cliente.TabStop = false;
            // 
            // pnl_topmenu_cliente
            // 
            pnl_topmenu_cliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_topmenu_cliente.BackColor = Color.FromArgb(155, 170, 201);
            pnl_topmenu_cliente.Controls.Add(pb_logo_cliente);
            pnl_topmenu_cliente.Controls.Add(bn_login);
            pnl_topmenu_cliente.Controls.Add(close_cliente);
            pnl_topmenu_cliente.ForeColor = Color.FromArgb(155, 170, 201);
            pnl_topmenu_cliente.Location = new Point(-1, 0);
            pnl_topmenu_cliente.Name = "pnl_topmenu_cliente";
            pnl_topmenu_cliente.Size = new Size(1387, 59);
            pnl_topmenu_cliente.TabIndex = 8;
            // 
            // VistaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 900);
            Controls.Add(tabControl1);
            Controls.Add(pnl_topmenu_cliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaCliente";
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)close_cliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_logo_cliente).EndInit();
            pnl_topmenu_cliente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox close_cliente;
        private Button bn_login;
        private PictureBox pb_logo_cliente;
        private Panel pnl_topmenu_cliente;
    }
}
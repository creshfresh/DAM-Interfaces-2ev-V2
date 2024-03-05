namespace GestionPapeleria.Componentes
{
    partial class ItemCarrito
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCarrito));
            lbl_nombre_producto = new Label();
            lbl_precio = new Label();
            panel1 = new Panel();
            btn_add = new Button();
            btn_minus = new Button();
            lbl_cantidad = new Label();
            panel2 = new Panel();
            btn_eliminar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombre_producto
            // 
            lbl_nombre_producto.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre_producto.Location = new Point(19, 13);
            lbl_nombre_producto.Name = "lbl_nombre_producto";
            lbl_nombre_producto.Size = new Size(254, 34);
            lbl_nombre_producto.TabIndex = 1;
            lbl_nombre_producto.Text = "Hobonichi Techo Weeks Paper Series: Pale Blue-Gree\r\n";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            lbl_precio.Location = new Point(16, 56);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(70, 23);
            lbl_precio.TabIndex = 4;
            lbl_precio.Text = "50.00 $";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_minus);
            panel1.Controls.Add(lbl_cantidad);
            panel1.Location = new Point(115, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 29);
            panel1.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            btn_add.ForeColor = Color.FromArgb(115, 140, 191);
            btn_add.Location = new Point(82, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(33, 25);
            btn_add.TabIndex = 36;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_minus
            // 
            btn_minus.FlatStyle = FlatStyle.Flat;
            btn_minus.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            btn_minus.ForeColor = Color.FromArgb(115, 140, 191);
            btn_minus.Location = new Point(1, 2);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(33, 25);
            btn_minus.TabIndex = 35;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            lbl_cantidad.Location = new Point(42, 3);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(34, 23);
            lbl_cantidad.TabIndex = 7;
            lbl_cantidad.Text = "1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 154, 111);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 5);
            panel2.TabIndex = 8;
            // 
            // btn_eliminar
            // 
            btn_eliminar.ErrorImage = (Image)resources.GetObject("btn_eliminar.ErrorImage");
            btn_eliminar.Image = Properties.Resources.iliminar;
            btn_eliminar.Location = new Point(245, 62);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(23, 19);
            btn_eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_eliminar.TabIndex = 9;
            btn_eliminar.TabStop = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // ItemCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_eliminar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_nombre_producto);
            Name = "ItemCarrito";
            Size = new Size(280, 95);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbl_nombre_producto;
        public Label lbl_precio;
        public Panel panel1;
        public Label lbl_cantidad;
        public Button btn_add;
        public Button btn_minus;
        public Panel panel2;
        private PictureBox btn_eliminar;
    }
}

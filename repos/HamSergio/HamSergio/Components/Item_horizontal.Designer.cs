namespace HamSergio
{
    partial class Item_horizontal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_horizontal));
            pictureBox1 = new PictureBox();
            lbl_nombre_producto = new Label();
            btn_anyadir = new Button();
            lbl_descripcion_producto = new Label();
            lbl_precio = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbl_nombre_producto
            // 
            lbl_nombre_producto.AutoSize = true;
            lbl_nombre_producto.BackColor = Color.Transparent;
            lbl_nombre_producto.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre_producto.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_nombre_producto.Location = new Point(165, 11);
            lbl_nombre_producto.Name = "lbl_nombre_producto";
            lbl_nombre_producto.Size = new Size(149, 34);
            lbl_nombre_producto.TabIndex = 2;
            lbl_nombre_producto.Text = "Completa";
            // 
            // btn_anyadir
            // 
            btn_anyadir.BackColor = Color.FromArgb(201, 13, 18);
            btn_anyadir.FlatAppearance.BorderSize = 0;
            btn_anyadir.FlatStyle = FlatStyle.Flat;
            btn_anyadir.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_anyadir.ForeColor = Color.FromArgb(224, 224, 224);
            btn_anyadir.Location = new Point(452, 114);
            btn_anyadir.Name = "btn_anyadir";
            btn_anyadir.Size = new Size(30, 28);
            btn_anyadir.TabIndex = 5;
            btn_anyadir.Text = "+";
            btn_anyadir.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_anyadir.UseVisualStyleBackColor = false;
            btn_anyadir.Click += btn_anyadir_Click;
            // 
            // lbl_descripcion_producto
            // 
            lbl_descripcion_producto.Font = new Font("Segoe UI", 9F);
            lbl_descripcion_producto.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_descripcion_producto.Location = new Point(169, 53);
            lbl_descripcion_producto.Name = "lbl_descripcion_producto";
            lbl_descripcion_producto.Size = new Size(321, 50);
            lbl_descripcion_producto.TabIndex = 6;
            lbl_descripcion_producto.Text = "Descripción producto";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_precio.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_precio.Location = new Point(169, 115);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(73, 32);
            lbl_precio.TabIndex = 7;
            lbl_precio.Text = "17 €";
            // 
            // Item_horizontal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl_precio);
            Controls.Add(lbl_descripcion_producto);
            Controls.Add(btn_anyadir);
            Controls.Add(lbl_nombre_producto);
            Controls.Add(pictureBox1);
            Name = "Item_horizontal";
            Size = new Size(500, 162);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label lbl_nombre_producto;
        public Button btn_anyadir;
        public Label lbl_descripcion_producto;
        public Label lbl_precio;
    }
}

namespace HamSergio.Components
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            btn_anyadir = new Button();
            lbl_descripcion_producto = new Label();
            lbl_nombre_producto = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_anyadir
            // 
            btn_anyadir.BackColor = Color.Red;
            btn_anyadir.FlatStyle = FlatStyle.Flat;
            btn_anyadir.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_anyadir.ForeColor = SystemColors.ButtonHighlight;
            btn_anyadir.Location = new Point(18, 46);
            btn_anyadir.Name = "btn_anyadir";
            btn_anyadir.Size = new Size(142, 34);
            btn_anyadir.TabIndex = 4;
            btn_anyadir.Text = "Añadir al carrito";
            btn_anyadir.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_anyadir.UseVisualStyleBackColor = false;
            // 
            // lbl_descripcion_producto
            // 
            lbl_descripcion_producto.AutoSize = true;
            lbl_descripcion_producto.Location = new Point(56, 17);
            lbl_descripcion_producto.Name = "lbl_descripcion_producto";
            lbl_descripcion_producto.Size = new Size(50, 20);
            lbl_descripcion_producto.TabIndex = 3;
            lbl_descripcion_producto.Text = "label3";
            // 
            // lbl_nombre_producto
            // 
            lbl_nombre_producto.AutoSize = true;
            lbl_nombre_producto.BackColor = Color.Transparent;
            lbl_nombre_producto.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre_producto.ForeColor = SystemColors.ControlLight;
            lbl_nombre_producto.Location = new Point(-4, 9);
            lbl_nombre_producto.Name = "lbl_nombre_producto";
            lbl_nombre_producto.Size = new Size(183, 42);
            lbl_nombre_producto.TabIndex = 1;
            lbl_nombre_producto.Text = "Completa";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(lbl_descripcion_producto);
            panel1.Controls.Add(btn_anyadir);
            panel1.Location = new Point(0, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 94);
            panel1.TabIndex = 5;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_nombre_producto);
            Name = "Item";
            Size = new Size(170, 294);
            Load += Item_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_anyadir;
        private Label lbl_descripcion_producto;
        private Label lbl_nombre_producto;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}

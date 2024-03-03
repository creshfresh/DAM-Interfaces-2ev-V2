namespace GestionPapeleria.Componentes
{
    partial class ItemArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemArticulo));
            panel1 = new Panel();
            lbl_precio = new Label();
            btn_comprar = new Button();
            lbl_nombre_art = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_precio);
            panel1.Controls.Add(btn_comprar);
            panel1.Controls.Add(lbl_nombre_art);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 240);
            panel1.TabIndex = 44;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_precio.ForeColor = Color.FromArgb(227, 81, 59);
            lbl_precio.Location = new Point(12, 174);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(62, 20);
            lbl_precio.TabIndex = 47;
            lbl_precio.Text = "Precio €";
            // 
            // btn_comprar
            // 
            btn_comprar.FlatAppearance.BorderSize = 2;
            btn_comprar.FlatStyle = FlatStyle.Flat;
            btn_comprar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_comprar.ForeColor = Color.FromArgb(115, 140, 191);
            btn_comprar.Location = new Point(18, 197);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(190, 28);
            btn_comprar.TabIndex = 46;
            btn_comprar.Text = "COMPRAR";
            btn_comprar.UseVisualStyleBackColor = true;
            // 
            // lbl_nombre_art
            // 
            lbl_nombre_art.AutoSize = true;
            lbl_nombre_art.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre_art.Location = new Point(12, 154);
            lbl_nombre_art.Name = "lbl_nombre_art";
            lbl_nombre_art.Size = new Size(121, 20);
            lbl_nombre_art.TabIndex = 45;
            lbl_nombre_art.Text = "Texto de prueba";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // ItemArticulo
            // 
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Name = "ItemArticulo";
            Size = new Size(225, 240);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lbl_precio;
        public Button btn_comprar;
        public Label lbl_nombre_art;
        public PictureBox pictureBox1;
    }
}

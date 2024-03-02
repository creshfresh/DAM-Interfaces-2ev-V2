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
            btn_buscar_Nombre = new Button();
            lbl_nombre_art = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_buscar_Nombre);
            panel1.Controls.Add(lbl_nombre_art);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 240);
            panel1.TabIndex = 44;
            // 
            // btn_buscar_Nombre
            // 
            btn_buscar_Nombre.FlatAppearance.BorderSize = 2;
            btn_buscar_Nombre.FlatStyle = FlatStyle.Flat;
            btn_buscar_Nombre.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_Nombre.ForeColor = Color.FromArgb(115, 140, 191);
            btn_buscar_Nombre.Location = new Point(18, 197);
            btn_buscar_Nombre.Name = "btn_buscar_Nombre";
            btn_buscar_Nombre.Size = new Size(190, 28);
            btn_buscar_Nombre.TabIndex = 46;
            btn_buscar_Nombre.Text = "COMPRAR";
            btn_buscar_Nombre.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(227, 81, 59);
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 47;
            label2.Text = "Precio €";
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
        public Label label2;
        public Button btn_buscar_Nombre;
        public Label lbl_nombre_art;
        public PictureBox pictureBox1;
    }
}

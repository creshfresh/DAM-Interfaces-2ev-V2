namespace HamSergio.Components
{
    partial class Item_pago
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
            lbl_precio_pago = new Label();
            lbl_nombre_pago = new Label();
            lb_icono_pago = new Label();
            panel1 = new Panel();
            lbl_cantidad_pago = new Label();
            label1 = new Label();
            lbl_extras = new Label();
            SuspendLayout();
            // 
            // lbl_precio_pago
            // 
            lbl_precio_pago.AutoSize = true;
            lbl_precio_pago.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_precio_pago.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_precio_pago.Location = new Point(104, 30);
            lbl_precio_pago.Name = "lbl_precio_pago";
            lbl_precio_pago.Size = new Size(42, 21);
            lbl_precio_pago.TabIndex = 17;
            lbl_precio_pago.Text = "0.50";
            lbl_precio_pago.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_nombre_pago
            // 
            lbl_nombre_pago.AutoSize = true;
            lbl_nombre_pago.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre_pago.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_nombre_pago.Location = new Point(104, 8);
            lbl_nombre_pago.Name = "lbl_nombre_pago";
            lbl_nombre_pago.Size = new Size(140, 18);
            lbl_nombre_pago.TabIndex = 16;
            lbl_nombre_pago.Text = "Nombre producto";
            lbl_nombre_pago.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_icono_pago
            // 
            lb_icono_pago.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_icono_pago.Location = new Point(29, 6);
            lb_icono_pago.Name = "lb_icono_pago";
            lb_icono_pago.Size = new Size(64, 60);
            lb_icono_pago.TabIndex = 18;
            lb_icono_pago.Text = "🍔";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(14, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 4);
            panel1.TabIndex = 19;
            // 
            // lbl_cantidad_pago
            // 
            lbl_cantidad_pago.AutoSize = true;
            lbl_cantidad_pago.BackColor = Color.Transparent;
            lbl_cantidad_pago.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cantidad_pago.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_cantidad_pago.Location = new Point(302, 24);
            lbl_cantidad_pago.Name = "lbl_cantidad_pago";
            lbl_cantidad_pago.Size = new Size(25, 27);
            lbl_cantidad_pago.TabIndex = 20;
            lbl_cantidad_pago.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 22, 23);
            label1.Location = new Point(143, 31);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 21;
            label1.Text = "€";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_extras
            // 
            lbl_extras.AutoSize = true;
            lbl_extras.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_extras.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_extras.Location = new Point(120, 51);
            lbl_extras.Name = "lbl_extras";
            lbl_extras.Size = new Size(0, 17);
            lbl_extras.TabIndex = 22;
            lbl_extras.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Item_pago
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lbl_extras);
            Controls.Add(label1);
            Controls.Add(lbl_cantidad_pago);
            Controls.Add(panel1);
            Controls.Add(lb_icono_pago);
            Controls.Add(lbl_precio_pago);
            Controls.Add(lbl_nombre_pago);
            Name = "Item_pago";
            Size = new Size(376, 81);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl_precio_pago;
        public Label lbl_nombre_pago;
        public Label lb_icono_pago;
        public Panel panel1;
        public Label lbl_cantidad_pago;
        public Label label1;
        public Label lbl_extras;
    }
}

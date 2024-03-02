namespace GestionPapeleria.Componentes
{
    partial class ItemPedidoAntiguo
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
            lbl_pedido_antiguo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lbl_precioTotal = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // lbl_pedido_antiguo
            // 
            lbl_pedido_antiguo.AutoSize = true;
            lbl_pedido_antiguo.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pedido_antiguo.Location = new Point(22, 6);
            lbl_pedido_antiguo.Name = "lbl_pedido_antiguo";
            lbl_pedido_antiguo.Size = new Size(89, 17);
            lbl_pedido_antiguo.TabIndex = 0;
            lbl_pedido_antiguo.Text = "Pedido Num.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 154, 111);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 57);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 2;
            label1.Text = "el dia.....";
            // 
            // lbl_precioTotal
            // 
            lbl_precioTotal.AutoSize = true;
            lbl_precioTotal.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_precioTotal.Location = new Point(179, 17);
            lbl_precioTotal.Name = "lbl_precioTotal";
            lbl_precioTotal.Size = new Size(62, 20);
            lbl_precioTotal.TabIndex = 3;
            lbl_precioTotal.Text = "$ 50.00\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Location = new Point(169, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 57);
            panel2.TabIndex = 2;
            // 
            // ItemPedidoAntiguo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(lbl_precioTotal);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lbl_pedido_antiguo);
            Name = "ItemPedidoAntiguo";
            Size = new Size(252, 52);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_pedido_antiguo;
        private Panel panel1;
        private Label label1;
        private Label lbl_precioTotal;
        private Panel panel2;
    }
}

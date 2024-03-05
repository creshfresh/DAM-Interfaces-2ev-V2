namespace GestionPapeleria.Cliente
{
    partial class VistaCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCarrito));
            close_carrito = new PictureBox();
            lbl_carrito = new Label();
            flp_carrito = new FlowLayoutPanel();
            label1 = new Label();
            btn_pagar = new Button();
            lbl_admin = new Label();
            lbl_total = new Label();
            ((System.ComponentModel.ISupportInitialize)close_carrito).BeginInit();
            SuspendLayout();
            // 
            // close_carrito
            // 
            close_carrito.ErrorImage = (Image)resources.GetObject("close_carrito.ErrorImage");
            close_carrito.Image = (Image)resources.GetObject("close_carrito.Image");
            close_carrito.Location = new Point(325, 12);
            close_carrito.Name = "close_carrito";
            close_carrito.Size = new Size(23, 19);
            close_carrito.SizeMode = PictureBoxSizeMode.Zoom;
            close_carrito.TabIndex = 1;
            close_carrito.TabStop = false;
            close_carrito.Click += close_carrito_Click;
            // 
            // lbl_carrito
            // 
            lbl_carrito.AutoSize = true;
            lbl_carrito.Font = new Font("Cooper Black", 18.2F);
            lbl_carrito.ForeColor = Color.FromArgb(61, 91, 153);
            lbl_carrito.Location = new Point(18, 22);
            lbl_carrito.Name = "lbl_carrito";
            lbl_carrito.Size = new Size(133, 35);
            lbl_carrito.TabIndex = 13;
            lbl_carrito.Text = "Carrito";
            // 
            // flp_carrito
            // 
            flp_carrito.AutoScroll = true;
            flp_carrito.BackColor = SystemColors.ControlLightLight;
            flp_carrito.Location = new Point(18, 79);
            flp_carrito.Name = "flp_carrito";
            flp_carrito.Size = new Size(319, 419);
            flp_carrito.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(232, 154, 111);
            label1.Location = new Point(83, 639);
            label1.Name = "label1";
            label1.Size = new Size(193, 12);
            label1.TabIndex = 16;
            label1.Text = "Escriba y pliegue 2024 derechos reservados";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_pagar
            // 
            btn_pagar.BackColor = Color.FromArgb(115, 140, 191);
            btn_pagar.FlatStyle = FlatStyle.Flat;
            btn_pagar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_pagar.ForeColor = SystemColors.ButtonFace;
            btn_pagar.Location = new Point(18, 577);
            btn_pagar.Name = "btn_pagar";
            btn_pagar.Size = new Size(321, 48);
            btn_pagar.TabIndex = 17;
            btn_pagar.Text = "PAGAR";
            btn_pagar.UseVisualStyleBackColor = false;
            btn_pagar.Click += btn_pagar_Click;
            // 
            // lbl_admin
            // 
            lbl_admin.AutoSize = true;
            lbl_admin.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_admin.ForeColor = Color.FromArgb(115, 140, 191);
            lbl_admin.Location = new Point(18, 541);
            lbl_admin.Name = "lbl_admin";
            lbl_admin.Size = new Size(51, 17);
            lbl_admin.TabIndex = 18;
            lbl_admin.Text = "TOTAL:";
            lbl_admin.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_total
            // 
            lbl_total.Font = new Font("Cooper Black", 18.2F);
            lbl_total.ForeColor = Color.FromArgb(61, 91, 153);
            lbl_total.Location = new Point(172, 530);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(167, 35);
            lbl_total.TabIndex = 19;
            lbl_total.Text = "$";
            lbl_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VistaCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(360, 683);
            Controls.Add(lbl_total);
            Controls.Add(lbl_admin);
            Controls.Add(btn_pagar);
            Controls.Add(label1);
            Controls.Add(flp_carrito);
            Controls.Add(lbl_carrito);
            Controls.Add(close_carrito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaCarrito";
            ((System.ComponentModel.ISupportInitialize)close_carrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox close_carrito;
        public Label lbl_carrito;
        public FlowLayoutPanel flp_carrito;
        public Label label1;
        public Button btn_pagar;
        public Label lbl_admin;
        public Label lbl_total;
    }
}
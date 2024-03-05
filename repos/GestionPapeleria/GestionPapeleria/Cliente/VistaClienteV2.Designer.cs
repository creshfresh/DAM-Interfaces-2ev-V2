namespace GestionPapeleria.Cliente
{
    partial class VistaClienteV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaClienteV2));
            pnl_topmenu_clientev2 = new Panel();
            btn_carrito = new Button();
            pb_logo_cliente = new PictureBox();
            bn_login_v2 = new Button();
            close_cliente_v2 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label6 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            pnl_sinlogin = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btn_login_admin = new Button();
            pnl_anitguosped = new Panel();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pb_nopedidoAntiguo = new PictureBox();
            pnl_topmenu_clientev2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_cliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_cliente_v2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnl_sinlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_anitguosped.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_nopedidoAntiguo).BeginInit();
            SuspendLayout();
            // 
            // pnl_topmenu_clientev2
            // 
            pnl_topmenu_clientev2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_topmenu_clientev2.BackColor = Color.FromArgb(155, 170, 201);
            pnl_topmenu_clientev2.Controls.Add(btn_carrito);
            pnl_topmenu_clientev2.Controls.Add(pb_logo_cliente);
            pnl_topmenu_clientev2.Controls.Add(bn_login_v2);
            pnl_topmenu_clientev2.Controls.Add(close_cliente_v2);
            pnl_topmenu_clientev2.ForeColor = Color.FromArgb(155, 170, 201);
            pnl_topmenu_clientev2.Location = new Point(-2, -1);
            pnl_topmenu_clientev2.Name = "pnl_topmenu_clientev2";
            pnl_topmenu_clientev2.Size = new Size(1497, 59);
            pnl_topmenu_clientev2.TabIndex = 9;
            // 
            // btn_carrito
            // 
            btn_carrito.Location = new Point(1210, 13);
            btn_carrito.Name = "btn_carrito";
            btn_carrito.Size = new Size(100, 29);
            btn_carrito.TabIndex = 11;
            btn_carrito.Text = "Ver carrito";
            btn_carrito.UseVisualStyleBackColor = true;
            btn_carrito.Visible = false;
            btn_carrito.Click += btn_carrito_Click;
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
            // bn_login_v2
            // 
            bn_login_v2.Location = new Point(1316, 13);
            bn_login_v2.Name = "bn_login_v2";
            bn_login_v2.Size = new Size(113, 29);
            bn_login_v2.TabIndex = 5;
            bn_login_v2.Text = "Iniciar sesión";
            bn_login_v2.UseVisualStyleBackColor = true;
            bn_login_v2.Click += bn_login_v2_Click;
            // 
            // close_cliente_v2
            // 
            close_cliente_v2.ErrorImage = (Image)resources.GetObject("close_cliente_v2.ErrorImage");
            close_cliente_v2.Image = (Image)resources.GetObject("close_cliente_v2.Image");
            close_cliente_v2.Location = new Point(1459, 13);
            close_cliente_v2.Name = "close_cliente_v2";
            close_cliente_v2.Size = new Size(23, 19);
            close_cliente_v2.SizeMode = PictureBoxSizeMode.Zoom;
            close_cliente_v2.TabIndex = 6;
            close_cliente_v2.TabStop = false;
            close_cliente_v2.Click += close_cliente_v2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(200, 45);
            tabControl1.Location = new Point(276, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1219, 835);
            tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(flowLayoutPanel1);
            tabPage2.Location = new Point(4, 49);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1211, 782);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "    Articulos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(39, 105);
            label6.Name = "label6";
            label6.Size = new Size(612, 61);
            label6.TabIndex = 13;
            label6.Text = "¡Gracias por visitar escribaypliegue , nuestra tienda de papelería en línea que vende los mejores bolígrafos, papel y materiales de arte de Japón y más allá! \r\n\r\n";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 35.2F);
            label3.ForeColor = Color.FromArgb(235, 140, 52);
            label3.Location = new Point(20, 24);
            label3.Name = "label3";
            label3.Size = new Size(865, 68);
            label3.TabIndex = 10;
            label3.Text = "¡Escribe, sueña, crea, repite!";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(20, 196);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1180, 542);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 11.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 140, 52);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 8;
            label1.Text = "Antiguos Pedidos";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(3, 31);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 8);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // pnl_sinlogin
            // 
            pnl_sinlogin.BackColor = SystemColors.ButtonHighlight;
            pnl_sinlogin.Controls.Add(label2);
            pnl_sinlogin.Controls.Add(pictureBox1);
            pnl_sinlogin.Location = new Point(21, 64);
            pnl_sinlogin.Name = "pnl_sinlogin";
            pnl_sinlogin.Size = new Size(238, 783);
            pnl_sinlogin.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 140, 52);
            label2.Location = new Point(35, 29);
            label2.Name = "label2";
            label2.Size = new Size(163, 35);
            label2.TabIndex = 8;
            label2.Text = "¡Bienvenido!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nologin2;
            pictureBox1.Location = new Point(14, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 597);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_login_admin
            // 
            btn_login_admin.FlatStyle = FlatStyle.Flat;
            btn_login_admin.Font = new Font("Nirmala UI", 7F, FontStyle.Bold);
            btn_login_admin.ForeColor = Color.FromArgb(115, 140, 191);
            btn_login_admin.Location = new Point(12, 853);
            btn_login_admin.Name = "btn_login_admin";
            btn_login_admin.Size = new Size(262, 25);
            btn_login_admin.TabIndex = 34;
            btn_login_admin.Text = "Colaboradores";
            btn_login_admin.UseVisualStyleBackColor = true;
            btn_login_admin.Click += btn_login_admin_Click;
            // 
            // pnl_anitguosped
            // 
            pnl_anitguosped.BackColor = SystemColors.ControlLightLight;
            pnl_anitguosped.Controls.Add(label5);
            pnl_anitguosped.Controls.Add(flowLayoutPanel2);
            pnl_anitguosped.Location = new Point(12, 64);
            pnl_anitguosped.Name = "pnl_anitguosped";
            pnl_anitguosped.Size = new Size(262, 783);
            pnl_anitguosped.TabIndex = 10;
            pnl_anitguosped.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(235, 140, 52);
            label5.Location = new Point(44, 49);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 11;
            label5.Text = "Tus pedidos anteriores";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pb_nopedidoAntiguo);
            flowLayoutPanel2.Location = new Point(0, 91);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(262, 645);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pb_nopedidoAntiguo
            // 
            pb_nopedidoAntiguo.Image = Properties.Resources.sinpedido;
            pb_nopedidoAntiguo.Location = new Point(3, 3);
            pb_nopedidoAntiguo.Name = "pb_nopedidoAntiguo";
            pb_nopedidoAntiguo.Size = new Size(259, 181);
            pb_nopedidoAntiguo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_nopedidoAntiguo.TabIndex = 0;
            pb_nopedidoAntiguo.TabStop = false;
            // 
            // VistaClienteV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 900);
            Controls.Add(btn_login_admin);
            Controls.Add(tabControl1);
            Controls.Add(pnl_topmenu_clientev2);
            Controls.Add(pnl_anitguosped);
            Controls.Add(pnl_sinlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaClienteV2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaClienteV2";
            pnl_topmenu_clientev2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_logo_cliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_cliente_v2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnl_sinlogin.ResumeLayout(false);
            pnl_sinlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_anitguosped.ResumeLayout(false);
            pnl_anitguosped.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_nopedidoAntiguo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_topmenu_clientev2;
        private PictureBox pb_logo_cliente;
        private Button bn_login_v2;
        private PictureBox close_cliente_v2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Componentes.ItemArticulo itemArticulo2;
        private Componentes.ItemArticulo itemArticulo3;
        private Componentes.ItemArticulo itemArticulo4;
        private Componentes.ItemArticulo itemArticulo5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btn_login_admin;
        private Label label5;
        private Label label3;
        private Label label6;
        private static FlowLayoutPanel flowLayoutPanel3;
        public static Button btn_carrito;
        private static FlowLayoutPanel flowLayoutPanel2;
        public static Panel pnl_sinlogin;
        public static Panel pnl_anitguosped;
        public static FlowLayoutPanel flowLayoutPanel1;
        public static PictureBox pb_nopedidoAntiguo;
    }
}
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
            pb_logo_cliente = new PictureBox();
            bn_login_v2 = new Button();
            close_cliente_v2 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            itemArticulo1 = new Componentes.ItemArticulo();
            itemArticulo2 = new Componentes.ItemArticulo();
            itemArticulo3 = new Componentes.ItemArticulo();
            itemArticulo4 = new Componentes.ItemArticulo();
            itemArticulo5 = new Componentes.ItemArticulo();
            itemPedidoAntiguo1 = new Componentes.ItemPedidoAntiguo();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1 = new Panel();
            lbl_noLogueado = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            lbl_frasecool = new Label();
            pictureBox2 = new PictureBox();
            pnl_topmenu_clientev2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_cliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_cliente_v2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnl_topmenu_clientev2
            // 
            pnl_topmenu_clientev2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_topmenu_clientev2.BackColor = Color.FromArgb(155, 170, 201);
            pnl_topmenu_clientev2.Controls.Add(label3);
            pnl_topmenu_clientev2.Controls.Add(pb_logo_cliente);
            pnl_topmenu_clientev2.Controls.Add(bn_login_v2);
            pnl_topmenu_clientev2.Controls.Add(close_cliente_v2);
            pnl_topmenu_clientev2.ForeColor = Color.FromArgb(155, 170, 201);
            pnl_topmenu_clientev2.Location = new Point(-2, -1);
            pnl_topmenu_clientev2.Name = "pnl_topmenu_clientev2";
            pnl_topmenu_clientev2.Size = new Size(1497, 59);
            pnl_topmenu_clientev2.TabIndex = 9;
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
            bn_login_v2.Location = new Point(1358, 13);
            bn_login_v2.Name = "bn_login_v2";
            bn_login_v2.Size = new Size(71, 29);
            bn_login_v2.TabIndex = 5;
            bn_login_v2.Text = "login";
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
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(200, 45);
            tabControl1.Location = new Point(276, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1204, 835);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbl_frasecool);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 49);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1196, 782);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "       Inicio ";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel1);
            tabPage2.Location = new Point(4, 49);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1196, 782);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "    Articulos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(itemArticulo1);
            flowLayoutPanel1.Controls.Add(itemArticulo2);
            flowLayoutPanel1.Controls.Add(itemArticulo3);
            flowLayoutPanel1.Controls.Add(itemArticulo4);
            flowLayoutPanel1.Controls.Add(itemArticulo5);
            flowLayoutPanel1.Location = new Point(20, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1160, 714);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // itemArticulo1
            // 
            itemArticulo1.BackColor = SystemColors.ButtonHighlight;
            itemArticulo1.Location = new Point(3, 3);
            itemArticulo1.Name = "itemArticulo1";
            itemArticulo1.Size = new Size(225, 240);
            itemArticulo1.TabIndex = 0;
            // 
            // itemArticulo2
            // 
            itemArticulo2.BackColor = SystemColors.ButtonHighlight;
            itemArticulo2.Location = new Point(234, 3);
            itemArticulo2.Name = "itemArticulo2";
            itemArticulo2.Size = new Size(225, 240);
            itemArticulo2.TabIndex = 1;
            // 
            // itemArticulo3
            // 
            itemArticulo3.BackColor = SystemColors.ButtonHighlight;
            itemArticulo3.Location = new Point(465, 3);
            itemArticulo3.Name = "itemArticulo3";
            itemArticulo3.Size = new Size(225, 240);
            itemArticulo3.TabIndex = 2;
            // 
            // itemArticulo4
            // 
            itemArticulo4.BackColor = SystemColors.ButtonHighlight;
            itemArticulo4.Location = new Point(696, 3);
            itemArticulo4.Name = "itemArticulo4";
            itemArticulo4.Size = new Size(225, 240);
            itemArticulo4.TabIndex = 3;
            // 
            // itemArticulo5
            // 
            itemArticulo5.BackColor = SystemColors.ButtonHighlight;
            itemArticulo5.Location = new Point(927, 3);
            itemArticulo5.Name = "itemArticulo5";
            itemArticulo5.Size = new Size(225, 240);
            itemArticulo5.TabIndex = 4;
            // 
            // itemPedidoAntiguo1
            // 
            itemPedidoAntiguo1.Location = new Point(3, 3);
            itemPedidoAntiguo1.Name = "itemPedidoAntiguo1";
            itemPedidoAntiguo1.Size = new Size(252, 52);
            itemPedidoAntiguo1.TabIndex = 9;
            itemPedidoAntiguo1.Visible = false;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lbl_noLogueado);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 831);
            panel1.TabIndex = 11;
            // 
            // lbl_noLogueado
            // 
            lbl_noLogueado.Anchor = AnchorStyles.None;
            lbl_noLogueado.AutoSize = true;
            lbl_noLogueado.Font = new Font("Nirmala UI", 11.8F, FontStyle.Bold);
            lbl_noLogueado.ForeColor = Color.FromArgb(235, 140, 52);
            lbl_noLogueado.Location = new Point(31, 37);
            lbl_noLogueado.Name = "lbl_noLogueado";
            lbl_noLogueado.Size = new Size(176, 28);
            lbl_noLogueado.TabIndex = 10;
            lbl_noLogueado.Text = "Antiguos Pedidos";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(itemPedidoAntiguo1);
            flowLayoutPanel2.Location = new Point(0, 91);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(256, 740);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 831);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nologin2;
            pictureBox1.Location = new Point(19, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 597);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(235, 140, 52);
            label2.Location = new Point(31, 49);
            label2.Name = "label2";
            label2.Size = new Size(196, 41);
            label2.TabIndex = 8;
            label2.Text = "¡Bienvenido!";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(591, 10);
            label3.Name = "label3";
            label3.Size = new Size(328, 31);
            label3.TabIndex = 10;
            label3.Text = "Encuentra todo lo que buscas";
            // 
            // lbl_frasecool
            // 
            lbl_frasecool.Anchor = AnchorStyles.None;
            lbl_frasecool.AutoSize = true;
            lbl_frasecool.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_frasecool.ForeColor = Color.FromArgb(235, 140, 52);
            lbl_frasecool.Location = new Point(48, 88);
            lbl_frasecool.Name = "lbl_frasecool";
            lbl_frasecool.Size = new Size(590, 41);
            lbl_frasecool.TabIndex = 9;
            lbl_frasecool.Text = "Encuentra la inspiración en cada página. ";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(487, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(709, 538);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // VistaClienteV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 900);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(pnl_topmenu_clientev2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaClienteV2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaClienteV2";
            pnl_topmenu_clientev2.ResumeLayout(false);
            pnl_topmenu_clientev2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo_cliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_cliente_v2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_topmenu_clientev2;
        private PictureBox pb_logo_cliente;
        private Button bn_login_v2;
        private PictureBox close_cliente_v2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Componentes.ItemArticulo itemArticulo1;
        private Componentes.ItemArticulo itemArticulo2;
        private Componentes.ItemArticulo itemArticulo3;
        private Componentes.ItemArticulo itemArticulo4;
        private Componentes.ItemArticulo itemArticulo5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Componentes.ItemPedidoAntiguo itemPedidoAntiguo1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbl_noLogueado;
        private Label label3;
        private PictureBox pictureBox2;
        private Label lbl_frasecool;
    }
}
namespace HamSergio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lbl_brand_nombre = new Label();
            pb_ham_logo = new PictureBox();
            pb_close_icon_form2 = new PictureBox();
            pb_promo_image = new PictureBox();
            btn_ir_pedido = new Button();
            lbl_slogan = new Label();
            lbl_burger = new Label();
            btn_info = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ham_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_close_icon_form2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_promo_image).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_brand_nombre);
            panel1.Controls.Add(pb_ham_logo);
            panel1.Controls.Add(pb_close_icon_form2);
            panel1.Controls.Add(pb_promo_image);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(429, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 560);
            panel1.TabIndex = 0;
            // 
            // lbl_brand_nombre
            // 
            lbl_brand_nombre.AutoSize = true;
            lbl_brand_nombre.BackColor = Color.Transparent;
            lbl_brand_nombre.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_brand_nombre.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_brand_nombre.Location = new Point(41, 492);
            lbl_brand_nombre.Name = "lbl_brand_nombre";
            lbl_brand_nombre.Size = new Size(225, 32);
            lbl_brand_nombre.TabIndex = 4;
            lbl_brand_nombre.Text = "FredFred Burger";
            // 
            // pb_ham_logo
            // 
            pb_ham_logo.BackColor = Color.Transparent;
            pb_ham_logo.Image = (Image)resources.GetObject("pb_ham_logo.Image");
            pb_ham_logo.Location = new Point(234, 369);
            pb_ham_logo.Name = "pb_ham_logo";
            pb_ham_logo.Size = new Size(156, 165);
            pb_ham_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ham_logo.TabIndex = 3;
            pb_ham_logo.TabStop = false;
            // 
            // pb_close_icon_form2
            // 
            pb_close_icon_form2.BackColor = Color.Transparent;
            pb_close_icon_form2.BackgroundImage = Properties.Resources._232227;
            pb_close_icon_form2.ErrorImage = null;
            pb_close_icon_form2.Image = (Image)resources.GetObject("pb_close_icon_form2.Image");
            pb_close_icon_form2.Location = new Point(368, 12);
            pb_close_icon_form2.Name = "pb_close_icon_form2";
            pb_close_icon_form2.Size = new Size(22, 18);
            pb_close_icon_form2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close_icon_form2.TabIndex = 3;
            pb_close_icon_form2.TabStop = false;
            pb_close_icon_form2.Click += pictureBox2_Click;
            // 
            // pb_promo_image
            // 
            pb_promo_image.BorderStyle = BorderStyle.FixedSingle;
            pb_promo_image.Dock = DockStyle.Fill;
            pb_promo_image.Image = (Image)resources.GetObject("pb_promo_image.Image");
            pb_promo_image.Location = new Point(0, 0);
            pb_promo_image.Name = "pb_promo_image";
            pb_promo_image.Size = new Size(402, 560);
            pb_promo_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_promo_image.TabIndex = 0;
            pb_promo_image.TabStop = false;
            // 
            // btn_ir_pedido
            // 
            btn_ir_pedido.BackColor = Color.Transparent;
            btn_ir_pedido.FlatAppearance.BorderColor = Color.FromArgb(11, 11, 11);
            btn_ir_pedido.FlatAppearance.BorderSize = 5;
            btn_ir_pedido.FlatAppearance.MouseDownBackColor = Color.White;
            btn_ir_pedido.FlatStyle = FlatStyle.Flat;
            btn_ir_pedido.Font = new Font("Gill Sans Ultra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ir_pedido.ForeColor = Color.FromArgb(11, 11, 11);
            btn_ir_pedido.Location = new Point(49, 459);
            btn_ir_pedido.Name = "btn_ir_pedido";
            btn_ir_pedido.Size = new Size(317, 65);
            btn_ir_pedido.TabIndex = 1;
            btn_ir_pedido.TabStop = false;
            btn_ir_pedido.Text = "PIDE TU HAMBURGUESA\r\n";
            btn_ir_pedido.UseVisualStyleBackColor = false;
            btn_ir_pedido.Click += btn_ir_pedido_Click;
            // 
            // lbl_slogan
            // 
            lbl_slogan.Anchor = AnchorStyles.Bottom;
            lbl_slogan.AutoEllipsis = true;
            lbl_slogan.BackColor = Color.Transparent;
            lbl_slogan.Font = new Font("Bauhaus 93", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_slogan.ForeColor = Color.FromArgb(239, 239, 239);
            lbl_slogan.Location = new Point(11, 15);
            lbl_slogan.Name = "lbl_slogan";
            lbl_slogan.Size = new Size(389, 233);
            lbl_slogan.TabIndex = 2;
            lbl_slogan.Text = "ES HORA DE PONERSE\r\nMANOS A LA";
            // 
            // lbl_burger
            // 
            lbl_burger.AutoSize = true;
            lbl_burger.BackColor = Color.Transparent;
            lbl_burger.Font = new Font("Bauhaus 93", 61F);
            lbl_burger.ForeColor = Color.FromArgb(239, 239, 239);
            lbl_burger.Location = new Point(3, 248);
            lbl_burger.Name = "lbl_burger";
            lbl_burger.Size = new Size(401, 116);
            lbl_burger.TabIndex = 3;
            lbl_burger.Text = "BURGER";
            // 
            // btn_info
            // 
            btn_info.FlatStyle = FlatStyle.Flat;
            btn_info.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_info.ForeColor = Color.RosyBrown;
            btn_info.Location = new Point(388, 12);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(25, 25);
            btn_info.TabIndex = 4;
            btn_info.Text = "?";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7041435F));
            tableLayoutPanel1.Controls.Add(lbl_burger, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_slogan, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.441864F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.55814F));
            tableLayoutPanel1.Size = new Size(411, 368);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 13, 18);
            ClientSize = new Size(831, 560);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_info);
            Controls.Add(btn_ir_pedido);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ham_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_close_icon_form2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_promo_image).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pb_promo_image;
        private Button btn_ir_pedido;
        private Label lbl_slogan;
        private PictureBox pb_close_icon_form2;
        private Label lbl_brand_nombre;
        private PictureBox pb_ham_logo;
        private Label lbl_burger;
        private Button btn_info;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

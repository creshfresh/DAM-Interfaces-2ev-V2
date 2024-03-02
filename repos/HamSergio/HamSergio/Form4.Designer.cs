namespace HamSergio
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            labl_num_ultimoPedido = new Label();
            lb_tittle_ultimopedido = new Label();
            pb_close_form2 = new PictureBox();
            flp_ultimoPedido = new FlowLayoutPanel();
            panel1 = new Panel();
            lbl_monto_total_ultimoPedido = new Label();
            lbl_total_ultimoPedido = new Label();
            btn_pagar_UltimoPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_close_form2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(201, 13, 18);
            label1.Location = new Point(44, 55);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 23;
            label1.Text = "Nº";
            // 
            // labl_num_ultimoPedido
            // 
            labl_num_ultimoPedido.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labl_num_ultimoPedido.ForeColor = Color.FromArgb(201, 13, 18);
            labl_num_ultimoPedido.Location = new Point(69, 55);
            labl_num_ultimoPedido.Name = "labl_num_ultimoPedido";
            labl_num_ultimoPedido.Size = new Size(40, 22);
            labl_num_ultimoPedido.TabIndex = 22;
            labl_num_ultimoPedido.Text = "2";
            // 
            // lb_tittle_ultimopedido
            // 
            lb_tittle_ultimopedido.AutoSize = true;
            lb_tittle_ultimopedido.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tittle_ultimopedido.ForeColor = Color.FromArgb(22, 22, 23);
            lb_tittle_ultimopedido.Location = new Point(36, 16);
            lb_tittle_ultimopedido.Name = "lb_tittle_ultimopedido";
            lb_tittle_ultimopedido.Size = new Size(274, 39);
            lb_tittle_ultimopedido.TabIndex = 21;
            lb_tittle_ultimopedido.Text = "ÚLTIMO PEDIDO";
            // 
            // pb_close_form2
            // 
            pb_close_form2.BackColor = Color.Transparent;
            pb_close_form2.ErrorImage = (Image)resources.GetObject("pb_close_form2.ErrorImage");
            pb_close_form2.Image = (Image)resources.GetObject("pb_close_form2.Image");
            pb_close_form2.InitialImage = null;
            pb_close_form2.Location = new Point(390, 12);
            pb_close_form2.Name = "pb_close_form2";
            pb_close_form2.Size = new Size(22, 18);
            pb_close_form2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close_form2.TabIndex = 20;
            pb_close_form2.TabStop = false;
            pb_close_form2.Click += pb_close_form2_Click;
            // 
            // flp_ultimoPedido
            // 
            flp_ultimoPedido.Location = new Point(36, 91);
            flp_ultimoPedido.Name = "flp_ultimoPedido";
            flp_ultimoPedido.Size = new Size(344, 537);
            flp_ultimoPedido.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(12, 657);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 5);
            panel1.TabIndex = 32;
            // 
            // lbl_monto_total_ultimoPedido
            // 
            lbl_monto_total_ultimoPedido.AutoSize = true;
            lbl_monto_total_ultimoPedido.Font = new Font("Bauhaus 93", 30.2F, FontStyle.Bold);
            lbl_monto_total_ultimoPedido.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_monto_total_ultimoPedido.Location = new Point(20, 691);
            lbl_monto_total_ultimoPedido.Name = "lbl_monto_total_ultimoPedido";
            lbl_monto_total_ultimoPedido.Size = new Size(195, 58);
            lbl_monto_total_ultimoPedido.TabIndex = 31;
            lbl_monto_total_ultimoPedido.Text = "15.00$";
            // 
            // lbl_total_ultimoPedido
            // 
            lbl_total_ultimoPedido.AutoSize = true;
            lbl_total_ultimoPedido.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_ultimoPedido.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_total_ultimoPedido.Location = new Point(36, 669);
            lbl_total_ultimoPedido.Name = "lbl_total_ultimoPedido";
            lbl_total_ultimoPedido.Size = new Size(61, 22);
            lbl_total_ultimoPedido.TabIndex = 30;
            lbl_total_ultimoPedido.Text = "Total: ";
            // 
            // btn_pagar_UltimoPedido
            // 
            btn_pagar_UltimoPedido.BackColor = Color.FromArgb(201, 13, 18);
            btn_pagar_UltimoPedido.Enabled = false;
            btn_pagar_UltimoPedido.FlatAppearance.BorderColor = Color.White;
            btn_pagar_UltimoPedido.FlatAppearance.BorderSize = 0;
            btn_pagar_UltimoPedido.FlatStyle = FlatStyle.Flat;
            btn_pagar_UltimoPedido.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pagar_UltimoPedido.ForeColor = Color.FromArgb(239, 239, 239);
            btn_pagar_UltimoPedido.Location = new Point(248, 691);
            btn_pagar_UltimoPedido.Name = "btn_pagar_UltimoPedido";
            btn_pagar_UltimoPedido.Size = new Size(132, 53);
            btn_pagar_UltimoPedido.TabIndex = 29;
            btn_pagar_UltimoPedido.Text = "Pagar  ✔️";
            btn_pagar_UltimoPedido.UseVisualStyleBackColor = false;
            btn_pagar_UltimoPedido.Click += btn_pagar_UltimoPedido_Click;
            // 
            // Form4
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(424, 761);
            Controls.Add(panel1);
            Controls.Add(lbl_monto_total_ultimoPedido);
            Controls.Add(lbl_total_ultimoPedido);
            Controls.Add(btn_pagar_UltimoPedido);
            Controls.Add(flp_ultimoPedido);
            Controls.Add(label1);
            Controls.Add(labl_num_ultimoPedido);
            Controls.Add(lb_tittle_ultimopedido);
            Controls.Add(pb_close_form2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pb_close_form2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labl_num_ultimoPedido;
        private Label lb_tittle_ultimopedido;
        private PictureBox pb_close_form2;
        private FlowLayoutPanel flp_ultimoPedido;
        private Panel panel1;
        private Label lbl_monto_total_ultimoPedido;
        private Label lbl_total_ultimoPedido;
        private Button btn_pagar_UltimoPedido;
    }
}
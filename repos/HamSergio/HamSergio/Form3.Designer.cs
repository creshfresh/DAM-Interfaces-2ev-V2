namespace HamSergio
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pb_close_form2 = new PictureBox();
            v = new Button();
            lb_tittle = new Label();
            lbl_total = new Label();
            lbl_monto_total = new Label();
            panel1 = new Panel();
            labl_num_pedido = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pb_close_form2).BeginInit();
            SuspendLayout();
            // 
            // pb_close_form2
            // 
            pb_close_form2.BackColor = Color.Transparent;
            pb_close_form2.ErrorImage = (Image)resources.GetObject("pb_close_form2.ErrorImage");
            pb_close_form2.Image = (Image)resources.GetObject("pb_close_form2.Image");
            pb_close_form2.InitialImage = null;
            pb_close_form2.Location = new Point(392, 12);
            pb_close_form2.Name = "pb_close_form2";
            pb_close_form2.Size = new Size(22, 18);
            pb_close_form2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close_form2.TabIndex = 6;
            pb_close_form2.TabStop = false;
            pb_close_form2.Click += pb_close_form2_Click;
            // 
            // v
            // 
            v.BackColor = Color.FromArgb(201, 13, 18);
            v.FlatAppearance.BorderColor = Color.White;
            v.FlatAppearance.BorderSize = 0;
            v.FlatStyle = FlatStyle.Flat;
            v.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            v.ForeColor = Color.FromArgb(239, 239, 239);
            v.Location = new Point(221, 680);
            v.Name = "v";
            v.Size = new Size(177, 57);
            v.TabIndex = 11;
            v.Text = "Pagar  ✔️";
            v.UseVisualStyleBackColor = false;
            v.Click += v_Click;
            // 
            // lb_tittle
            // 
            lb_tittle.AutoSize = true;
            lb_tittle.Font = new Font("Bauhaus 93", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tittle.ForeColor = Color.FromArgb(22, 22, 23);
            lb_tittle.Location = new Point(12, 23);
            lb_tittle.Name = "lb_tittle";
            lb_tittle.Size = new Size(249, 50);
            lb_tittle.TabIndex = 12;
            lb_tittle.Text = "TU PEDIDO";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_total.Location = new Point(36, 662);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(61, 22);
            lbl_total.TabIndex = 13;
            lbl_total.Text = "Total: ";
            // 
            // lbl_monto_total
            // 
            lbl_monto_total.AutoSize = true;
            lbl_monto_total.Font = new Font("Bauhaus 93", 30.2F, FontStyle.Bold);
            lbl_monto_total.ForeColor = Color.FromArgb(22, 22, 23);
            lbl_monto_total.Location = new Point(20, 684);
            lbl_monto_total.Name = "lbl_monto_total";
            lbl_monto_total.Size = new Size(195, 58);
            lbl_monto_total.TabIndex = 15;
            lbl_monto_total.Text = "15.00$";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(12, 650);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 5);
            panel1.TabIndex = 16;
            // 
            // labl_num_pedido
            // 
            labl_num_pedido.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labl_num_pedido.ForeColor = Color.FromArgb(201, 13, 18);
            labl_num_pedido.Location = new Point(358, 44);
            labl_num_pedido.Name = "labl_num_pedido";
            labl_num_pedido.Size = new Size(40, 22);
            labl_num_pedido.TabIndex = 18;
            labl_num_pedido.Text = "123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(201, 13, 18);
            label1.Location = new Point(333, 44);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 19;
            label1.Text = "Nº";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel1.Location = new Point(29, 89);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(369, 544);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(424, 761);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(labl_num_pedido);
            Controls.Add(panel1);
            Controls.Add(lbl_monto_total);
            Controls.Add(lbl_total);
            Controls.Add(lb_tittle);
            Controls.Add(v);
            Controls.Add(pb_close_form2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pb_close_form2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_close_form2;
        private Button v;
        private Label lb_tittle;
        private Label lbl_total;
        private Label lbl_monto_total;
        private Panel panel1;
        private Label labl_num_pedido;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
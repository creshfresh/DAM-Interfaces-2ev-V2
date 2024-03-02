namespace HamSergio.Detalle
{
    partial class DetalleNuggets
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
            Label label6;
            Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleNuggets));
            pb_close_detail = new PictureBox();
            pnl_postre_det = new Panel();
            label3 = new Label();
            checkedListBox2 = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_close_detail).BeginInit();
            pnl_postre_det.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(201, 13, 18);
            label6.Location = new Point(450, 235);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 23;
            label6.Text = "Trazas y alérgenos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(201, 13, 18);
            label5.Location = new Point(453, 136);
            label5.Name = "label5";
            label5.Size = new Size(214, 20);
            label5.TabIndex = 22;
            label5.Text = "Especificadiones especiales";
            // 
            // pb_close_detail
            // 
            pb_close_detail.BackColor = Color.Transparent;
            pb_close_detail.ErrorImage = (Image)resources.GetObject("pb_close_detail.ErrorImage");
            pb_close_detail.Image = (Image)resources.GetObject("pb_close_detail.Image");
            pb_close_detail.InitialImage = null;
            pb_close_detail.Location = new Point(1005, 12);
            pb_close_detail.Name = "pb_close_detail";
            pb_close_detail.Size = new Size(22, 18);
            pb_close_detail.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close_detail.TabIndex = 26;
            pb_close_detail.TabStop = false;
            pb_close_detail.Click += pb_close_detail_Click;
            // 
            // pnl_postre_det
            // 
            pnl_postre_det.Controls.Add(label7);
            pnl_postre_det.Controls.Add(label3);
            pnl_postre_det.Controls.Add(label6);
            pnl_postre_det.Controls.Add(label5);
            pnl_postre_det.Controls.Add(checkedListBox2);
            pnl_postre_det.Controls.Add(label1);
            pnl_postre_det.Controls.Add(label2);
            pnl_postre_det.Controls.Add(button1);
            pnl_postre_det.Controls.Add(panel3);
            pnl_postre_det.Controls.Add(label4);
            pnl_postre_det.Controls.Add(pictureBox1);
            pnl_postre_det.Location = new Point(53, 36);
            pnl_postre_det.Name = "pnl_postre_det";
            pnl_postre_det.Size = new Size(959, 387);
            pnl_postre_det.TabIndex = 27;
            // 
            // label3
            // 
            label3.Location = new Point(453, 256);
            label3.Name = "label3";
            label3.Size = new Size(487, 26);
            label3.TabIndex = 24;
            label3.Text = "Trazas de huevo, soja, mostaza, leche, apio y semillas de sésamo.\r\n";
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = SystemColors.Control;
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Añadir salsa barbacoa" });
            checkedListBox2.Location = new Point(456, 163);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(235, 22);
            checkedListBox2.TabIndex = 21;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 22, 23);
            label1.Location = new Point(436, 15);
            label1.Name = "label1";
            label1.Size = new Size(210, 53);
            label1.TabIndex = 8;
            label1.Text = "NUGGETS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 22, 23);
            label2.Location = new Point(446, 339);
            label2.Name = "label2";
            label2.Size = new Size(121, 39);
            label2.TabIndex = 15;
            label2.Text = "3,00 €";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.Continue;
            button1.FlatAppearance.BorderColor = Color.FromArgb(201, 13, 18);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(201, 13, 18);
            button1.Location = new Point(749, 336);
            button1.Name = "button1";
            button1.Size = new Size(195, 47);
            button1.TabIndex = 11;
            button1.Text = "Añadir al pedido \U0001f6d2 ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Location = new Point(433, 316);
            panel3.Name = "panel3";
            panel3.Size = new Size(532, 5);
            panel3.TabIndex = 17;
            // 
            // label4
            // 
            label4.Location = new Point(444, 79);
            label4.Name = "label4";
            label4.Size = new Size(514, 62);
            label4.TabIndex = 1;
            label4.Text = "Hay cosas que nunca fallan, como unos buenos nuggets de pollo empanados con nuestra mezcla única de especias.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(453, 188);
            label7.Name = "label7";
            label7.Size = new Size(487, 20);
            label7.TabIndex = 26;
            label7.Text = "Nota: la salsa barbacoa corre a cuenta de la casa.";
            // 
            // DetalleNuggets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 459);
            Controls.Add(pb_close_detail);
            Controls.Add(pnl_postre_det);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleNuggets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleNuggets";
            ((System.ComponentModel.ISupportInitialize)pb_close_detail).EndInit();
            pnl_postre_det.ResumeLayout(false);
            pnl_postre_det.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pb_close_detail;
        private Panel pnl_postre_det;
        public Label label3;
        public CheckedListBox checkedListBox2;
        public Label label1;
        public Label label2;
        public Button button1;
        public Panel panel3;
        public Label label4;
        public PictureBox pictureBox1;
        public Label label7;
    }
}

namespace HamSergio
{
    partial class DetalleBurger
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
            Label label5;
            Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleBurger));
            pb_close_detail = new PictureBox();
            pnl_simple = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            chk_list_extras = new CheckedListBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_close_detail).BeginInit();
            pnl_simple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(201, 13, 18);
            label5.Location = new Point(452, 145);
            label5.Name = "label5";
            label5.Size = new Size(214, 20);
            label5.TabIndex = 14;
            label5.Text = "Especificadiones especiales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(201, 13, 18);
            label6.Location = new Point(451, 250);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 16;
            label6.Text = "Trazas y alérgenos";
            // 
            // pb_close_detail
            // 
            pb_close_detail.BackColor = Color.Transparent;
            pb_close_detail.ErrorImage = (Image)resources.GetObject("pb_close_detail.ErrorImage");
            pb_close_detail.Image = (Image)resources.GetObject("pb_close_detail.Image");
            pb_close_detail.InitialImage = null;
            pb_close_detail.Location = new Point(1008, 12);
            pb_close_detail.Name = "pb_close_detail";
            pb_close_detail.Size = new Size(22, 18);
            pb_close_detail.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close_detail.TabIndex = 12;
            pb_close_detail.TabStop = false;
            pb_close_detail.Click += pb_close_detail_Click;
            // 
            // pnl_simple
            // 
            pnl_simple.Controls.Add(label1);
            pnl_simple.Controls.Add(label2);
            pnl_simple.Controls.Add(button1);
            pnl_simple.Controls.Add(panel3);
            pnl_simple.Controls.Add(label3);
            pnl_simple.Controls.Add(label4);
            pnl_simple.Controls.Add(label5);
            pnl_simple.Controls.Add(label6);
            pnl_simple.Controls.Add(chk_list_extras);
            pnl_simple.Controls.Add(pictureBox1);
            pnl_simple.Location = new Point(53, 35);
            pnl_simple.Name = "pnl_simple";
            pnl_simple.Size = new Size(959, 387);
            pnl_simple.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 22, 23);
            label1.Location = new Point(436, 15);
            label1.Name = "label1";
            label1.Size = new Size(167, 53);
            label1.TabIndex = 8;
            label1.Text = "SIMPLE";
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
            label2.Text = "1,00 €";
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
            // label3
            // 
            label3.Location = new Point(454, 271);
            label3.Name = "label3";
            label3.Size = new Size(487, 26);
            label3.TabIndex = 18;
            label3.Text = "Trazas de huevo, soja, mostaz , leche y semillas de sésamo.";
            // 
            // label4
            // 
            label4.Location = new Point(444, 79);
            label4.Name = "label4";
            label4.Size = new Size(514, 66);
            label4.TabIndex = 1;
            label4.Text = "Hamburguesa de carne de vacuno, lechuga, tomate y tierno pan.\r\n¡Pruebala junto con unas patatas y bebida!\r\n";
            // 
            // chk_list_extras
            // 
            chk_list_extras.BackColor = SystemColors.Control;
            chk_list_extras.BorderStyle = BorderStyle.None;
            chk_list_extras.FormattingEnabled = true;
            chk_list_extras.Items.AddRange(new object[] { "Sin gluten", "Sin lactosa" });
            chk_list_extras.Location = new Point(455, 172);
            chk_list_extras.Name = "chk_list_extras";
            chk_list_extras.Size = new Size(290, 66);
            chk_list_extras.TabIndex = 0;
            chk_list_extras.SelectedIndexChanged += chk_list_extras_SelectedIndexChanged;
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
            // DetalleBurger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 459);
            Controls.Add(pnl_simple);
            Controls.Add(pb_close_detail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleBurger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pb_close_detail).EndInit();
            pnl_simple.ResumeLayout(false);
            pnl_simple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public PictureBox pb_close_detail;
        private Panel pnl_simple;
        public Label label1;
        public Label label2;
        public Button button1;
        public Panel panel3;
        public Label label3;
        public Label label4;
        public CheckedListBox chk_list_extras;
        public PictureBox pictureBox1;
    }
}
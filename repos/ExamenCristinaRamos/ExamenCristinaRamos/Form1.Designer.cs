namespace ExamenCristinaRamos
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
            components = new System.ComponentModel.Container();
            lbl_ppt = new Label();
            lb_instrucciones = new Label();
            lbl_elige = new Label();
            groupBox1 = new GroupBox();
            rb_Tijera = new RadioButton();
            rb_papel = new RadioButton();
            rb_piedra = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            lb_resultadoText = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lb_choseJugador = new Label();
            label5 = new Label();
            lb_eleige_Maquina = new Label();
            labelJugador = new Label();
            label3 = new Label();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            lblTiempoRestante = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ppt
            // 
            lbl_ppt.AutoSize = true;
            lbl_ppt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ppt.Location = new Point(40, 81);
            lbl_ppt.Name = "lbl_ppt";
            lbl_ppt.Size = new Size(188, 25);
            lbl_ppt.TabIndex = 0;
            lbl_ppt.Text = "Piedra, papel o tijera";
            // 
            // lb_instrucciones
            // 
            lb_instrucciones.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_instrucciones.Location = new Point(248, 48);
            lb_instrucciones.Name = "lb_instrucciones";
            lb_instrucciones.Size = new Size(459, 77);
            lb_instrucciones.TabIndex = 1;
            lb_instrucciones.Text = "Tienes que elegir una de las opciones: piedra, papel o tijera. El PC elegirá su opción y dará el resultado. En 3 segundos, empezará una nueva partida.";
            // 
            // lbl_elige
            // 
            lbl_elige.AutoSize = true;
            lbl_elige.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_elige.Location = new Point(40, 181);
            lbl_elige.Name = "lbl_elige";
            lbl_elige.Size = new Size(65, 25);
            lbl_elige.TabIndex = 2;
            lbl_elige.Text = "¡Elige!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_Tijera);
            groupBox1.Controls.Add(rb_papel);
            groupBox1.Controls.Add(rb_piedra);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(248, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 154);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona";
            // 
            // rb_Tijera
            // 
            rb_Tijera.AutoSize = true;
            rb_Tijera.Location = new Point(367, 59);
            rb_Tijera.Name = "rb_Tijera";
            rb_Tijera.Size = new Size(67, 24);
            rb_Tijera.TabIndex = 3;
            rb_Tijera.TabStop = true;
            rb_Tijera.Text = "Tijera";
            rb_Tijera.UseVisualStyleBackColor = true;
            // 
            // rb_papel
            // 
            rb_papel.AutoSize = true;
            rb_papel.Location = new Point(218, 59);
            rb_papel.Name = "rb_papel";
            rb_papel.Size = new Size(66, 24);
            rb_papel.TabIndex = 2;
            rb_papel.TabStop = true;
            rb_papel.Text = "Papel";
            rb_papel.UseVisualStyleBackColor = true;
            // 
            // rb_piedra
            // 
            rb_piedra.AutoSize = true;
            rb_piedra.Location = new Point(70, 59);
            rb_piedra.Name = "rb_piedra";
            rb_piedra.Size = new Size(72, 24);
            rb_piedra.TabIndex = 1;
            rb_piedra.TabStop = true;
            rb_piedra.Text = "Piedra";
            rb_piedra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(205, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "¡A jugar!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 464);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "Resultado";
            // 
            // lb_resultadoText
            // 
            lb_resultadoText.AutoSize = true;
            lb_resultadoText.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_resultadoText.Location = new Point(59, 505);
            lb_resultadoText.Name = "lb_resultadoText";
            lb_resultadoText.Size = new Size(0, 31);
            lb_resultadoText.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.82787F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.17213F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.Controls.Add(lb_choseJugador, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(lb_eleige_Maquina, 0, 1);
            tableLayoutPanel1.Controls.Add(labelJugador, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(59, 325);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(715, 113);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // lb_choseJugador
            // 
            lb_choseJugador.Anchor = AnchorStyles.None;
            lb_choseJugador.AutoSize = true;
            lb_choseJugador.Location = new Point(601, 74);
            lb_choseJugador.Name = "lb_choseJugador";
            lb_choseJugador.Size = new Size(0, 20);
            lb_choseJugador.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(337, 74);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 9;
            label5.Text = "vs";
            // 
            // lb_eleige_Maquina
            // 
            lb_eleige_Maquina.Anchor = AnchorStyles.None;
            lb_eleige_Maquina.AutoSize = true;
            lb_eleige_Maquina.Location = new Point(104, 74);
            lb_eleige_Maquina.Name = "lb_eleige_Maquina";
            lb_eleige_Maquina.Size = new Size(0, 20);
            lb_eleige_Maquina.TabIndex = 8;
            // 
            // labelJugador
            // 
            labelJugador.Anchor = AnchorStyles.None;
            labelJugador.AutoSize = true;
            labelJugador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJugador.Location = new Point(568, 18);
            labelJugador.Name = "labelJugador";
            labelJugador.Size = new Size(66, 20);
            labelJugador.TabIndex = 2;
            labelJugador.Text = "Jugador";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(336, 18);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 1;
            label3.Text = "vs";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 18);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 0;
            label2.Text = "La Maquina";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTiempoRestante });
            statusStrip1.Location = new Point(0, 581);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(812, 26);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(141, 20);
            lblTiempoRestante.Text = "Siguiente ronda en: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 607);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lb_resultadoText);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(lbl_elige);
            Controls.Add(lb_instrucciones);
            Controls.Add(lbl_ppt);
            Name = "Form1";
            Text = "Piedra, papel o tijera";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ppt;
        private Label lb_instrucciones;
        private Label lbl_elige;
        private GroupBox groupBox1;
        private RadioButton rb_Tijera;
        private RadioButton rb_papel;
        private RadioButton rb_piedra;
        private Button button1;
        private Label label1;
        private Label lb_resultadoText;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelJugador;
        private Label label3;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTiempoRestante;
        private Label lb_choseJugador;
        private Label label5;
        private Label lb_eleige_Maquina;
        private System.Windows.Forms.Timer timer1;
    }
}

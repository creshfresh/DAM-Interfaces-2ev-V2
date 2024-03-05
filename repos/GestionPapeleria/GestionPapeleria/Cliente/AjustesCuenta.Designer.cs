namespace GestionPapeleria.Cliente
{
    partial class AjustesCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustesCuenta));
            close_cliente_ajutes = new PictureBox();
            lbl_login = new Label();
            tb_nombreCompleto = new TextBox();
            lbl_user = new Label();
            panel1 = new Panel();
            btn_guardarDatos = new Button();
            label4 = new Label();
            label3 = new Label();
            tb_correo = new TextBox();
            label2 = new Label();
            tb_telefono = new TextBox();
            lbl_direccion = new Label();
            tb_direccion = new TextBox();
            panel2 = new Panel();
            cb_passworagain = new CheckBox();
            cb_password = new CheckBox();
            btn_guardarnuevapass = new Button();
            label5 = new Label();
            label6 = new Label();
            tb_repitepass = new TextBox();
            label7 = new Label();
            tb_pass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)close_cliente_ajutes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // close_cliente_ajutes
            // 
            close_cliente_ajutes.ErrorImage = (Image)resources.GetObject("close_cliente_ajutes.ErrorImage");
            close_cliente_ajutes.Image = (Image)resources.GetObject("close_cliente_ajutes.Image");
            close_cliente_ajutes.Location = new Point(668, 12);
            close_cliente_ajutes.Name = "close_cliente_ajutes";
            close_cliente_ajutes.Size = new Size(23, 19);
            close_cliente_ajutes.SizeMode = PictureBoxSizeMode.Zoom;
            close_cliente_ajutes.TabIndex = 7;
            close_cliente_ajutes.TabStop = false;
            close_cliente_ajutes.Click += close_cliente_ajutes_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Cooper Black", 15.2F);
            lbl_login.ForeColor = Color.White;
            lbl_login.Location = new Point(35, 28);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(203, 30);
            lbl_login.TabIndex = 9;
            lbl_login.Text = "Configuración";
            // 
            // tb_nombreCompleto
            // 
            tb_nombreCompleto.BackColor = SystemColors.Control;
            tb_nombreCompleto.BorderStyle = BorderStyle.None;
            tb_nombreCompleto.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nombreCompleto.Location = new Point(28, 82);
            tb_nombreCompleto.Margin = new Padding(10);
            tb_nombreCompleto.Multiline = true;
            tb_nombreCompleto.Name = "tb_nombreCompleto";
            tb_nombreCompleto.Size = new Size(566, 39);
            tb_nombreCompleto.TabIndex = 18;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.ForeColor = SystemColors.ActiveBorder;
            lbl_user.Location = new Point(28, 52);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(139, 20);
            lbl_user.TabIndex = 17;
            lbl_user.Text = "Nombre Completo";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btn_guardarDatos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_correo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_telefono);
            panel1.Controls.Add(lbl_direccion);
            panel1.Controls.Add(tb_direccion);
            panel1.Controls.Add(lbl_user);
            panel1.Controls.Add(tb_nombreCompleto);
            panel1.Location = new Point(35, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 363);
            panel1.TabIndex = 19;
            // 
            // btn_guardarDatos
            // 
            btn_guardarDatos.BackColor = Color.FromArgb(115, 140, 191);
            btn_guardarDatos.FlatStyle = FlatStyle.Flat;
            btn_guardarDatos.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_guardarDatos.ForeColor = SystemColors.ButtonFace;
            btn_guardarDatos.Location = new Point(425, 302);
            btn_guardarDatos.Name = "btn_guardarDatos";
            btn_guardarDatos.Size = new Size(169, 40);
            btn_guardarDatos.TabIndex = 26;
            btn_guardarDatos.Text = "GUARDAR";
            btn_guardarDatos.UseVisualStyleBackColor = false;
            btn_guardarDatos.Click += btn_guardarDatos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(235, 140, 52);
            label4.Location = new Point(28, 15);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 25;
            label4.Text = "Datos básicos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(330, 209);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 23;
            label3.Text = "Correo";
            // 
            // tb_correo
            // 
            tb_correo.BackColor = SystemColors.Control;
            tb_correo.BorderStyle = BorderStyle.None;
            tb_correo.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_correo.Location = new Point(330, 239);
            tb_correo.Margin = new Padding(10);
            tb_correo.Multiline = true;
            tb_correo.Name = "tb_correo";
            tb_correo.Size = new Size(264, 39);
            tb_correo.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(28, 209);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 21;
            label2.Text = "Teléfono\r\n";
            // 
            // tb_telefono
            // 
            tb_telefono.BackColor = SystemColors.Control;
            tb_telefono.BorderStyle = BorderStyle.None;
            tb_telefono.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_telefono.Location = new Point(28, 239);
            tb_telefono.Margin = new Padding(10);
            tb_telefono.Multiline = true;
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Size = new Size(272, 39);
            tb_telefono.TabIndex = 22;
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_direccion.ForeColor = SystemColors.ActiveBorder;
            lbl_direccion.Location = new Point(28, 130);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(137, 20);
            lbl_direccion.TabIndex = 19;
            lbl_direccion.Text = "Dirección de envío";
            // 
            // tb_direccion
            // 
            tb_direccion.BackColor = SystemColors.Control;
            tb_direccion.BorderStyle = BorderStyle.None;
            tb_direccion.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_direccion.Location = new Point(28, 160);
            tb_direccion.Margin = new Padding(10);
            tb_direccion.Multiline = true;
            tb_direccion.Name = "tb_direccion";
            tb_direccion.Size = new Size(566, 39);
            tb_direccion.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(cb_passworagain);
            panel2.Controls.Add(cb_password);
            panel2.Controls.Add(btn_guardarnuevapass);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(tb_repitepass);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tb_pass);
            panel2.Location = new Point(35, 465);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 239);
            panel2.TabIndex = 20;
            // 
            // cb_passworagain
            // 
            cb_passworagain.AutoSize = true;
            cb_passworagain.FlatStyle = FlatStyle.Flat;
            cb_passworagain.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_passworagain.ForeColor = SystemColors.ActiveBorder;
            cb_passworagain.Location = new Point(461, 138);
            cb_passworagain.Name = "cb_passworagain";
            cb_passworagain.Size = new Size(133, 21);
            cb_passworagain.TabIndex = 28;
            cb_passworagain.Text = "Mostrar contraseña";
            cb_passworagain.UseVisualStyleBackColor = true;
            cb_passworagain.CheckedChanged += cb_passworagain_CheckedChanged;
            // 
            // cb_password
            // 
            cb_password.AutoSize = true;
            cb_password.FlatStyle = FlatStyle.Flat;
            cb_password.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_password.ForeColor = SystemColors.ActiveBorder;
            cb_password.Location = new Point(167, 138);
            cb_password.Name = "cb_password";
            cb_password.Size = new Size(133, 21);
            cb_password.TabIndex = 27;
            cb_password.Text = "Mostrar contraseña";
            cb_password.UseVisualStyleBackColor = true;
            cb_password.CheckedChanged += cb_password_CheckedChanged;
            // 
            // btn_guardarnuevapass
            // 
            btn_guardarnuevapass.BackColor = Color.FromArgb(115, 140, 191);
            btn_guardarnuevapass.FlatStyle = FlatStyle.Flat;
            btn_guardarnuevapass.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_guardarnuevapass.ForeColor = SystemColors.ButtonFace;
            btn_guardarnuevapass.Location = new Point(425, 176);
            btn_guardarnuevapass.Name = "btn_guardarnuevapass";
            btn_guardarnuevapass.Size = new Size(169, 40);
            btn_guardarnuevapass.TabIndex = 26;
            btn_guardarnuevapass.Text = "GUARDAR";
            btn_guardarnuevapass.UseVisualStyleBackColor = false;
            btn_guardarnuevapass.Click += btn_guardarnuevapass_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(235, 140, 52);
            label5.Location = new Point(28, 23);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 25;
            label5.Text = "Cambio contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveBorder;
            label6.Location = new Point(330, 65);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 23;
            label6.Text = "Repite la contraseña";
            label6.Click += label6_Click;
            // 
            // tb_repitepass
            // 
            tb_repitepass.BackColor = SystemColors.Control;
            tb_repitepass.BorderStyle = BorderStyle.None;
            tb_repitepass.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_repitepass.Location = new Point(330, 95);
            tb_repitepass.Margin = new Padding(10);
            tb_repitepass.Multiline = true;
            tb_repitepass.Name = "tb_repitepass";
            tb_repitepass.PasswordChar = '*';
            tb_repitepass.Size = new Size(264, 39);
            tb_repitepass.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveBorder;
            label7.Location = new Point(28, 65);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 21;
            label7.Text = "Nueva contraseña";
            // 
            // tb_pass
            // 
            tb_pass.BackColor = SystemColors.Control;
            tb_pass.BorderStyle = BorderStyle.None;
            tb_pass.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pass.Location = new Point(28, 95);
            tb_pass.Margin = new Padding(10);
            tb_pass.Multiline = true;
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(272, 39);
            tb_pass.TabIndex = 22;
            // 
            // AjustesCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 170, 201);
            ClientSize = new Size(713, 756);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_login);
            Controls.Add(close_cliente_ajutes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjustesCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AjustesCuenta";
            ((System.ComponentModel.ISupportInitialize)close_cliente_ajutes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox close_cliente_ajutes;
        private Label lbl_login;
        private TextBox tb_nombreCompleto;
        private Label lbl_user;
        private Panel panel1;
        private Label label3;
        private TextBox tb_correo;
        private Label label2;
        private TextBox tb_telefono;
        private Label lbl_direccion;
        private TextBox tb_direccion;
        private Label label4;
        private Button btn_guardarDatos;
        private Panel panel2;
        private Button btn_guardarnuevapass;
        private Label label5;
        private Label label6;
        private TextBox tb_repitepass;
        private Label label7;
        private TextBox tb_pass;
        private CheckBox cb_passworagain;
        private CheckBox cb_password;
    }
}
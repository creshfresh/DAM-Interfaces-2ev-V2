namespace GestionPapeleria
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            tb_password_reg = new TextBox();
            logo = new PictureBox();
            btn_clear = new Button();
            cb_password_repeat = new CheckBox();
            btn_registro = new Button();
            tb_user_reg = new TextBox();
            lbl_password = new Label();
            lbl_user = new Label();
            lbl_login = new Label();
            registro_close = new PictureBox();
            tb_passwordRepeat = new TextBox();
            label2 = new Label();
            cb_password = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registro_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(115, 140, 191);
            label1.Location = new Point(637, 605);
            label1.Name = "label1";
            label1.Size = new Size(193, 12);
            label1.TabIndex = 26;
            label1.Text = "Escriba y pliegue 2024 derechos reservados";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_password_reg
            // 
            tb_password_reg.BackColor = SystemColors.Control;
            tb_password_reg.BorderStyle = BorderStyle.None;
            tb_password_reg.Font = new Font("Calibri", 15F);
            tb_password_reg.Location = new Point(578, 276);
            tb_password_reg.Margin = new Padding(10);
            tb_password_reg.Multiline = true;
            tb_password_reg.Name = "tb_password_reg";
            tb_password_reg.PasswordChar = '*';
            tb_password_reg.Size = new Size(311, 39);
            tb_password_reg.TabIndex = 25;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.ControlLight;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(594, 27);
            logo.Name = "logo";
            logo.Size = new Size(278, 49);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 24;
            logo.TabStop = false;
            // 
            // btn_clear
            // 
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_clear.ForeColor = Color.FromArgb(115, 140, 191);
            btn_clear.Location = new Point(578, 525);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(311, 48);
            btn_clear.TabIndex = 23;
            btn_clear.Text = "¿YA TIENE CUENTA?  INICIAR SESIÓN";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // cb_password_repeat
            // 
            cb_password_repeat.AutoSize = true;
            cb_password_repeat.FlatStyle = FlatStyle.Flat;
            cb_password_repeat.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_password_repeat.ForeColor = SystemColors.ActiveBorder;
            cb_password_repeat.Location = new Point(756, 425);
            cb_password_repeat.Name = "cb_password_repeat";
            cb_password_repeat.Size = new Size(133, 21);
            cb_password_repeat.TabIndex = 22;
            cb_password_repeat.Text = "Mostrar contraseña";
            cb_password_repeat.UseVisualStyleBackColor = true;
            cb_password_repeat.CheckedChanged += cb_password_CheckedChanged;
            // 
            // btn_registro
            // 
            btn_registro.BackColor = Color.FromArgb(115, 140, 191);
            btn_registro.FlatStyle = FlatStyle.Flat;
            btn_registro.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_registro.ForeColor = SystemColors.ButtonFace;
            btn_registro.Location = new Point(578, 471);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(311, 48);
            btn_registro.TabIndex = 21;
            btn_registro.Text = "REGISTRAR";
            btn_registro.UseVisualStyleBackColor = false;
            btn_registro.Click += btn_registro_Click;
            // 
            // tb_user_reg
            // 
            tb_user_reg.BackColor = SystemColors.Control;
            tb_user_reg.BorderStyle = BorderStyle.None;
            tb_user_reg.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user_reg.Location = new Point(578, 194);
            tb_user_reg.Margin = new Padding(10);
            tb_user_reg.Multiline = true;
            tb_user_reg.Name = "tb_user_reg";
            tb_user_reg.Size = new Size(311, 39);
            tb_user_reg.TabIndex = 20;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = SystemColors.ActiveBorder;
            lbl_password.Location = new Point(578, 246);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(88, 20);
            lbl_password.TabIndex = 19;
            lbl_password.Text = "Contraseña";
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.ForeColor = SystemColors.ActiveBorder;
            lbl_user.Location = new Point(578, 164);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(63, 20);
            lbl_user.TabIndex = 18;
            lbl_user.Text = "Usuario";
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.FromArgb(61, 91, 153);
            lbl_login.Location = new Point(602, 100);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(262, 42);
            lbl_login.TabIndex = 17;
            lbl_login.Text = "Crear cuenta";
            // 
            // registro_close
            // 
            registro_close.ErrorImage = (Image)resources.GetObject("registro_close.ErrorImage");
            registro_close.Image = (Image)resources.GetObject("registro_close.Image");
            registro_close.Location = new Point(951, 15);
            registro_close.Name = "registro_close";
            registro_close.Size = new Size(23, 19);
            registro_close.SizeMode = PictureBoxSizeMode.Zoom;
            registro_close.TabIndex = 16;
            registro_close.TabStop = false;
            registro_close.Click += registro_close_Click;
            // 
            // tb_passwordRepeat
            // 
            tb_passwordRepeat.BackColor = SystemColors.Control;
            tb_passwordRepeat.BorderStyle = BorderStyle.None;
            tb_passwordRepeat.Font = new Font("Calibri", 15F);
            tb_passwordRepeat.Location = new Point(578, 379);
            tb_passwordRepeat.Margin = new Padding(10);
            tb_passwordRepeat.Multiline = true;
            tb_passwordRepeat.Name = "tb_passwordRepeat";
            tb_passwordRepeat.PasswordChar = '*';
            tb_passwordRepeat.Size = new Size(311, 39);
            tb_passwordRepeat.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(578, 349);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 27;
            label2.Text = "Repita la contraseña";
            // 
            // cb_password
            // 
            cb_password.AutoSize = true;
            cb_password.FlatStyle = FlatStyle.Flat;
            cb_password.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_password.ForeColor = SystemColors.ActiveBorder;
            cb_password.Location = new Point(756, 325);
            cb_password.Name = "cb_password";
            cb_password.Size = new Size(133, 21);
            cb_password.TabIndex = 29;
            cb_password.Text = "Mostrar contraseña";
            cb_password.UseVisualStyleBackColor = true;
            cb_password.CheckedChanged += cb_password_CheckedChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 654);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(989, 643);
            Controls.Add(pictureBox1);
            Controls.Add(cb_password);
            Controls.Add(tb_passwordRepeat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password_reg);
            Controls.Add(logo);
            Controls.Add(btn_clear);
            Controls.Add(cb_password_repeat);
            Controls.Add(btn_registro);
            Controls.Add(tb_user_reg);
            Controls.Add(lbl_password);
            Controls.Add(lbl_user);
            Controls.Add(lbl_login);
            Controls.Add(registro_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regristo";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)registro_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_password_reg;
        private PictureBox logo;
        private Button btn_clear;
        private CheckBox cb_password_repeat;
        private Button btn_registro;
        private TextBox tb_user_reg;
        private Label lbl_password;
        private Label lbl_user;
        private Label lbl_login;
        private PictureBox registro_close;
        private TextBox tb_passwordRepeat;
        private Label label2;
        private CheckBox cb_password;
        private PictureBox pictureBox1;
    }
}
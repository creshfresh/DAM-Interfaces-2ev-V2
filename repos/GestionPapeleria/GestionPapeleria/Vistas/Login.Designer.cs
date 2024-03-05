namespace GestionPapeleria
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            close = new PictureBox();
            lbl_login = new Label();
            lbl_user = new Label();
            lbl_password = new Label();
            btn_login = new Button();
            cb_password = new CheckBox();
            btn_clear = new Button();
            pictureBox1 = new PictureBox();
            logo = new PictureBox();
            tb_user = new TextBox();
            tb_password = new TextBox();
            label1 = new Label();
            lbl_admin = new Label();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.ErrorImage = (Image)resources.GetObject("close.ErrorImage");
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(954, 12);
            close.Name = "close";
            close.Size = new Size(23, 19);
            close.SizeMode = PictureBoxSizeMode.Zoom;
            close.TabIndex = 0;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.FromArgb(61, 91, 153);
            lbl_login.Location = new Point(600, 153);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(272, 42);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Iniciar Sesión";
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.ForeColor = SystemColors.ActiveBorder;
            lbl_user.Location = new Point(581, 225);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(63, 20);
            lbl_user.TabIndex = 3;
            lbl_user.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = SystemColors.ActiveBorder;
            lbl_password.Location = new Point(581, 306);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(88, 20);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Contraseña";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(115, 140, 191);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(581, 438);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(311, 48);
            btn_login.TabIndex = 7;
            btn_login.Text = "INICIAR SESION";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // cb_password
            // 
            cb_password.AutoSize = true;
            cb_password.FlatStyle = FlatStyle.Flat;
            cb_password.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_password.ForeColor = SystemColors.ActiveBorder;
            cb_password.Location = new Point(755, 388);
            cb_password.Name = "cb_password";
            cb_password.Size = new Size(133, 21);
            cb_password.TabIndex = 9;
            cb_password.Text = "Mostrar contraseña";
            cb_password.UseVisualStyleBackColor = true;
            cb_password.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // btn_clear
            // 
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btn_clear.ForeColor = Color.FromArgb(115, 140, 191);
            btn_clear.Location = new Point(581, 492);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(311, 48);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "¿NO TIENE CUENTA?  REGISTRESE";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 654);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.ControlLight;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(597, 63);
            logo.Name = "logo";
            logo.Size = new Size(278, 49);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 11;
            logo.TabStop = false;
            // 
            // tb_user
            // 
            tb_user.BackColor = SystemColors.Control;
            tb_user.BorderStyle = BorderStyle.None;
            tb_user.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(581, 255);
            tb_user.Margin = new Padding(10);
            tb_user.Multiline = true;
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(311, 39);
            tb_user.TabIndex = 5;
            // 
            // tb_password
            // 
            tb_password.BackColor = SystemColors.Control;
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Calibri", 15F);
            tb_password.Location = new Point(581, 336);
            tb_password.Margin = new Padding(10);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(311, 39);
            tb_password.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(115, 140, 191);
            label1.Location = new Point(640, 578);
            label1.Name = "label1";
            label1.Size = new Size(193, 12);
            label1.TabIndex = 15;
            label1.Text = "Escriba y pliegue 2024 derechos reservados";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_admin
            // 
            lbl_admin.AutoSize = true;
            lbl_admin.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_admin.ForeColor = Color.FromArgb(115, 140, 191);
            lbl_admin.Location = new Point(662, 135);
            lbl_admin.Name = "lbl_admin";
            lbl_admin.Size = new Size(131, 17);
            lbl_admin.TabIndex = 16;
            lbl_admin.Text = "ADMINISTRADORES";
            lbl_admin.TextAlign = ContentAlignment.TopCenter;
            lbl_admin.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(989, 643);
            Controls.Add(lbl_admin);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(pictureBox1);
            Controls.Add(logo);
            Controls.Add(btn_clear);
            Controls.Add(cb_password);
            Controls.Add(btn_login);
            Controls.Add(tb_user);
            Controls.Add(lbl_password);
            Controls.Add(lbl_user);
            Controls.Add(lbl_login);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox close;
        private Label lbl_login;
        private Label lbl_user;
        private Label lbl_password;
        private Button btn_login;
        private CheckBox cb_password;
        private Button btn_clear;
        private PictureBox pictureBox1;
        private PictureBox logo;
        private TextBox tb_user;
        private TextBox tb_password;
        private Label label1;
        private Label lbl_admin;
    }
}
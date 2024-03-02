namespace ReservaRestaurante
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
            tb_username = new TextBox();
            lbl_login = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            showPassword = new CheckBox();
            btn_login = new Button();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            lb_message = new Label();
            lbl_wellcome = new Label();
            pictureBox1 = new PictureBox();
            tb_password = new TextBox();
            btn_pista = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(407, 185);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(288, 27);
            tb_username.TabIndex = 1;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(407, 73);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(216, 41);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login Account";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(407, 162);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(78, 20);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(407, 226);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(73, 20);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password:";
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Location = new Point(561, 297);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(134, 24);
            showPassword.TabIndex = 5;
            showPassword.Text = "Show password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Blue;
            btn_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(407, 340);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(102, 44);
            btn_login.TabIndex = 7;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lb_message);
            panel1.Controls.Add(lbl_wellcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(10, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 521);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(82, 406);
            label2.Name = "label2";
            label2.Size = new Size(181, 22);
            label2.TabIndex = 14;
            label2.Text = "¿Nuevo en el equipo?";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(61, 445);
            button1.Name = "button1";
            button1.Size = new Size(222, 44);
            button1.TabIndex = 13;
            button1.Text = "SIGN IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lb_message
            // 
            lb_message.AutoSize = true;
            lb_message.ForeColor = SystemColors.ControlDark;
            lb_message.Location = new Point(109, 300);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(113, 20);
            lb_message.TabIndex = 11;
            lb_message.Text = "Apruébame, pls";
            // 
            // lbl_wellcome
            // 
            lbl_wellcome.AutoSize = true;
            lbl_wellcome.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_wellcome.ForeColor = SystemColors.ControlLightLight;
            lbl_wellcome.Location = new Point(61, 272);
            lbl_wellcome.Name = "lbl_wellcome";
            lbl_wellcome.Size = new Size(222, 22);
            lbl_wellcome.TabIndex = 1;
            lbl_wellcome.Text = "Employee management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(407, 249);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(288, 27);
            tb_password.TabIndex = 9;
            // 
            // btn_pista
            // 
            btn_pista.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pista.Location = new Point(611, 475);
            btn_pista.Name = "btn_pista";
            btn_pista.Size = new Size(84, 29);
            btn_pista.TabIndex = 11;
            btn_pista.Text = "Recuperar";
            btn_pista.UseVisualStyleBackColor = true;
            btn_pista.Click += btn_pista_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 446);
            label1.Name = "label1";
            label1.Size = new Size(226, 17);
            label1.TabIndex = 12;
            label1.Text = "¿Olvidaste el usuario y/o contraseña?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 570);
            Controls.Add(label1);
            Controls.Add(btn_pista);
            Controls.Add(tb_password);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(showPassword);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_login);
            Controls.Add(tb_username);
            Name = "Form1";
            Text = "Employee Portal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_username;
        private Label lbl_login;
        private Label lbl_username;
        private Label lbl_password;
        private CheckBox showPassword;
        private Button btn_login;
        private Panel panel1;
        private TextBox tb_password;
        private PictureBox pictureBox1;
        private Label lbl_wellcome;
        private Label pista;
        private Label lb_message;
        private Button btn_pista;
        private Label label2;
        private Button button1;
        private Label label1;
    }
}

namespace IngresoAplicacion
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
            tb_passwordReg = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            lb_message = new Label();
            lbl_wellcome = new Label();
            pictureBox1 = new PictureBox();
            btn_signin = new Button();
            showPasswordReg = new CheckBox();
            lbl_password = new Label();
            lbl_username = new Label();
            lbl_signin = new Label();
            tb_usernameReg = new TextBox();
            tb_confirmpaswordReg = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_passwordReg
            // 
            tb_passwordReg.Location = new Point(409, 235);
            tb_passwordReg.Multiline = true;
            tb_passwordReg.Name = "tb_passwordReg";
            tb_passwordReg.PasswordChar = '*';
            tb_passwordReg.Size = new Size(288, 27);
            tb_passwordReg.TabIndex = 20;
            tb_passwordReg.TextChanged += tb_passwordReg_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lb_message);
            panel1.Controls.Add(lbl_wellcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 521);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(70, 407);
            label2.Name = "label2";
            label2.Size = new Size(196, 22);
            label2.TabIndex = 14;
            label2.Text = "¿Ya estás en el equipo?";
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
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
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
            // btn_signin
            // 
            btn_signin.BackColor = Color.Blue;
            btn_signin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signin.ForeColor = SystemColors.ButtonHighlight;
            btn_signin.Location = new Point(409, 397);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(102, 44);
            btn_signin.TabIndex = 18;
            btn_signin.Text = "SIGN IN";
            btn_signin.UseVisualStyleBackColor = false;
            btn_signin.Click += btn_signin_Click;
            // 
            // showPasswordReg
            // 
            showPasswordReg.AutoSize = true;
            showPasswordReg.Location = new Point(563, 357);
            showPasswordReg.Name = "showPasswordReg";
            showPasswordReg.Size = new Size(134, 24);
            showPasswordReg.TabIndex = 17;
            showPasswordReg.Text = "Show password";
            showPasswordReg.UseVisualStyleBackColor = true;
            showPasswordReg.CheckedChanged += showPasswordReg_CheckedChanged;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(409, 212);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(73, 20);
            lbl_password.TabIndex = 16;
            lbl_password.Text = "Password:";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(409, 148);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(78, 20);
            lbl_username.TabIndex = 15;
            lbl_username.Text = "Username:";
            // 
            // lbl_signin
            // 
            lbl_signin.AutoSize = true;
            lbl_signin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signin.Location = new Point(409, 84);
            lbl_signin.Name = "lbl_signin";
            lbl_signin.Size = new Size(112, 41);
            lbl_signin.TabIndex = 13;
            lbl_signin.Text = "Sign in";
            // 
            // tb_usernameReg
            // 
            tb_usernameReg.Location = new Point(409, 171);
            tb_usernameReg.Multiline = true;
            tb_usernameReg.Name = "tb_usernameReg";
            tb_usernameReg.Size = new Size(288, 27);
            tb_usernameReg.TabIndex = 14;
            tb_usernameReg.TextChanged += tb_usernameReg_TextChanged;
            // 
            // tb_confirmpaswordReg
            // 
            tb_confirmpaswordReg.Location = new Point(409, 305);
            tb_confirmpaswordReg.Multiline = true;
            tb_confirmpaswordReg.Name = "tb_confirmpaswordReg";
            tb_confirmpaswordReg.PasswordChar = '*';
            tb_confirmpaswordReg.Size = new Size(288, 27);
            tb_confirmpaswordReg.TabIndex = 22;
            tb_confirmpaswordReg.TextChanged += tb_confirmpaswordReg_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 282);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 21;
            label1.Text = "Confirm Password:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 552);
            Controls.Add(tb_confirmpaswordReg);
            Controls.Add(label1);
            Controls.Add(tb_passwordReg);
            Controls.Add(panel1);
            Controls.Add(btn_signin);
            Controls.Add(showPasswordReg);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_signin);
            Controls.Add(tb_usernameReg);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_passwordReg;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label lb_message;
        private Label lbl_wellcome;
        private PictureBox pictureBox1;
        private Button btn_signin;
        private CheckBox showPasswordReg;
        private Label lbl_password;
        private Label lbl_username;
        private Label lbl_signin;
        private TextBox tb_usernameReg;
        private TextBox tb_confirmpaswordReg;
        private Label label1;
    }
}
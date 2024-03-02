namespace Components
{
    partial class Form1
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
            userControlButton1 = new UserControlButton();
            superButton1 = new SuperButton();
            infiniteButton1 = new InfiniteButton();
            SuspendLayout();
            // 
            // userControlButton1
            // 
            userControlButton1.Location = new Point(30, 54);
            userControlButton1.Name = "userControlButton1";
            userControlButton1.Size = new Size(336, 151);
            userControlButton1.TabIndex = 0;
            // 
            // superButton1
            // 
            superButton1.Location = new Point(50, 185);
            superButton1.Name = "superButton1";
            superButton1.Size = new Size(94, 29);
            superButton1.TabIndex = 1;
            superButton1.Text = "superButton1";
            superButton1.UseVisualStyleBackColor = true;
            // 
            // infiniteButton1
            // 
            infiniteButton1.Location = new Point(50, 275);
            infiniteButton1.Name = "infiniteButton1";
            infiniteButton1.Size = new Size(138, 29);
            infiniteButton1.TabIndex = 2;
            infiniteButton1.Text = "infiniteButton1";
            infiniteButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(infiniteButton1);
            Controls.Add(superButton1);
            Controls.Add(userControlButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControlButton userControlButton1;
        private SuperButton superButton1;
        private InfiniteButton infiniteButton1;
    }
}
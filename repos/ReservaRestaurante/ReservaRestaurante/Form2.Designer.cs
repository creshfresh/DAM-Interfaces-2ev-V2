namespace ReservaRestaurante
{
    partial class Form2
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
            lb_wellcome = new Label();
            SuspendLayout();
            // 
            // lb_wellcome
            // 
            lb_wellcome.AutoSize = true;
            lb_wellcome.Font = new Font("Lucida Sans Unicode", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_wellcome.Location = new Point(50, 49);
            lb_wellcome.Name = "lb_wellcome";
            lb_wellcome.Size = new Size(189, 34);
            lb_wellcome.TabIndex = 0;
            lb_wellcome.Text = "BIENVENIDO:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(lb_wellcome);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_wellcome;
    }
}
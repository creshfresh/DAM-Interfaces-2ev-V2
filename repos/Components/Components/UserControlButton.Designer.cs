namespace Components
{
    partial class UserControlButton
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button = new Button();
            lbl = new Label();
            chBox = new CheckBox();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(24, 56);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 0;
            button.Text = "button1";
            button.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(24, 17);
            lbl.Name = "lbl";
            lbl.Size = new Size(50, 20);
            lbl.TabIndex = 1;
            lbl.Text = "label1";
            // 
            // chBox
            // 
            chBox.AutoSize = true;
            chBox.Location = new Point(146, 61);
            chBox.Name = "chBox";
            chBox.Size = new Size(101, 24);
            chBox.TabIndex = 2;
            chBox.Text = "checkBox1";
            chBox.UseVisualStyleBackColor = true;
            // 
            // UserControlButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chBox);
            Controls.Add(lbl);
            Controls.Add(button);
            Name = "UserControlButton";
            Size = new Size(269, 121);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label lbl;
        private CheckBox chBox;
    }
}

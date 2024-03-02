namespace Informe
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
            data_grid = new DataGridView();
            btn_conect = new Button();
            btn_inform = new Button();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            SuspendLayout();
            // 
            // data_grid
            // 
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(31, 61);
            data_grid.Name = "data_grid";
            data_grid.RowHeadersWidth = 51;
            data_grid.Size = new Size(723, 316);
            data_grid.TabIndex = 0;
            // 
            // btn_conect
            // 
            btn_conect.Location = new Point(31, 12);
            btn_conect.Name = "btn_conect";
            btn_conect.Size = new Size(94, 29);
            btn_conect.TabIndex = 1;
            btn_conect.Text = "Conectar";
            btn_conect.UseVisualStyleBackColor = true;
            btn_conect.Click += btn_conect_Click;
            // 
            // btn_inform
            // 
            btn_inform.Location = new Point(660, 409);
            btn_inform.Name = "btn_inform";
            btn_inform.Size = new Size(94, 29);
            btn_inform.TabIndex = 2;
            btn_inform.Text = "Informe";
            btn_inform.UseVisualStyleBackColor = true;
            btn_inform.Click += btn_inform_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_inform);
            Controls.Add(btn_conect);
            Controls.Add(data_grid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_grid;
        private Button btn_conect;
        private Button btn_inform;
    }
}

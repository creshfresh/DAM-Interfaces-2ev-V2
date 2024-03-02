namespace HamSergio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pb_ham_logo = new PictureBox();
            lb_tittle = new Label();
            pb_close_form2 = new PictureBox();
            panel1 = new Panel();
            btn_finaliza = new Button();
            label6 = new Label();
            btn_burger_sidebar = new Button();
            btn_volver = new Button();
            lbl_frasmolona = new Label();
            panel_burgers = new Panel();
            item_muerte2 = new Item_horizontal();
            item_bacon2 = new Item_horizontal();
            item_completa2 = new Item_horizontal();
            item_simple2 = new Item_horizontal();
            bt_volverPedir = new Button();
            btn_bebida_sidebar = new Button();
            panel_bebidas = new Panel();
            item_bebida_grand2 = new Item_horizontal();
            item_bebida_peq2 = new Item_horizontal();
            panel_nuggets = new Panel();
            item_nuggets2 = new Item_horizontal();
            panel_postre = new Panel();
            item_postre2 = new Item_horizontal();
            btn_nuggets_sidebar = new Button();
            btn_patatas_sidebar = new Button();
            btn_postre_sidebar = new Button();
            panel3 = new Panel();
            panel_patatas = new Panel();
            item_patata_grande2 = new Item_horizontal();
            item_patata_peq2 = new Item_horizontal();
            ((System.ComponentModel.ISupportInitialize)pb_ham_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_close_form2).BeginInit();
            panel1.SuspendLayout();
            panel_burgers.SuspendLayout();
            panel_bebidas.SuspendLayout();
            panel_nuggets.SuspendLayout();
            panel_postre.SuspendLayout();
            panel_patatas.SuspendLayout();
            SuspendLayout();
            // 
            // pb_ham_logo
            // 
            pb_ham_logo.Anchor = AnchorStyles.None;
            pb_ham_logo.BackColor = Color.Transparent;
            pb_ham_logo.Image = Properties.Resources.walking_burger_character_illustration_in_retro_30_s_cartoon_style_perfect_for_t_shirt_design_and_fast_food_logo_vector;
            pb_ham_logo.Location = new Point(38, 17);
            pb_ham_logo.Name = "pb_ham_logo";
            pb_ham_logo.Size = new Size(67, 62);
            pb_ham_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ham_logo.TabIndex = 8;
            pb_ham_logo.TabStop = false;
            // 
            // lb_tittle
            // 
            lb_tittle.AutoSize = true;
            lb_tittle.Font = new Font("Bauhaus 93", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tittle.ForeColor = Color.FromArgb(239, 239, 239);
            lb_tittle.Location = new Point(534, 17);
            lb_tittle.Name = "lb_tittle";
            lb_tittle.Size = new Size(317, 50);
            lb_tittle.TabIndex = 7;
            lb_tittle.Text = "HAMBURGUESA";
            lb_tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb_close_form2
            // 
            pb_close_form2.BackColor = Color.Transparent;
            pb_close_form2.ErrorImage = (Image)resources.GetObject("pb_close_form2.ErrorImage");
            pb_close_form2.Image = (Image)resources.GetObject("pb_close_form2.Image");
            pb_close_form2.InitialImage = null;
            pb_close_form2.Location = new Point(1252, 12);
            pb_close_form2.Name = "pb_close_form2";
            pb_close_form2.Size = new Size(22, 18);
            pb_close_form2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_close_form2.TabIndex = 5;
            pb_close_form2.TabStop = false;
            pb_close_form2.Click += pb_close_form2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 23);
            panel1.Controls.Add(btn_finaliza);
            panel1.Controls.Add(pb_close_form2);
            panel1.Controls.Add(pb_ham_logo);
            panel1.Controls.Add(lb_tittle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 89);
            panel1.TabIndex = 10;
            // 
            // btn_finaliza
            // 
            btn_finaliza.BackColor = Color.FromArgb(201, 13, 18);
            btn_finaliza.FlatAppearance.BorderColor = Color.White;
            btn_finaliza.FlatAppearance.BorderSize = 2;
            btn_finaliza.FlatStyle = FlatStyle.Flat;
            btn_finaliza.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btn_finaliza.ForeColor = Color.FromArgb(239, 239, 239);
            btn_finaliza.Location = new Point(1056, 20);
            btn_finaliza.Name = "btn_finaliza";
            btn_finaliza.Size = new Size(170, 47);
            btn_finaliza.TabIndex = 10;
            btn_finaliza.Text = "\U0001f6d2   Finalizar pedido";
            btn_finaliza.UseVisualStyleBackColor = false;
            btn_finaliza.Click += btn_finaliza_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1158, 633);
            label6.Name = "label6";
            label6.Size = new Size(87, 12);
            label6.TabIndex = 22;
            label6.Text = "© FredFred Burger";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_burger_sidebar
            // 
            btn_burger_sidebar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_burger_sidebar.Location = new Point(0, 89);
            btn_burger_sidebar.Name = "btn_burger_sidebar";
            btn_burger_sidebar.Size = new Size(175, 76);
            btn_burger_sidebar.TabIndex = 26;
            btn_burger_sidebar.Text = "🍔 Hamburguesa";
            btn_burger_sidebar.UseVisualStyleBackColor = true;
            btn_burger_sidebar.Click += btn_burger_sidebar_Click;
            // 
            // btn_volver
            // 
            btn_volver.FlatAppearance.BorderColor = Color.Gray;
            btn_volver.FlatAppearance.BorderSize = 2;
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.Location = new Point(1, 607);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(171, 58);
            btn_volver.TabIndex = 24;
            btn_volver.Text = "Vover";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += button6_Click;
            // 
            // lbl_frasmolona
            // 
            lbl_frasmolona.AutoSize = true;
            lbl_frasmolona.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_frasmolona.ForeColor = Color.FromArgb(201, 13, 18);
            lbl_frasmolona.Location = new Point(204, 117);
            lbl_frasmolona.Name = "lbl_frasmolona";
            lbl_frasmolona.Size = new Size(339, 27);
            lbl_frasmolona.TabIndex = 23;
            lbl_frasmolona.Text = "¿Qué te va apetecer hoy? ⚡\r\n";
            // 
            // panel_burgers
            // 
            panel_burgers.Controls.Add(item_muerte2);
            panel_burgers.Controls.Add(item_bacon2);
            panel_burgers.Controls.Add(item_completa2);
            panel_burgers.Controls.Add(item_simple2);
            panel_burgers.Location = new Point(198, 164);
            panel_burgers.Name = "panel_burgers";
            panel_burgers.Size = new Size(1049, 413);
            panel_burgers.TabIndex = 25;
            // 
            // item_muerte2
            // 
            item_muerte2.BackColor = Color.White;
            item_muerte2.Location = new Point(545, 221);
            item_muerte2.Name = "item_muerte2";
            item_muerte2.Size = new Size(504, 161);
            item_muerte2.TabIndex = 3;
            item_muerte2.Load += item_muerte2_Load_1;
            // 
            // item_bacon2
            // 
            item_bacon2.BackColor = Color.White;
            item_bacon2.Location = new Point(0, 220);
            item_bacon2.Name = "item_bacon2";
            item_bacon2.Size = new Size(504, 161);
            item_bacon2.TabIndex = 2;
            item_bacon2.Load += item_bacon2_Load_1;
            // 
            // item_completa2
            // 
            item_completa2.BackColor = Color.White;
            item_completa2.Location = new Point(545, 1);
            item_completa2.Name = "item_completa2";
            item_completa2.Size = new Size(504, 161);
            item_completa2.TabIndex = 1;
            item_completa2.Load += item_completa2_Load_1;
            // 
            // item_simple2
            // 
            item_simple2.BackColor = Color.White;
            item_simple2.Location = new Point(0, 0);
            item_simple2.Name = "item_simple2";
            item_simple2.Size = new Size(504, 161);
            item_simple2.TabIndex = 0;
            item_simple2.Load += item_simple2_Load;
            // 
            // bt_volverPedir
            // 
            bt_volverPedir.BackColor = Color.FromArgb(239, 239, 239);
            bt_volverPedir.FlatAppearance.BorderColor = Color.Gray;
            bt_volverPedir.FlatAppearance.BorderSize = 2;
            bt_volverPedir.FlatStyle = FlatStyle.Flat;
            bt_volverPedir.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_volverPedir.ForeColor = Color.FromArgb(22, 22, 23);
            bt_volverPedir.Location = new Point(1122, 586);
            bt_volverPedir.Name = "bt_volverPedir";
            bt_volverPedir.Size = new Size(128, 33);
            bt_volverPedir.TabIndex = 27;
            bt_volverPedir.Text = "Vover a pedir";
            bt_volverPedir.UseVisualStyleBackColor = false;
            bt_volverPedir.Click += bt_volverPedir_Click;
            // 
            // btn_bebida_sidebar
            // 
            btn_bebida_sidebar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bebida_sidebar.Location = new Point(0, 163);
            btn_bebida_sidebar.Name = "btn_bebida_sidebar";
            btn_bebida_sidebar.Size = new Size(175, 76);
            btn_bebida_sidebar.TabIndex = 28;
            btn_bebida_sidebar.Text = "🍺 Bebida";
            btn_bebida_sidebar.UseVisualStyleBackColor = true;
            btn_bebida_sidebar.Click += btn_bebida_sidebar_Click;
            // 
            // panel_bebidas
            // 
            panel_bebidas.Controls.Add(item_bebida_grand2);
            panel_bebidas.Controls.Add(item_bebida_peq2);
            panel_bebidas.Location = new Point(198, 164);
            panel_bebidas.Name = "panel_bebidas";
            panel_bebidas.Size = new Size(1049, 413);
            panel_bebidas.TabIndex = 26;
            // 
            // item_bebida_grand2
            // 
            item_bebida_grand2.BackColor = Color.White;
            item_bebida_grand2.Location = new Point(545, 2);
            item_bebida_grand2.Name = "item_bebida_grand2";
            item_bebida_grand2.Size = new Size(504, 161);
            item_bebida_grand2.TabIndex = 3;
            // 
            // item_bebida_peq2
            // 
            item_bebida_peq2.BackColor = Color.White;
            item_bebida_peq2.Location = new Point(0, 1);
            item_bebida_peq2.Name = "item_bebida_peq2";
            item_bebida_peq2.Size = new Size(504, 161);
            item_bebida_peq2.TabIndex = 2;
            // 
            // panel_nuggets
            // 
            panel_nuggets.Controls.Add(item_nuggets2);
            panel_nuggets.Location = new Point(198, 164);
            panel_nuggets.Name = "panel_nuggets";
            panel_nuggets.Size = new Size(1052, 184);
            panel_nuggets.TabIndex = 27;
            // 
            // item_nuggets2
            // 
            item_nuggets2.BackColor = Color.White;
            item_nuggets2.Location = new Point(2, 1);
            item_nuggets2.Name = "item_nuggets2";
            item_nuggets2.Size = new Size(504, 161);
            item_nuggets2.TabIndex = 2;
            // 
            // panel_postre
            // 
            panel_postre.Controls.Add(item_postre2);
            panel_postre.Location = new Point(198, 164);
            panel_postre.Name = "panel_postre";
            panel_postre.Size = new Size(1052, 269);
            panel_postre.TabIndex = 28;
            // 
            // item_postre2
            // 
            item_postre2.BackColor = Color.White;
            item_postre2.Location = new Point(3, 2);
            item_postre2.Name = "item_postre2";
            item_postre2.Size = new Size(504, 161);
            item_postre2.TabIndex = 2;
            // 
            // btn_nuggets_sidebar
            // 
            btn_nuggets_sidebar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuggets_sidebar.Location = new Point(0, 311);
            btn_nuggets_sidebar.Name = "btn_nuggets_sidebar";
            btn_nuggets_sidebar.Size = new Size(175, 76);
            btn_nuggets_sidebar.TabIndex = 29;
            btn_nuggets_sidebar.Text = " 🍗 Nuggets";
            btn_nuggets_sidebar.UseVisualStyleBackColor = true;
            btn_nuggets_sidebar.Click += btn_nuggets_sidebar_Click;
            // 
            // btn_patatas_sidebar
            // 
            btn_patatas_sidebar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_patatas_sidebar.Location = new Point(0, 237);
            btn_patatas_sidebar.Name = "btn_patatas_sidebar";
            btn_patatas_sidebar.Size = new Size(175, 76);
            btn_patatas_sidebar.TabIndex = 30;
            btn_patatas_sidebar.Text = " 🍟 Patatas";
            btn_patatas_sidebar.UseVisualStyleBackColor = true;
            btn_patatas_sidebar.Click += btn_patatas_sidebar_Click;
            // 
            // btn_postre_sidebar
            // 
            btn_postre_sidebar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_postre_sidebar.Location = new Point(0, 385);
            btn_postre_sidebar.Name = "btn_postre_sidebar";
            btn_postre_sidebar.Size = new Size(175, 76);
            btn_postre_sidebar.TabIndex = 31;
            btn_postre_sidebar.Text = " 🍰 Postre";
            btn_postre_sidebar.UseVisualStyleBackColor = true;
            btn_postre_sidebar.Click += btn_postre_sidebar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 581);
            panel3.TabIndex = 33;
            // 
            // panel_patatas
            // 
            panel_patatas.Controls.Add(item_patata_grande2);
            panel_patatas.Controls.Add(item_patata_peq2);
            panel_patatas.Location = new Point(198, 164);
            panel_patatas.Name = "panel_patatas";
            panel_patatas.Size = new Size(1049, 413);
            panel_patatas.TabIndex = 26;
            // 
            // item_patata_grande2
            // 
            item_patata_grande2.BackColor = Color.White;
            item_patata_grande2.Location = new Point(545, 1);
            item_patata_grande2.Name = "item_patata_grande2";
            item_patata_grande2.Size = new Size(504, 161);
            item_patata_grande2.TabIndex = 3;
            // 
            // item_patata_peq2
            // 
            item_patata_peq2.BackColor = Color.White;
            item_patata_peq2.Location = new Point(0, 0);
            item_patata_peq2.Name = "item_patata_peq2";
            item_patata_peq2.Size = new Size(504, 161);
            item_patata_peq2.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 222, 222);
            ClientSize = new Size(1285, 666);
            Controls.Add(btn_postre_sidebar);
            Controls.Add(btn_patatas_sidebar);
            Controls.Add(btn_nuggets_sidebar);
            Controls.Add(btn_bebida_sidebar);
            Controls.Add(bt_volverPedir);
            Controls.Add(btn_burger_sidebar);
            Controls.Add(btn_volver);
            Controls.Add(lbl_frasmolona);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel_burgers);
            Controls.Add(panel_postre);
            Controls.Add(panel_nuggets);
            Controls.Add(panel_bebidas);
            Controls.Add(panel_patatas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pb_ham_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_close_form2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_burgers.ResumeLayout(false);
            panel_bebidas.ResumeLayout(false);
            panel_nuggets.ResumeLayout(false);
            panel_postre.ResumeLayout(false);
            panel_patatas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private PictureBox pb_ham_logo;
        private Label lb_tittle;
        private PictureBox pb_close_form2;
        private Panel panel1;
        private Button btn_finaliza;
        private Label label6;
        private Panel pnl_sideBar;
        private Button btn_volver;
        private Label lbl_frasmolona;
        private Button btn_burger_sidebar;
        private Panel panel_burgers;
        private Button bt_volverPedir;
     
        private Button btn_bebida_sidebar;
        private Panel panel_bebidas;
   
        private Button btn_nuggets_sidebar;
        private Button btn_patatas_sidebar;
        private Button btn_postre_sidebar;
        private Panel panel3;
        private Panel panel_patatas;
        private Item_horizontal item_patata_grande;
        private Item_horizontal item_patata_peq;
        private Panel panel_nuggets;
        private Item_horizontal item_nuggets;
        private Panel panel_postre;
        private Item_horizontal item_postre;
        private Item_horizontal item_simple2;
        private Item_horizontal item_muerte2;
        private Item_horizontal item_bacon2;
        private Item_horizontal item_completa2;
        private Item_horizontal item_postre2;
        private Item_horizontal item_bebida_grand2;
        private Item_horizontal item_bebida_peq2;
        private Item_horizontal item_nuggets2;
        private Item_horizontal item_patata_grande2;
        private Item_horizontal item_patata_peq2;
    }
}
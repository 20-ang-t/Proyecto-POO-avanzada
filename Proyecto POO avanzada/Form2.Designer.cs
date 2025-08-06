namespace VERSION_FINAL
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
            panel1 = new Panel();
            label2 = new Label();
            BtRestaurar = new PictureBox();
            BtMinimizar = new PictureBox();
            BtCerrar = new PictureBox();
            BtMaximizar = new PictureBox();
            panel2 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BtRestaurar);
            panel1.Controls.Add(BtMinimizar);
            panel1.Controls.Add(BtCerrar);
            panel1.Controls.Add(BtMaximizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 49);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(714, 12);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 5;
            label2.Text = "CENSA VIRTUAL";
            // 
            // BtRestaurar
            // 
            BtRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtRestaurar.Image = (Image)resources.GetObject("BtRestaurar.Image");
            BtRestaurar.Location = new Point(1240, 12);
            BtRestaurar.Name = "BtRestaurar";
            BtRestaurar.Size = new Size(20, 23);
            BtRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtRestaurar.TabIndex = 7;
            BtRestaurar.TabStop = false;
            BtRestaurar.Visible = false;
            BtRestaurar.Click += BtRestaurar_Click;
            // 
            // BtMinimizar
            // 
            BtMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtMinimizar.Image = (Image)resources.GetObject("BtMinimizar.Image");
            BtMinimizar.Location = new Point(1214, 12);
            BtMinimizar.Name = "BtMinimizar";
            BtMinimizar.Size = new Size(20, 23);
            BtMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtMinimizar.TabIndex = 6;
            BtMinimizar.TabStop = false;
            BtMinimizar.Click += BtMinimizar_Click;
            // 
            // BtCerrar
            // 
            BtCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtCerrar.Image = Properties.Resources.x;
            BtCerrar.Location = new Point(1266, 12);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(20, 23);
            BtCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtCerrar.TabIndex = 4;
            BtCerrar.TabStop = false;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // BtMaximizar
            // 
            BtMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtMaximizar.Image = (Image)resources.GetObject("BtMaximizar.Image");
            BtMaximizar.Location = new Point(1240, 12);
            BtMaximizar.Name = "BtMaximizar";
            BtMaximizar.Size = new Size(20, 23);
            BtMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtMaximizar.TabIndex = 5;
            BtMaximizar.TabStop = false;
            BtMaximizar.Click += BtMaximizar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(iconButton5);
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 630);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGreen;
            panel7.Location = new Point(0, 313);
            panel7.Name = "panel7";
            panel7.Size = new Size(8, 46);
            panel7.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGreen;
            panel6.Location = new Point(0, 261);
            panel6.Name = "panel6";
            panel6.Size = new Size(8, 46);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGreen;
            panel5.Location = new Point(0, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(8, 46);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Location = new Point(0, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 46);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Location = new Point(0, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 46);
            panel4.TabIndex = 3;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(3, 314);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 20, 0);
            iconButton5.Size = new Size(216, 45);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "SALIR";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(3, 262);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 20, 0);
            iconButton4.Size = new Size(216, 45);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "INF. B.DATOS";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(3, 210);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(216, 45);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "MATRICULAS";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(3, 157);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(217, 45);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "PROGRAMAS TECNICOS";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 103);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(217, 46);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "PAGINA PRINCIPAL";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Logos_Privilegios_a_color__3_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 52);
            label1.Name = "label1";
            label1.Size = new Size(911, 37);
            label1.TabIndex = 3;
            label1.Text = "¡Bienvenido(a) Al Centro de Sistemas de Antioquia Censa Medellin!";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 143);
            label3.Name = "label3";
            label3.Size = new Size(107, 34);
            label3.TabIndex = 4;
            label3.Text = "MISIÓN";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.Location = new Point(470, 177);
            label4.Name = "label4";
            label4.Size = new Size(712, 168);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(433, 374);
            label6.Name = "label6";
            label6.Size = new Size(100, 34);
            label6.TabIndex = 6;
            label6.Text = "VISIÓN";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 12F);
            label7.Location = new Point(470, 408);
            label7.Name = "label7";
            label7.Size = new Size(573, 63);
            label7.TabIndex = 7;
            label7.Text = resources.GetString("label7.Text");
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold);
            label8.Location = new Point(433, 498);
            label8.Name = "label8";
            label8.Size = new Size(305, 34);
            label8.TabIndex = 8;
            label8.Text = "POLITICAS DE CALIDAD";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium", 12F);
            label9.Location = new Point(470, 532);
            label9.Name = "label9";
            label9.Size = new Size(662, 147);
            label9.TabIndex = 9;
            label9.Text = resources.GetString("label9.Text");
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1315, 631);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            MouseDown += Form2_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox BtRestaurar;
        private PictureBox BtMinimizar;
        private PictureBox BtCerrar;
        private PictureBox BtMaximizar;
        private Panel panel2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
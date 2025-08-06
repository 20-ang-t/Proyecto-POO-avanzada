namespace VERSION_FINAL
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
            checkedListBox1 = new CheckedListBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(1833, 49);
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
            label2.Size = new Size(255, 31);
            label2.TabIndex = 5;
            label2.Text = "CENSA VIRTUAL";
            // 
            // BtRestaurar
            // 
            BtRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtRestaurar.Image = (Image)resources.GetObject("BtRestaurar.Image");
            BtRestaurar.Location = new Point(1775, 12);
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
            BtMinimizar.Location = new Point(1749, 12);
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
            BtCerrar.Location = new Point(1801, 12);
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
            BtMaximizar.Location = new Point(1775, 12);
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
            panel2.Size = new Size(220, 850);
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
            iconButton1.Click += iconButton1_Click;
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
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = Color.DimGray;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Centro de Idiomas", "Conocimientos Académicos en Inglés Nivel B1", "Conocimientos académicos en Ingles Nivel B2", "Conocimientos académicos en Ingles Nivel C1", "Técnico Laboral en Atención Integral a la Primera Infancia", "Técnico Laboral en Auxiliar de Archivo", "Técnico Laboral en Auxiliar de Costos y Presupuestos", "Técnico Laboral en Auxiliar de Recursos Humanos", "Técnico Laboral en Diseño Gráfico Digital", "Técnico Laboral en Ensamble y Mantenimiento de Computadores", "Técnico Laboral en Instalador de Redes de Telecomunicaciones", "Técnico Laboral en Asesoría de Imagen", "Técnico Laboral en Atención Integral al Adulto Mayor", "Técnico Laboral en Asesor de Call Center y Servicio al Cliente", "Técnico Laboral en Secretariado Bilingüe Nivel B1", "Técnico Laboral en Asistente en Análisis y Desarrollo de Software", "Técnico Laboral en Procedimientos Contables", "Técnico Laboral en Secretariado Gerencial", "Técnico Laboral en Asistente en Mercadeo", "Técnico Laboral en Ensamble y Mantenimiento de Equipos de Computo", "Técnico Laboral en Procedimientos Administrativos", "Técnico Laboral en Asistente en Electrónica Digital y Telecomunicaciones", "Técnico Laboral en Asistente en Logística de Centros de Distribución", "Técnico Laboral en Agente Turístico", "Técnico Laboral en Secretariado Contable Financiero", "Técnico Laboral en Auxiliar en Diseño Gráfico Digital", "Técnico Laboral en Auxiliar en Banca y Finanzas", "Técnico Laboral como Animador en Deporte y Recreación", "Técnico Laboral en Barbería", "Técnico Laboral en Auxiliar de Comercio Exterior", "Técnico Laboral Asistente Legal y Jurídico", "Técnico Laboral en Cuidado Estético de Manos y Pies", "Técnico Laboral en Auxiliar Administrativo en Documentación Catastral", "Técnico Laboral en Auxiliar de Desarrollo Web", "Técnico Laboral en Auxiliar de Desarrollo de Aplicaciones Móviles", "Técnico Laboral en auxiliar de Desarrollo de Videojuegos", "Técnico Laboral en Auxiliar de Desarrollo de Realidad Aumentada 3D", "Técnico Laboral como Instructor en Entrenamiento Deportivo y Recreación" });
            checkedListBox1.Location = new Point(450, 59);
            checkedListBox1.Margin = new Padding(1);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(896, 792);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.descarga;
            pictureBox2.Location = new Point(1404, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(326, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1833, 899);
            Controls.Add(pictureBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox2;
    }
}
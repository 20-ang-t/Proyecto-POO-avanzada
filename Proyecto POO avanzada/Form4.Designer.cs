namespace VERSION_FINAL
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            TxtCedula = new Controles_1.Controles.RJTextBox();
            dataGridView1 = new DataGridView();
            TxtNombre = new Controles_1.Controles.RJTextBox();
            TxtApellido = new Controles_1.Controles.RJTextBox();
            Txtelefono = new Controles_1.Controles.RJTextBox();
            TxtEmail = new Controles_1.Controles.RJTextBox();
            id_Valor = new Controles_1.Controles.RJTextBox();
            groupBox1 = new GroupBox();
            RJBRegistrar = new Controles_1.Controles.RJButton();
            BntBorrar = new Controles_1.Controles.RJButton();
            TxtDireccion = new Controles_1.Controles.RJTextBox();
            Nacimiento = new DateTimePicker();
            label4 = new Label();
            Tipo_Documento = new ComboBox();
            TxtContacto = new Controles_1.Controles.RJTextBox();
            label5 = new Label();
            CbGenero = new ComboBox();
            label6 = new Label();
            CbRh = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1942, 65);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(741, 16);
            label2.Name = "label2";
            label2.Size = new Size(255, 31);
            label2.TabIndex = 5;
            label2.Text = "CENSA VIRTUAL";
            // 
            // BtRestaurar
            // 
            BtRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtRestaurar.Image = (Image)resources.GetObject("BtRestaurar.Image");
            BtRestaurar.Location = new Point(1876, 16);
            BtRestaurar.Margin = new Padding(3, 4, 3, 4);
            BtRestaurar.Name = "BtRestaurar";
            BtRestaurar.Size = new Size(23, 31);
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
            BtMinimizar.Location = new Point(1846, 16);
            BtMinimizar.Margin = new Padding(3, 4, 3, 4);
            BtMinimizar.Name = "BtMinimizar";
            BtMinimizar.Size = new Size(23, 31);
            BtMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtMinimizar.TabIndex = 6;
            BtMinimizar.TabStop = false;
            BtMinimizar.Click += BtMinimizar_Click;
            // 
            // BtCerrar
            // 
            BtCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtCerrar.Image = Properties.Resources.x;
            BtCerrar.Location = new Point(1905, 16);
            BtCerrar.Margin = new Padding(3, 4, 3, 4);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(23, 31);
            BtCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtCerrar.TabIndex = 4;
            BtCerrar.TabStop = false;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // BtMaximizar
            // 
            BtMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtMaximizar.Image = (Image)resources.GetObject("BtMaximizar.Image");
            BtMaximizar.Location = new Point(1876, 16);
            BtMaximizar.Margin = new Padding(3, 4, 3, 4);
            BtMaximizar.Name = "BtMaximizar";
            BtMaximizar.Size = new Size(23, 31);
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
            panel2.Location = new Point(0, 65);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 918);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGreen;
            panel7.Location = new Point(0, 417);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(9, 61);
            panel7.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGreen;
            panel6.Location = new Point(0, 348);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(9, 61);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGreen;
            panel5.Location = new Point(0, 279);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(9, 61);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Location = new Point(0, 137);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(9, 61);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Location = new Point(0, 208);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(9, 61);
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
            iconButton5.Location = new Point(3, 419);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(11, 0, 23, 0);
            iconButton5.Size = new Size(230, 60);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "SALIR";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click_1;
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
            iconButton4.Location = new Point(3, 349);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(11, 0, 23, 0);
            iconButton4.Size = new Size(230, 60);
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
            iconButton3.Location = new Point(3, 280);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(11, 0, 23, 0);
            iconButton3.Size = new Size(230, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "MATRICULAS";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
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
            iconButton2.Location = new Point(3, 209);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(11, 0, 23, 0);
            iconButton2.Size = new Size(231, 60);
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
            iconButton1.Location = new Point(3, 137);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(11, 0, 23, 0);
            iconButton1.Size = new Size(231, 61);
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
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtCedula
            // 
            TxtCedula.BackColor = SystemColors.Control;
            TxtCedula.Bordercolor = Color.ForestGreen;
            TxtCedula.BorderFocusColor = Color.DarkCyan;
            TxtCedula.BorderRadius = 15;
            TxtCedula.BorderSize = 2;
            TxtCedula.Cursor = Cursors.IBeam;
            TxtCedula.Font = new Font("Segoe UI", 9.5F);
            TxtCedula.Location = new Point(276, 78);
            TxtCedula.Margin = new Padding(3, 4, 3, 4);
            TxtCedula.Multiline = false;
            TxtCedula.Name = "TxtCedula";
            TxtCedula.Padding = new Padding(11);
            TxtCedula.PasswordChar = false;
            TxtCedula.Placeholdercolor = SystemColors.ControlDarkDark;
            TxtCedula.PlaceholderText = "NUMERO DE DOCUMENTO";
            TxtCedula.Size = new Size(304, 44);
            TxtCedula.TabIndex = 2;
            TxtCedula.TextAlign = HorizontalAlignment.Left;
            TxtCedula.Texts = "";
            TxtCedula.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.ForestGreen;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.ForestGreen;
            dataGridView1.Location = new Point(257, 356);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.ForestGreen;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1665, 549);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.Control;
            TxtNombre.Bordercolor = Color.ForestGreen;
            TxtNombre.BorderFocusColor = Color.DarkCyan;
            TxtNombre.BorderRadius = 15;
            TxtNombre.BorderSize = 2;
            TxtNombre.Cursor = Cursors.IBeam;
            TxtNombre.Font = new Font("Segoe UI", 9.5F);
            TxtNombre.Location = new Point(275, 193);
            TxtNombre.Margin = new Padding(3, 4, 3, 4);
            TxtNombre.Multiline = false;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Padding = new Padding(11);
            TxtNombre.PasswordChar = false;
            TxtNombre.Placeholdercolor = SystemColors.ControlDarkDark;
            TxtNombre.PlaceholderText = "NOMBRE";
            TxtNombre.Size = new Size(304, 44);
            TxtNombre.TabIndex = 14;
            TxtNombre.TextAlign = HorizontalAlignment.Left;
            TxtNombre.Texts = "";
            TxtNombre.UnderlinedStyle = false;
            // 
            // TxtApellido
            // 
            TxtApellido.BackColor = SystemColors.Control;
            TxtApellido.Bordercolor = Color.ForestGreen;
            TxtApellido.BorderFocusColor = Color.DarkCyan;
            TxtApellido.BorderRadius = 15;
            TxtApellido.BorderSize = 2;
            TxtApellido.Cursor = Cursors.IBeam;
            TxtApellido.Font = new Font("Segoe UI", 9.5F);
            TxtApellido.Location = new Point(276, 246);
            TxtApellido.Margin = new Padding(3, 4, 3, 4);
            TxtApellido.Multiline = false;
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Padding = new Padding(11);
            TxtApellido.PasswordChar = false;
            TxtApellido.Placeholdercolor = SystemColors.ControlDarkDark;
            TxtApellido.PlaceholderText = "APELLIDOS";
            TxtApellido.Size = new Size(304, 44);
            TxtApellido.TabIndex = 15;
            TxtApellido.TextAlign = HorizontalAlignment.Left;
            TxtApellido.Texts = "";
            TxtApellido.UnderlinedStyle = false;
            // 
            // Txtelefono
            // 
            Txtelefono.BackColor = SystemColors.Control;
            Txtelefono.Bordercolor = Color.ForestGreen;
            Txtelefono.BorderFocusColor = Color.DarkCyan;
            Txtelefono.BorderRadius = 15;
            Txtelefono.BorderSize = 2;
            Txtelefono.Cursor = Cursors.IBeam;
            Txtelefono.Font = new Font("Segoe UI", 9.5F);
            Txtelefono.Location = new Point(619, 246);
            Txtelefono.Margin = new Padding(3, 4, 3, 4);
            Txtelefono.Multiline = false;
            Txtelefono.Name = "Txtelefono";
            Txtelefono.Padding = new Padding(11);
            Txtelefono.PasswordChar = false;
            Txtelefono.Placeholdercolor = SystemColors.ControlDarkDark;
            Txtelefono.PlaceholderText = "TELEFONO";
            Txtelefono.Size = new Size(304, 44);
            Txtelefono.TabIndex = 17;
            Txtelefono.TextAlign = HorizontalAlignment.Left;
            Txtelefono.Texts = "";
            Txtelefono.UnderlinedStyle = false;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.Control;
            TxtEmail.Bordercolor = Color.ForestGreen;
            TxtEmail.BorderFocusColor = Color.DarkCyan;
            TxtEmail.BorderRadius = 15;
            TxtEmail.BorderSize = 2;
            TxtEmail.Cursor = Cursors.IBeam;
            TxtEmail.Font = new Font("Segoe UI", 9.5F);
            TxtEmail.Location = new Point(619, 189);
            TxtEmail.Margin = new Padding(3, 4, 3, 4);
            TxtEmail.Multiline = false;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Padding = new Padding(11);
            TxtEmail.PasswordChar = false;
            TxtEmail.Placeholdercolor = SystemColors.ControlDarkDark;
            TxtEmail.PlaceholderText = "EMAIL";
            TxtEmail.Size = new Size(304, 44);
            TxtEmail.TabIndex = 18;
            TxtEmail.TextAlign = HorizontalAlignment.Left;
            TxtEmail.Texts = "";
            TxtEmail.UnderlinedStyle = false;
            // 
            // id_Valor
            // 
            id_Valor.BackColor = SystemColors.Control;
            id_Valor.Bordercolor = Color.ForestGreen;
            id_Valor.BorderFocusColor = Color.DarkCyan;
            id_Valor.BorderRadius = 15;
            id_Valor.BorderSize = 2;
            id_Valor.Cursor = Cursors.IBeam;
            id_Valor.Font = new Font("Segoe UI", 9.5F);
            id_Valor.Location = new Point(945, 246);
            id_Valor.Margin = new Padding(3, 4, 3, 4);
            id_Valor.Multiline = false;
            id_Valor.Name = "id_Valor";
            id_Valor.Padding = new Padding(11);
            id_Valor.PasswordChar = false;
            id_Valor.Placeholdercolor = SystemColors.ControlDarkDark;
            id_Valor.PlaceholderText = "VALOR MATRICULA";
            id_Valor.Size = new Size(304, 44);
            id_Valor.TabIndex = 20;
            id_Valor.TextAlign = HorizontalAlignment.Left;
            id_Valor.Texts = "";
            id_Valor.UnderlinedStyle = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(RJBRegistrar);
            groupBox1.Controls.Add(BntBorrar);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(1288, 85);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(630, 249);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOTONES";
            // 
            // RJBRegistrar
            // 
            RJBRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RJBRegistrar.BackColor = SystemColors.Control;
            RJBRegistrar.BackgroundColor = SystemColors.Control;
            RJBRegistrar.BorderColor = Color.DarkCyan;
            RJBRegistrar.BorderRadius = 10;
            RJBRegistrar.BorderSize = 3;
            RJBRegistrar.FlatAppearance.BorderSize = 0;
            RJBRegistrar.FlatStyle = FlatStyle.Flat;
            RJBRegistrar.ForeColor = Color.DarkCyan;
            RJBRegistrar.Location = new Point(40, 69);
            RJBRegistrar.Margin = new Padding(3, 4, 3, 4);
            RJBRegistrar.Name = "RJBRegistrar";
            RJBRegistrar.Size = new Size(287, 53);
            RJBRegistrar.TabIndex = 2;
            RJBRegistrar.Text = "REGISTRAR";
            RJBRegistrar.TextColor = Color.DarkCyan;
            RJBRegistrar.UseVisualStyleBackColor = false;
            RJBRegistrar.Click += RJBRegistrar_Click;
            // 
            // BntBorrar
            // 
            BntBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BntBorrar.BackColor = SystemColors.Control;
            BntBorrar.BackgroundColor = SystemColors.Control;
            BntBorrar.BorderColor = Color.DarkCyan;
            BntBorrar.BorderRadius = 10;
            BntBorrar.BorderSize = 3;
            BntBorrar.FlatAppearance.BorderSize = 0;
            BntBorrar.FlatStyle = FlatStyle.Flat;
            BntBorrar.ForeColor = Color.DarkCyan;
            BntBorrar.Location = new Point(324, 141);
            BntBorrar.Margin = new Padding(3, 4, 3, 4);
            BntBorrar.Name = "BntBorrar";
            BntBorrar.Size = new Size(287, 53);
            BntBorrar.TabIndex = 23;
            BntBorrar.Text = "BORRAR";
            BntBorrar.TextColor = Color.DarkCyan;
            BntBorrar.UseVisualStyleBackColor = false;
            BntBorrar.Click += BntBorrar_Click;
            // 
            // TxtDireccion
            // 
            TxtDireccion.BackColor = SystemColors.Control;
            TxtDireccion.Bordercolor = Color.ForestGreen;
            TxtDireccion.BorderFocusColor = Color.DarkCyan;
            TxtDireccion.BorderRadius = 15;
            TxtDireccion.BorderSize = 2;
            TxtDireccion.Cursor = Cursors.IBeam;
            TxtDireccion.Font = new Font("Segoe UI", 9.5F);
            TxtDireccion.Location = new Point(619, 131);
            TxtDireccion.Margin = new Padding(3, 4, 3, 4);
            TxtDireccion.Multiline = false;
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Padding = new Padding(11);
            TxtDireccion.PasswordChar = false;
            TxtDireccion.Placeholdercolor = SystemColors.ControlDarkDark;
            TxtDireccion.PlaceholderText = "DIRECCION";
            TxtDireccion.Size = new Size(304, 44);
            TxtDireccion.TabIndex = 28;
            TxtDireccion.TextAlign = HorizontalAlignment.Left;
            TxtDireccion.Texts = "";
            TxtDireccion.UnderlinedStyle = false;
            // 
            // Nacimiento
            // 
            Nacimiento.Location = new Point(945, 148);
            Nacimiento.Name = "Nacimiento";
            Nacimiento.Size = new Size(304, 27);
            Nacimiento.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(292, 133);
            label4.Name = "label4";
            label4.Size = new Size(151, 19);
            label4.TabIndex = 31;
            label4.Text = "TIPO DE DOCUMENTO";
            // 
            // Tipo_Documento
            // 
            Tipo_Documento.BackColor = SystemColors.Window;
            Tipo_Documento.FormattingEnabled = true;
            Tipo_Documento.Items.AddRange(new object[] { "Identificación.", "Colombianos en el exterior.", "Tarjeta de identidad.", "Cédula de Ciudadanía.", "Certificados excepcionales y de nacionalidad.", "Concepción de identidad de los indígenas JIW y NUKAK.", "Glosario de identificación." });
            Tipo_Documento.Location = new Point(276, 146);
            Tipo_Documento.Margin = new Padding(3, 4, 3, 4);
            Tipo_Documento.Name = "Tipo_Documento";
            Tipo_Documento.Size = new Size(303, 28);
            Tipo_Documento.TabIndex = 30;
            // 
            // TxtContacto
            // 
            TxtContacto.BackColor = SystemColors.Control;
            TxtContacto.Bordercolor = Color.ForestGreen;
            TxtContacto.BorderFocusColor = Color.DarkCyan;
            TxtContacto.BorderRadius = 15;
            TxtContacto.BorderSize = 2;
            TxtContacto.Cursor = Cursors.IBeam;
            TxtContacto.Font = new Font("Segoe UI", 9.5F);
            TxtContacto.Location = new Point(945, 85);
            TxtContacto.Margin = new Padding(3, 4, 3, 4);
            TxtContacto.Multiline = false;
            TxtContacto.Name = "TxtContacto";
            TxtContacto.Padding = new Padding(11);
            TxtContacto.PasswordChar = false;
            TxtContacto.Placeholdercolor = SystemColors.ControlDarkDark;
            TxtContacto.PlaceholderText = "CONTACTO";
            TxtContacto.Size = new Size(304, 44);
            TxtContacto.TabIndex = 32;
            TxtContacto.TextAlign = HorizontalAlignment.Left;
            TxtContacto.Texts = "";
            TxtContacto.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(635, 77);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 33;
            label5.Text = "GENERO";
            // 
            // CbGenero
            // 
            CbGenero.BackColor = SystemColors.Window;
            CbGenero.FormattingEnabled = true;
            CbGenero.Items.AddRange(new object[] { "FEMENINO", "MASCULINO", "OTRO" });
            CbGenero.Location = new Point(619, 91);
            CbGenero.Margin = new Padding(3, 4, 3, 4);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(303, 28);
            CbGenero.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(962, 188);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 35;
            label6.Text = "TIPO DE SANGRE";
            // 
            // CbRh
            // 
            CbRh.BackColor = SystemColors.Window;
            CbRh.FormattingEnabled = true;
            CbRh.Items.AddRange(new object[] { "A+", " A-", " B+", " B-", " AB+", " AB-", " O+ ", " O-" });
            CbRh.Location = new Point(945, 202);
            CbRh.Margin = new Padding(3, 4, 3, 4);
            CbRh.Name = "CbRh";
            CbRh.Size = new Size(303, 28);
            CbRh.TabIndex = 36;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1942, 983);
            Controls.Add(label6);
            Controls.Add(CbRh);
            Controls.Add(label5);
            Controls.Add(CbGenero);
            Controls.Add(TxtContacto);
            Controls.Add(label4);
            Controls.Add(Tipo_Documento);
            Controls.Add(Nacimiento);
            Controls.Add(TxtDireccion);
            Controls.Add(groupBox1);
            Controls.Add(id_Valor);
            Controls.Add(TxtEmail);
            Controls.Add(Txtelefono);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(dataGridView1);
            Controls.Add(TxtCedula);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
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
        private Controles_1.Controles.RJTextBox TxtCedula;
        private DataGridView dataGridView1;
        private Controles_1.Controles.RJTextBox TxtNombre;
        private Controles_1.Controles.RJTextBox TxtApellido;
        private Controles_1.Controles.RJTextBox Txtelefono;
        private Controles_1.Controles.RJTextBox TxtEmail;
        private Controles_1.Controles.RJTextBox id_Valor;
        private GroupBox groupBox1;
        private Controles_1.Controles.RJButton RJBRegistrar;
        private Controles_1.Controles.RJButton BntBorrar;
        private Controles_1.Controles.RJTextBox TxtDireccion;
        private DateTimePicker Nacimiento;
        private DataGridViewTextBoxColumn Documento;
        private Label label4;
        private ComboBox Tipo_Documento;
        private Controles_1.Controles.RJTextBox TxtContacto;
        private Label label5;
        private ComboBox CbGenero;
        private Label label6;
        private ComboBox CbRh;
    }
}
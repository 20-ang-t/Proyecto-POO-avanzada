namespace VERSION_FINAL
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            BtnData = new Controles_1.Controles.RJButton();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel1.Size = new Size(1828, 49);
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
            BtRestaurar.Location = new Point(1770, 12);
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
            BtMinimizar.Location = new Point(1744, 12);
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
            BtCerrar.Location = new Point(1796, 12);
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
            BtMaximizar.Location = new Point(1770, 12);
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
            panel2.Size = new Size(220, 807);
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
            // BtnData
            // 
            BtnData.BackColor = SystemColors.Control;
            BtnData.BackgroundColor = SystemColors.Control;
            BtnData.BorderColor = Color.DarkCyan;
            BtnData.BorderRadius = 10;
            BtnData.BorderSize = 3;
            BtnData.FlatAppearance.BorderSize = 0;
            BtnData.FlatStyle = FlatStyle.Flat;
            BtnData.ForeColor = Color.DarkCyan;
            BtnData.Location = new Point(237, 69);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(251, 40);
            BtnData.TabIndex = 26;
            BtnData.Text = "CONECTION DATA";
            BtnData.TextColor = Color.DarkCyan;
            BtnData.UseVisualStyleBackColor = false;
            BtnData.Click += rjButton1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.ForestGreen;
            dataGridView2.Location = new Point(237, 125);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1553, 589);
            dataGridView2.TabIndex = 28;
            // 
            // Form5
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1828, 856);
            Controls.Add(dataGridView2);
            Controls.Add(BtnData);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form2";
            Load += Form5_Load;
            MouseDown += Form2_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Controles_1.Controles.RJButton BtnData;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
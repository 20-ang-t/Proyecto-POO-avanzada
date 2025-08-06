namespace VERSION_FINAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            BtRestaurar = new PictureBox();
            BtMinimizar = new PictureBox();
            BtMaximizar = new PictureBox();
            BtCerrar = new PictureBox();
            txtUsuarios = new Controles_1.Controles.RJTextBox();
            txtClave = new Controles_1.Controles.RJTextBox();
            BntBorrar = new Controles_1.Controles.RJButton();
            rjButton1 = new Controles_1.Controles.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtRestaurar);
            panel1.Controls.Add(BtMinimizar);
            panel1.Controls.Add(BtMaximizar);
            panel1.Controls.Add(BtCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 49);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(206, 14);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 4;
            label1.Text = "CENSA";
            // 
            // BtRestaurar
            // 
            BtRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtRestaurar.Cursor = Cursors.Hand;
            BtRestaurar.Image = (Image)resources.GetObject("BtRestaurar.Image");
            BtRestaurar.Location = new Point(426, 14);
            BtRestaurar.Name = "BtRestaurar";
            BtRestaurar.Size = new Size(20, 23);
            BtRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtRestaurar.TabIndex = 3;
            BtRestaurar.TabStop = false;
            BtRestaurar.Visible = false;
            BtRestaurar.Click += BtRestaurar_Click;
            // 
            // BtMinimizar
            // 
            BtMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtMinimizar.Cursor = Cursors.Hand;
            BtMinimizar.Image = (Image)resources.GetObject("BtMinimizar.Image");
            BtMinimizar.Location = new Point(400, 14);
            BtMinimizar.Name = "BtMinimizar";
            BtMinimizar.Size = new Size(20, 23);
            BtMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtMinimizar.TabIndex = 2;
            BtMinimizar.TabStop = false;
            BtMinimizar.Click += BtMinimizar_Click;
            // 
            // BtMaximizar
            // 
            BtMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtMaximizar.Cursor = Cursors.Hand;
            BtMaximizar.Image = (Image)resources.GetObject("BtMaximizar.Image");
            BtMaximizar.Location = new Point(426, 14);
            BtMaximizar.Name = "BtMaximizar";
            BtMaximizar.Size = new Size(20, 23);
            BtMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtMaximizar.TabIndex = 1;
            BtMaximizar.TabStop = false;
            BtMaximizar.Click += BtMaximizar_Click;
            // 
            // BtCerrar
            // 
            BtCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Image = Properties.Resources.x;
            BtCerrar.Location = new Point(452, 14);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(20, 23);
            BtCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtCerrar.TabIndex = 0;
            BtCerrar.TabStop = false;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // txtUsuarios
            // 
            txtUsuarios.Anchor = AnchorStyles.None;
            txtUsuarios.BackColor = SystemColors.Control;
            txtUsuarios.Bordercolor = Color.ForestGreen;
            txtUsuarios.BorderFocusColor = Color.Red;
            txtUsuarios.BorderRadius = 15;
            txtUsuarios.BorderSize = 2;
            txtUsuarios.Font = new Font("Segoe UI", 9.5F);
            txtUsuarios.Location = new Point(66, 111);
            txtUsuarios.Multiline = false;
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.Padding = new Padding(10, 8, 10, 8);
            txtUsuarios.PasswordChar = false;
            txtUsuarios.Placeholdercolor = Color.DimGray;
            txtUsuarios.PlaceholderText = "Usuario";
            txtUsuarios.Size = new Size(354, 38);
            txtUsuarios.TabIndex = 7;
            txtUsuarios.TextAlign = HorizontalAlignment.Left;
            txtUsuarios.Texts = "";
            txtUsuarios.UnderlinedStyle = false;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.None;
            txtClave.BackColor = SystemColors.Control;
            txtClave.Bordercolor = Color.ForestGreen;
            txtClave.BorderFocusColor = Color.Red;
            txtClave.BorderRadius = 15;
            txtClave.BorderSize = 2;
            txtClave.Font = new Font("Segoe UI", 9.5F);
            txtClave.Location = new Point(66, 163);
            txtClave.Multiline = false;
            txtClave.Name = "txtClave";
            txtClave.Padding = new Padding(10, 8, 10, 8);
            txtClave.PasswordChar = true;
            txtClave.Placeholdercolor = Color.DimGray;
            txtClave.PlaceholderText = "Password";
            txtClave.Size = new Size(354, 38);
            txtClave.TabIndex = 8;
            txtClave.TextAlign = HorizontalAlignment.Left;
            txtClave.Texts = "";
            txtClave.UnderlinedStyle = false;
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
            BntBorrar.Location = new Point(66, 262);
            BntBorrar.Margin = new Padding(3, 4, 3, 4);
            BntBorrar.Name = "BntBorrar";
            BntBorrar.Size = new Size(121, 36);
            BntBorrar.TabIndex = 25;
            BntBorrar.Text = "ACEPTAR";
            BntBorrar.TextColor = Color.DarkCyan;
            BntBorrar.UseVisualStyleBackColor = false;
            BntBorrar.Click += BntBorrar_Click;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rjButton1.BackColor = SystemColors.Control;
            rjButton1.BackgroundColor = SystemColors.Control;
            rjButton1.BorderColor = Color.DarkCyan;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 3;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.DarkCyan;
            rjButton1.Location = new Point(299, 262);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(121, 36);
            rjButton1.TabIndex = 26;
            rjButton1.Text = "CANCELAR";
            rjButton1.TextColor = Color.DarkCyan;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(484, 356);
            Controls.Add(rjButton1);
            Controls.Add(BntBorrar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuarios);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox BtRestaurar;
        private PictureBox BtMinimizar;
        private PictureBox BtMaximizar;
        private PictureBox BtCerrar;
        private Label label1;
        private Controles_1.Controles.RJTextBox txtUsuarios;
        private Controles_1.Controles.RJTextBox txtClave;
        private Controles_1.Controles.RJButton BntBorrar;
        private Controles_1.Controles.RJButton rjButton1;
    }
}

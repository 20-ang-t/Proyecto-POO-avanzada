namespace VERSION_FINAL
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            BtRestaurar = new PictureBox();
            BtMinimizar = new PictureBox();
            label1 = new Label();
            BtMaximizar = new PictureBox();
            BtCerrar = new PictureBox();
            lbInformation = new Label();
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
            panel1.Controls.Add(BtRestaurar);
            panel1.Controls.Add(BtMinimizar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtMaximizar);
            panel1.Controls.Add(BtCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 49);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // BtRestaurar
            // 
            BtRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtRestaurar.Cursor = Cursors.Hand;
            BtRestaurar.Image = (Image)resources.GetObject("BtRestaurar.Image");
            BtRestaurar.Location = new Point(535, 14);
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
            BtMinimizar.Location = new Point(509, 14);
            BtMinimizar.Name = "BtMinimizar";
            BtMinimizar.Size = new Size(20, 23);
            BtMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtMinimizar.TabIndex = 2;
            BtMinimizar.TabStop = false;
            BtMinimizar.Click += BtMinimizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(237, 14);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 4;
            label1.Text = "CENSA";
            // 
            // BtMaximizar
            // 
            BtMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtMaximizar.Cursor = Cursors.Hand;
            BtMaximizar.Image = (Image)resources.GetObject("BtMaximizar.Image");
            BtMaximizar.Location = new Point(535, 14);
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
            BtCerrar.Location = new Point(561, 14);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(20, 23);
            BtCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtCerrar.TabIndex = 0;
            BtCerrar.TabStop = false;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // lbInformation
            // 
            lbInformation.AutoSize = true;
            lbInformation.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbInformation.ForeColor = SystemColors.ControlDarkDark;
            lbInformation.Location = new Point(76, 67);
            lbInformation.Name = "lbInformation";
            lbInformation.Size = new Size(438, 155);
            lbInformation.TabIndex = 7;
            lbInformation.Text = "Teléfono:  (57) + 604 + 444 55 56\r\n\r\nEmail: soportevirtual@censa.edu.co\r\n\r\nDirección: Calle. 51 # 43 - 83\r\n";
            lbInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BntBorrar
            // 
            BntBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BntBorrar.BackColor = SystemColors.Control;
            BntBorrar.BackgroundColor = SystemColors.Control;
            BntBorrar.BorderColor = Color.SeaGreen;
            BntBorrar.BorderRadius = 10;
            BntBorrar.BorderSize = 3;
            BntBorrar.FlatAppearance.BorderSize = 0;
            BntBorrar.FlatStyle = FlatStyle.Flat;
            BntBorrar.ForeColor = Color.SeaGreen;
            BntBorrar.Location = new Point(76, 273);
            BntBorrar.Margin = new Padding(3, 4, 3, 4);
            BntBorrar.Name = "BntBorrar";
            BntBorrar.Size = new Size(126, 36);
            BntBorrar.TabIndex = 24;
            BntBorrar.Text = "ACEPTAR";
            BntBorrar.TextColor = Color.SeaGreen;
            BntBorrar.UseVisualStyleBackColor = false;
            BntBorrar.Click += BntBorrar_Click;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rjButton1.BackColor = SystemColors.Control;
            rjButton1.BackgroundColor = SystemColors.Control;
            rjButton1.BorderColor = Color.SeaGreen;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 3;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.SeaGreen;
            rjButton1.Location = new Point(388, 273);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(126, 36);
            rjButton1.TabIndex = 25;
            rjButton1.Text = "CANCELAR";
            rjButton1.TextColor = Color.SeaGreen;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(593, 355);
            Controls.Add(rjButton1);
            Controls.Add(BntBorrar);
            Controls.Add(lbInformation);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox BtRestaurar;
        private PictureBox BtMinimizar;
        private PictureBox BtMaximizar;
        private PictureBox BtCerrar;
        private Label label1;
        private Label lbInformation;
        private Controles_1.Controles.RJButton BntBorrar;
        private Controles_1.Controles.RJButton rjButton1;
    }
}

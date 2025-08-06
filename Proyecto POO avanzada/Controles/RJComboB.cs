using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Controles_1.Controles
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class RJComboB : UserControl
    {

        //Campos
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumBlue;
        private Color listBackColor = Color.PaleVioletRed;
        private Color listTextColor = Color.Gray;
        private Color borderColor = Color.MediumBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmList;
        private Label lblText;
        private Button btnIcon;

        //Propiedades
        [Category("RJ Code-Appearance")]
        public new Color BackColor 
        { get
            { return backColor; }
            set 
            { backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            } 
        }
        [Category("RJ Code-Appearance")]
        public Color IconColor { get { return iconColor; } set { iconColor = value; btnIcon.Invalidate(); } }
        [Category("RJ Code-Appearance")]
        public Color ListBackColor { get { return listBackColor; } set { listBackColor = value; cmList.BackColor = listBackColor; } }
        [Category("RJ Code-Appearance")]
        public Color ListTextColor { get { return listTextColor; } set { listTextColor = value;  cmList.ForeColor = listTextColor; } }
        [Category("RJ Code-Appearance")]
        public Color BorderColor { get { return borderColor; } set { borderColor = value; base.BackColor = borderColor;  } }
        [Category("RJ Code-Appearance")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Padding = new Padding(borderSize); AdjustComboBoxDimension(); } }
        [Category("RJ Code-Appearance")]
        public override Color ForeColor 
        { get
            {
             return  base.ForeColor
                ;
            } set { base.ForeColor = value; lblText.ForeColor = value; }
        }
        [Category("RJ Code-Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            { base.Font = value; lblText.Font = value; cmList.Font = value; }
        }
        [Category("RJ Code-Appearance")]
        public string Texts
        {
            get { return lblText.Text; }

            set { lblText.Text = value; }

        }
        [Category("RJ Code-Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmList.DropDownStyle;  }

            set {if(cmList.DropDownStyle!=ComboBoxStyle.Simple) 
                cmList.DropDownStyle = value; }
        }

        //Datos

        //Evento
        public event EventHandler OnSelectedIndexChanged;

        public RJComboB()
        {
            cmList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboB:... list
            cmList.BackColor = listBackColor;
            cmList.Font = new Font(this.Font.Name, 10F);
            cmList.ForeColor = listTextColor;
            cmList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChange);
            cmList.TextChanged += new EventHandler(ComboBox_TextChanged);

            //Button Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;

            btnIcon.Click += new EventHandler(Icon_ClicK); //abrir la lista
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            //label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.BackColor = backColor;
            lblText.AutoSize = false;
            lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(0, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);//Select Comb

            //User 
            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmList); //0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimension();
        }

        private void AdjustComboBoxDimension()
        {
            cmList.Width = lblText.Width;
            cmList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmList.Width,
                Y = lblText.Bottom - cmList.Height

            };

        }

        private void Surface_Click(object? sender, EventArgs e)
        {
            cmList.Select();
            if (cmList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmList.DroppedDown = true;
        }

        private void Icon_ClicK(object? sender, EventArgs e)
        {

            cmList.Select();
            cmList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            lblText.Text = cmList.Text;
        }

        private void ComboBox_SelectedIndexChange(object? sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            //R. Text
            lblText.Text = cmList.Text;
        }

        private void Icon_Paint(object? sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 14;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            using(GraphicsPath path=new GraphicsPath())
                using(Pen pen= new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right,rectIcon.Y);
                graph.DrawPath(pen, path);
                
            }
        }
    }
}

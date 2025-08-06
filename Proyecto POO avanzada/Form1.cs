using System.Runtime.InteropServices;

namespace VERSION_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtMaximizar.Visible = false;
            BtRestaurar.Visible = true;
        }

        private void BtMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtMaximizar.Visible = true;
            BtRestaurar.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BntBorrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios.Texts == "Censa" && txtClave.Texts == "12345")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOS DATOS INGRESADOS SON INGRESADOS");
                txtUsuarios.Clear();
                txtClave.Clear();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtUsuarios.Clear();
            txtClave.Clear();
        }
    }
}

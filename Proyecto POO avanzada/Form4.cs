using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;

namespace VERSION_FINAL
{

    public partial class Form4 : Form

    {
        int poc;
        public Form4()
        {
            InitializeComponent();
            Clases.CEstudiantes objetoAlumnos = new Clases.CEstudiantes();
            objetoAlumnos.mostrarAlumnos(dataGridView1);
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
        private void MoverVentana()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)

        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                poc = e.RowIndex;

                TxtCedula.Texts = dataGridView1[0, poc].Value?.ToString() ?? "";
                Tipo_Documento.Text = dataGridView1[1, poc].Value?.ToString() ?? "";
                TxtNombre.Texts = dataGridView1[2, poc].Value?.ToString() ?? "";
                TxtApellido.Texts = dataGridView1[3, poc].Value?.ToString() ?? "";
                CbGenero.Text = dataGridView1[4, poc].Value?.ToString() ?? "";
                TxtDireccion.Texts = dataGridView1[5, poc].Value?.ToString() ?? "";
                TxtEmail.Texts = dataGridView1[6, poc].Value?.ToString() ?? "";
                Txtelefono.Texts = dataGridView1[7, poc].Value?.ToString() ?? "";
                TxtContacto.Texts = dataGridView1[8, poc].Value?.ToString() ?? "";
                Nacimiento.Text = dataGridView1[9, poc].Value?.ToString() ?? "";
                CbRh.Text = dataGridView1[10, poc].Value?.ToString() ?? "";
                id_Valor.Texts = dataGridView1[11, poc].Value?.ToString() ?? "";

            }


        }

        private void BntMostrar_Click(object sender, EventArgs e)
        {
            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerconexion();
        }

        private void RJBRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=censa;User ID=root;Password=;";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();


                    string insertQuery = @"
                       INSERT INTO estudiantes 
                       (id_Documento, id_Tipo_Documento, Nombre, Apellido, id_Genero, Direccion, Correo, Telefono, Contacto, Fecha_Nacimiento, RH, id_Valor) 
                        VALUES (@documento, @tipoDoc, @nombre, @apellido, @genero, @direccion, @correo, @telefono, @contacto, @nacimiento, @rh, @valor);";



                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@documento", TxtCedula.Texts);
                        insertCommand.Parameters.AddWithValue("@tipoDoc", Tipo_Documento.Text);
                        insertCommand.Parameters.AddWithValue("@nombre", TxtNombre.Texts);
                        insertCommand.Parameters.AddWithValue("@apellido", TxtApellido.Texts);
                        insertCommand.Parameters.AddWithValue("@genero", CbGenero.Text);
                        insertCommand.Parameters.AddWithValue("@direccion", TxtDireccion.Texts);
                        insertCommand.Parameters.AddWithValue("@correo", TxtEmail.Texts);
                        insertCommand.Parameters.AddWithValue("@telefono", Txtelefono.Texts);
                        insertCommand.Parameters.AddWithValue("@contacto", TxtContacto.Texts);
                        insertCommand.Parameters.AddWithValue("@nacimiento", DateTime.Parse(Nacimiento.Text));
                        insertCommand.Parameters.AddWithValue("@rh", CbRh.Text);
                        insertCommand.Parameters.AddWithValue("@valor", id_Valor.Texts);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} fila(s) insertada(s).");

                        RefrescarDataGridView();
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void RefrescarDataGridView()
        {
            Clases.CEstudiantes objetoAlumnos = new Clases.CEstudiantes();
            objetoAlumnos.mostrarAlumnos(dataGridView1);
        }

        private void BntBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string? idDocumento = dataGridView1[0, selectedIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(idDocumento))
                {

                    DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el registro con ID {idDocumento}?",
                                                                "Confirmación de eliminación",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string connectionString = "Server=localhost;Database=censa;User ID=root;Password=;";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();


                                string deleteQuery = "DELETE FROM estudiantes WHERE id_Documento = @idDocumento";

                                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@idDocumento", idDocumento);
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {

                                        dataGridView1.Rows.RemoveAt(selectedIndex);

                                        MessageBox.Show("Registro eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se encontró el registro a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}

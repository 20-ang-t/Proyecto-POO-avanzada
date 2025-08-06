using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERSION_FINAL.Clases
{
    internal class CEstudiantes
    {

        public void mostrarAlumnos(DataGridView tsblaEstudiantes)
        {

            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "select * from estudiantes";
                tsblaEstudiantes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerconexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tsblaEstudiantes.DataSource = dt;
                objetoConexion.cerrarConexion();


            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, ERROR"+ ex.ToString());

            }


        }
    }
}

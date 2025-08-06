using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace VERSION_FINAL.Clases
{
    internal class CConexion 
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd="censa";
        static string usuario="root";
        static string password="";
        static string puerto="3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public MySqlConnection establecerconexion()
        {
            try 
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                      }

            catch(MySqlException e)
            {
                MessageBox.Show("No se pude conectar a la base de datos, ERROR" + e.ToString());

            }
            return conex;


        }


        public void cerrarConexion()
        { 
            conex.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login_MySQL
{
    class Conexion
    {
        public static MySqlConnection GetConnection()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "123456";
            string db = "sistema_usuarios";


            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + db;

            MySqlConnection Conexion = new MySqlConnection(cadenaConexion);

            return Conexion;
        }

    }
}

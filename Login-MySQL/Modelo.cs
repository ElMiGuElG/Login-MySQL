using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login_MySQL
{
    class Modelo
    {
        public int registro (Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "INSERT INTO usuarios (Usuarios,Contraseña,Nombre,id_Tipo) VALUES(@usuario, @contraseña, @nombre, @id_tipo)";

            MySqlCommand comando = new MySqlCommand(sql,conexion);
            comando.Parameters.AddWithValue("@usuario",usuario.Usuario);
            comando.Parameters.AddWithValue("@contraseña",usuario.Contraseña);
            comando.Parameters.AddWithValue("@nombre",usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo",usuario.Id_tipo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool usuarioingresado (string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT id FROM usuarios WHERE Usuarios LIKE @usuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuarios usuarioexistente(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            string sql = "SELECT id, Contraseña, Nombre, id_Tipo FROM usuarios WHERE Usuarios LIKE @usuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Contraseña = reader["Contraseña"].ToString();
                usr.Nombre = reader["Nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["id_Tipo"].ToString());
            }
            return usr;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logindb
{
    class modelo
    {
        public int registro(usuarios usuario)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario,contraseña,nombre,id_tipo) VALUES (@usuario,@contraseña,@nombre, @id_tipo)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", 1);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existusuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";

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
        public usuarios PorUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id,contraseña,nombre,id_tipo FROM usuarios WHERE usuario LIKE @usuario";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            usuarios usr = null;

            while (reader.Read())
            {

                usr = new usuarios();
                usr.Id = int.Parse( reader["id"].ToString());
                usr.Contraseña = reader["contraseña"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tipo =int.Parse (reader["id_tipo"].ToString());
            }

            return usr;


            
        }

    }

}

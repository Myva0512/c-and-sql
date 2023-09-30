using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logindb
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "Harmonizer";
            string bd = "SISTEMA_USUARIO";

            string cadenaconexion = "server= " + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" +password + "; database=" +bd;

           MySqlConnection conexion =    new MySqlConnection(cadenaconexion);
            return conexion;
        }

    }
}

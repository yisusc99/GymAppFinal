using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GymApp
{
    public class Conexion {
        public static MySqlConnection connector()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("server= 127.0.0.1; database=gymapp ;Uid=root;Pwd=pruebapass123;");
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return connection;
        }
    }
}

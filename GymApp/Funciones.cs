using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymApp
{
    public class Productos
    {
        public static bool newProduct(string name, double price, string desc, int amount, string cat, string img) {
            bool check = false;
            string sql = "INSERT INTO product VALUE(null, '" + name + "', " + price + ", '" + desc + "', " + amount + ", '" + cat + "', '" + img + "')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static bool deleteProduct(int id) {
            bool check = false;
            string sql = "DELETE FROM product WHERE id_product=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static DataTable getProduct(string name) {
            string query;
            if (name != null)
                query = "SELECT id_product as 'ID', name as 'Nombre',  price as 'Precio', description as 'Descripcion', amount as 'Stock', category as 'Categoria' FROM product WHERE name ='" + name + "'";
            else
                query = "SELECT id_product as 'ID', name as 'Nombre',  price as 'Precio', description as 'Descripcion', amount as 'Stock', category as 'Categoria' FROM product";

            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static bool upProduct(int id, string name, double price, string desc, int amount, string cat, string img) {
            bool check = false;
            string sql = "UPDATE product SET name='" + name + "', price=" + price + ", description='" + desc + "', amount=" + amount + ", category='" + cat + "', img='" + img + "' WHERE id_product=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static MySqlCommand clasif() {
            MySqlCommand c0 = new MySqlCommand("SELECT count(id_product) FROM product",Conexion.connector());
            MySqlDataReader vr = c0.ExecuteReader();
            MySqlCommand c2 = null;
            vr.Read();
            if (vr.GetInt32(0) != 0) {
                c2 = new MySqlCommand("SELECT DISTINCT(category) FROM product", Conexion.connector());
                return c2;
            }
            else {
                return c2;
            }
        }

    }
    public class tmp{
        public static bool setTmp(int id, string nombre, double precio, int cantidad) {
            bool check = false;
            string sql = "INSERT INTO tmp VALUE('"+id+"', '"+nombre+"', '"+precio+"', '"+cantidad+"', '"+precio*cantidad+"')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static MySqlCommand cobrar() {
            string sql = "SELECT * FROM tmp";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            return cmd;
        }
        public static bool deleteTmp(int id, int op)
        {
            bool check = false;
            string sql =null;
            if(op == 1)
                 sql = "DELETE FROM tmp WHERE id=" + id;
            else
                 sql = "TRUNCATE TABLE tmp ";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static DataTable getTmp()
        {
            string query;
                query = "SELECT * FROM tmp";
            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
    }
    public class usuario {
        public static string getUser(string user, string pass)
        {
            string tUser = null;
            MySqlCommand vr = new MySqlCommand("SELECT user, passw, rol FROM users WHERE user = '"+user+"' ", Conexion.connector());
            MySqlDataReader rd = null;

            rd = vr.ExecuteReader();
            while (rd.Read())
            {
                if (rd.GetString(0) == user && seguridad.Desencriptar(rd.GetString(1)) == pass)
                {
                    tUser = rd.GetString(2);
                    break;
                }
            }
            rd.Close();
            return tUser;
        }

        public static bool newUser(string name, string lastname, string user, string pwd, string rol, string img)
        {
            bool check = false;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "INSERT INTO users VALUE(null, '" + name + "', '" + lastname + "', '" + user + "', '" + seguridad.Encriptar(pwd) + "', '" + rol + "', '" + img + "', '" + date + "')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static bool deleteUser(int id)
        {
            bool check = false;
            string sql = "DELETE FROM users WHERE id_user=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static DataTable getUsers(string name)
        {
            string query;
            if (name != null)
                query = "SELECT id_user as 'ID', name as 'Nombre', lastname as 'Apellidos', user as 'Usuario', " +
                    "rol, admission_date as 'Fecha de ingreso' FROM users WHERE name ='" + name + "'";
            else
                query = "SELECT id_user as 'ID', name as 'Nombre', lastname as 'Apellidos', user as 'Usuario', " +
                    "rol, passw as 'Contrasena', admission_date as 'Fecha de ingreso' FROM users ";
            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static MySqlCommand getImgUsr(string name)
        {
            string query;
                query = "SELECT img FROM users WHERE user ='" + name + "'";
            MySqlCommand cmd = new MySqlCommand(query, Conexion.connector());
            return cmd;

        }
        public static MySqlCommand getIdUsr(string name)
        {
            string query;
            query = "SELECT id_user FROM users WHERE user ='" + name + "'";
            MySqlCommand cmd = new MySqlCommand(query, Conexion.connector());
            return cmd;
        }
        public static bool upUser(int id, string name, string lastname, string user, string pwd, string rol, string img)
        {
            bool check = false;
            string sql = "UPDATE users SET name='" + name + "', lastname='" + lastname + "', user = '" + user + "', passw='" + seguridad.Encriptar(pwd) + "', rol='" + rol + "', img='" + img + "' WHERE id_user=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
    }
    public class ventas {
        public static bool newSell(int id_product, int amount, double price)
        {
            bool check = false;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "INSERT INTO sales VALUE(null, " + id_product + ", " + amount + ",  " + price + ", '"+date+"')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static bool updateVenta(int amunt)
        {
            bool check = false;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "UPDATE product set amount = amount - '"+amunt+"'";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static MySqlCommand producto(string bsq) {
            string query = null;
            if (bsq != null)
                query = "SELECT id_product, name, price, description, amount, img FROM product WHERE name LIKE '%" + bsq + "%'";
            
            else
                query = "SELECT id_product, name, price, description, amount, img FROM product ";

            MySqlCommand vr = new MySqlCommand(query, Conexion.connector());
            return vr;
        }
        public static int stock(int id)
        {
            int stock = 0;
            string query = null;
            query = "SELECT amount FROM product WHERE id_product = "+id;

            MySqlCommand vr = new MySqlCommand(query, Conexion.connector());
            MySqlDataReader rd = vr.ExecuteReader();
            while (rd.Read()) {
                stock = rd.GetInt32(0);
            }

            return stock;
        }
    }
    public class reportes {
        public static DataTable getRArticulos()
        {
            string query;
            query = " SELECT  S.id_product as 'ID'," +
        "S.amount as 'Cantidad vendida', S.price " +
       " as 'Precio Acumulado', " +
       " S.s_date as 'Fecha de salida', " +
       " P.name as 'Nombre Prod.', " +
       " P.Price as 'Precio unitario', " +
       " P.category as 'Categoria' " +
       " FROM sales as S INNER JOIN product as P " +
       " ON S.id_product = P.id_product  " +
         "  ORDER BY S.price DESC ; ";

            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static DataTable getInv()
        {
            string query;
            query = "SELECT " +
            " id_product as 'ID', " +
            " name as 'Nombre', " +
            " price as 'Precio', " +
            " description as 'Descripcion', " +
            " amount as 'Cantidad disponible', " +
            " category as 'Categoria' " +
            " FROM product; ";


            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }

        public static string TotalVentas()
        {
            string total = "0";
            string sql = "SELECT SUM(price) FROM sales ";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader rd = null;

            rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total = rd.GetString(0);
                }
            return total;
        }
        public static string TotalProductos()
        {
            string total = "0";
            string sql = "SELECT SUM(price) FROM sales  GROUP BY id_product ORDER BY price DESC LIMIT 1 ;";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader rd = null;

            rd = cmd.ExecuteReader();
            while (rd.Read())
                {
                    total = rd.GetString(0);
                }
            return total;
        }
        public static string TotalTopProductos()
        {
            string total = "0";
            string sql = "SELECT id_product, sum(price) FROM sales GROUP BY id_product ORDER BY amount DESC LIMIT 5; ";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader rd = null;

            rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total = rd.GetString(1);
                }
            return total;
        }

        public static int existRep()
        {
            MySqlCommand c0 = new MySqlCommand("SELECT count(id_venta) FROM sales", Conexion.connector());
            MySqlDataReader vr = c0.ExecuteReader();
            vr.Read();
            int res = -1;
            res = vr.GetInt32(0);
            return res;
        }

        public static ArrayList GraphBarrasX()
        {
            ArrayList total = new ArrayList();
            MySqlCommand coun = new MySqlCommand("SELECT COUNT(id_venta) FROM sales", Conexion.connector());
            MySqlDataReader rdd = coun.ExecuteReader();
            rdd.Read();
            if (rdd.GetInt32(0) != 0)
            {
                string sql = "SELECT  P.name FROM sales as S INNER JOIN product as P ON S.id_product = P.id_product GROUP BY P.id_product ORDER BY S.amount DESC LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total.Add( rd.GetString(0));
                }
            }
            return total;
        }
        public static ArrayList GraphBarrasY()
        {
            ArrayList total = new ArrayList();
            MySqlCommand coun = new MySqlCommand("SELECT COUNT(id_venta) FROM sales", Conexion.connector());
            MySqlDataReader rdd = coun.ExecuteReader();
            rdd.Read();
            if (rdd.GetInt32(0) != 0)
            {

                string sql = "SELECT  SUM(S.amount) FROM sales as S INNER JOIN product as P ON S.id_product = P.id_product GROUP BY P.id_product ORDER BY S.amount DESC LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total.Add(rd.GetString(0));
                }
            }
            return total;
        }
        public static ArrayList GraphBarrasXFech( string da, string da2)
        {
            ArrayList total = new ArrayList();
            MySqlCommand coun = new MySqlCommand("SELECT COUNT(id_venta) FROM sales", Conexion.connector());
            MySqlDataReader rdd = coun.ExecuteReader();
            rdd.Read();
            if (rdd.GetInt32(0) != 0)
            {
                string sql = "SELECT  P.name FROM sales as S INNER JOIN product as P ON S.id_product = P.id_product WHERE s_date BETWEEN '"+da+"' and '"+da2+"'GROUP BY P.id_product ORDER BY S.amount DESC LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total.Add(rd.GetString(0));
                }
            }
            return total;
        }
        public static ArrayList GraphBarrasYFech(string da, string da2)
        {
            ArrayList total = new ArrayList();
            MySqlCommand coun = new MySqlCommand("SELECT COUNT(id_venta) FROM sales", Conexion.connector());
            MySqlDataReader rdd = coun.ExecuteReader();
            rdd.Read();
            if (rdd.GetInt32(0) != 0)
            {

                string sql = "SELECT  SUM(S.amount) FROM sales as S INNER JOIN product as P ON S.id_product = P.id_product WHERE s_date BETWEEN '" + da + "' and '" + da2 + "' GROUP BY P.id_product ORDER BY S.amount DESC LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total.Add(rd.GetString(0));
                }
            }
            return total;
        }
        public static DataTable getInvFech(string da, string da2)
        {
            string query;
            query = " SELECT  S.id_product as 'ID'," +
          "S.amount as 'Cantidad vendida', S.price " +
         " as 'Precio Acumulado', " +
         " S.s_date as 'Fecha de salida', " +
         " P.name as 'Nombre Prod.', " +
         " P.Price as 'Precio unitario', " +
         " P.category as 'Categoria' " +
         " FROM sales as S INNER JOIN product as P " +
         " ON S.id_product = P.id_product  " +
           " WHERE s_date BETWEEN '" + da + "' and '" + da2 + "'  ORDER BY S.price DESC ; "; 


            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }

        public static string TotalVentasFech(string da, string da2)
        {
            string total = "0";
            MySqlCommand cmds = new MySqlCommand("SELECT count(id_venta) FROM sales WHERE s_date BETWEEN '" + da + "' and '" + da2 + "'", Conexion.connector());
            MySqlDataReader rds = cmds.ExecuteReader();
            rds.Read();
            if (rds.GetInt32(0) != 0)
            {
                string sql = "SELECT SUM(price) FROM sales WHERE s_date BETWEEN '" + da + "' and '" + da2 + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total = rd.GetString(0);
                }
                return total;
            }
            else {
                return total;
            }
        }
        public static string TotalProductosFech(string da, string da2)
        {
            string total = "0";
            MySqlCommand cmds = new MySqlCommand("SELECT count(id_venta) FROM sales WHERE s_date BETWEEN '" + da + "' and '" + da2 + "'", Conexion.connector());
            MySqlDataReader rds = cmds.ExecuteReader();
            rds.Read();
            if (rds.GetInt32(0) != 0)
            {
                string sql = "SELECT SUM(price) FROM sales WHERE s_date BETWEEN '" + da + "' and '" + da2 + "'  GROUP BY id_product ORDER BY price DESC LIMIT 1 ;";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total = rd.GetString(0);
                }
                return total;
            }
            else {
                return total;
            }
        }
        public static string TotalTopProductosFech(string da, string da2)
        {
            string total = "0";
                MySqlCommand cmds = new MySqlCommand("SELECT count(id_venta) FROM sales WHERE s_date BETWEEN '" + da + "' and '" + da2 + "'", Conexion.connector());
                MySqlDataReader rds = cmds.ExecuteReader();
            rds.Read();
            if (rds.GetInt32(0) != 0)
            {
                string sql = "SELECT id_product, sum(price) FROM sales WHERE s_date BETWEEN '" + da + "' and '" + da2 + "'  GROUP BY id_product ORDER BY amount DESC LIMIT 5; ";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
                MySqlDataReader rd = null;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    total = rd.GetString(1);
                }
                return total;
            }
            else
            {
                return total;
            }
        }
    }
    public class seguridad {
        public static string Encriptar(string cadena)
        {
            string result;
            byte[] encriptar = Encoding.Unicode.GetBytes(cadena);
            result = Convert.ToBase64String(encriptar);
            return result;
        }
        public static string Desencriptar(string cadena)
        {
            string result;
            byte[] encriptar = Convert.FromBase64String(cadena);
            result = Encoding.Unicode.GetString(encriptar);
            return result;
        }
    }
}

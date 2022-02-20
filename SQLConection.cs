
using System;
using System.Data.SqlClient;
namespace Carvajal
{
    class SQLConection
    {
        public static SqlConnection conexion()
        {

            String Servidor = "localhost";
            String Database = "carvajal";
            String Usuario = "carvajal";
            String Password = "carvajal";
            try
            {

                SqlConnection conexion = new SqlConnection("server=" + Servidor + " ; database=" + Database + " ; integrated security = false;User ID=" + Usuario + ";Password=" + Password + ";");

                return conexion;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);

                return null;
            }
        }
    }
}

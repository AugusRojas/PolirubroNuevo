using System;
using System.Data.SqlClient;

namespace POLIRUBRO
{
    public static class Conexion
    {
        // Cambia esta cadena de conexión para que apunte a tu base de datos MySQL en XAMPP
        static string conexion = "Server=tcp:sql9001.site4now.net,1433;Initial Catalog=db_aafc92_sistemaventas;Persist Security Info=False;User ID=db_aafc92_sistemaventas_admin;Password=ventas2000\r\n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        // Método para obtener la conexión a la base de datos MySQL
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conector = new SqlConnection(conexion);
            try
            {
                conector.Open();
                Console.WriteLine("Conexión exitosa a la base de datos.");
                return conector;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
                return null;
            }
        }

        // Método para cerrar la conexión
        public static void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}
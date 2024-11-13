using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace POLIRUBRO
{
    public static class Conexion
    {
        // Cambia esta cadena de conexión para que apunte a tu base de datos MySQL en XAMPP
        static string conexion = "Server=localhost; Database=BD_Ventas; User ID=root; Password=; Port=3306;";

        // Método para obtener la conexión a la base de datos MySQL
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conector = new MySqlConnection(conexion);
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
        public static void CerrarConexion(MySqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}

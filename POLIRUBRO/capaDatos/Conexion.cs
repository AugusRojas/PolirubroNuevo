using System;
using System.Data.SqlClient;

namespace POLIRUBRO
{
    public static class Conexion
    {
        // Cambia esta cadena de conexión para que apunte a tu base de datos MySQL en XAMPP
        static string conexion = "Server=; Database=sistemas_de_ventas ";

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

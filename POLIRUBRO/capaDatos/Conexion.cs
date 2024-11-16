using System;
using System.Data.SqlClient;

namespace POLIRUBRO
{
    public static class Conexion
    {
<<<<<<< HEAD
        static string conexion = "server=DESKTOP-4TIIP6L\\SQLEXPRESS ; database=sistema_de_ventas ; integrated security=true";
=======
        // Cambia esta cadena de conexión para que apunte a tu base de datos MySQL en XAMPP
        static string conexion = "Server=AUGUSTO\\SQLEXPRESS; Database=sistema_de_ventas; Integrated Security=True;";
>>>>>>> 12c0fafb6b43d9d74eced38ccc5888ada47fe6c9

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
<<<<<<< HEAD
                MessageBox.Show(ex.Message);
=======
                Console.WriteLine("Error de conexión: " + ex.Message);
>>>>>>> 12c0fafb6b43d9d74eced38ccc5888ada47fe6c9
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

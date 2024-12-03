using System;
using System.Data.SQLite;

namespace POLIRUBRO
{
    public static class Conexion
    {
        static string conexion = "Data Source=sistema_de_ventas.db; Version=3;";

        public static SQLiteConnection obtenerConexion()
        {
            SQLiteConnection conector = new SQLiteConnection(conexion);
            try
            {
                conector.Open();
                Console.WriteLine("Conexión exitosa a la base de datos SQLite.");
                return conector;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
                return null;
            }
        }

        public static void CerrarConexion(SQLiteConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}

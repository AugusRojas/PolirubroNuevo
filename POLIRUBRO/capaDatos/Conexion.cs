using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POLIRUBRO
{
    public static class Conexion
    {
        static string conexion = "Server=AUGUSTO\\SQLEXPRESS; Database=sistema_de_ventas; integrated security=True";

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conector = new SqlConnection(conexion);
            try
            {
                conector.Open();
<<<<<<< HEAD
=======
                //MessageBox.Show("Conexion Exitosa");
>>>>>>> 78feb2bd9ec28cfdab600499dd669b1c9f8d4f51
                return conector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public static SqlConnection cerrarConexion()
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            conexion.Close();
            return conexion;
        }


    }
}

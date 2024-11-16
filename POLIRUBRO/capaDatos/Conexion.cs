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
        static string conexion = "server=DESKTOP-4TIIP6L\\SQLEXPRESS ; database=sistema_de_ventas ; integrated security=true";

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conector = new SqlConnection(conexion);
            try
            {
                conector.Open();
                return conector;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

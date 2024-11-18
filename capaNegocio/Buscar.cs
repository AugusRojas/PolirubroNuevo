using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Importar la biblioteca para MySQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIRUBRO
{
    public class Buscar
    {
        public void buscar_producto(string nombre)
        {
            SqlConnection conexion = Conexion.obtenerConexion(); // Usar MySqlConnection
            string consulta = $"SELECT * FROM Producto WHERE Nombre = @Nombre"; // Consulta ajustada

            SqlCommand comando = new SqlCommand(consulta, conexion); // Usar MySqlCommand
            comando.Parameters.AddWithValue("@Nombre", nombre); // Usar parámetros de forma segura

            SqlDataAdapter adaptador = new SqlDataAdapter(comando); // Usar MySqlDataAdapter
            // Puedes agregar aquí el código para ejecutar la consulta y procesar los resultados si es necesario.
        }
    }
}

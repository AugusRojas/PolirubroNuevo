using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient; // Importar la biblioteca para MySQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIRUBRO
{
    public class Buscar
    {
        public void buscar_producto(string nombre)
        {
            MySqlConnection conexion = Conexion.ObtenerConexion(); // Usar MySqlConnection
            string consulta = $"SELECT * FROM Producto WHERE Nombre = @Nombre"; // Consulta ajustada

            MySqlCommand comando = new MySqlCommand(consulta, conexion); // Usar MySqlCommand
            comando.Parameters.AddWithValue("@Nombre", nombre); // Usar parámetros de forma segura

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando); // Usar MySqlDataAdapter
            // Puedes agregar aquí el código para ejecutar la consulta y procesar los resultados si es necesario.
        }
    }
}

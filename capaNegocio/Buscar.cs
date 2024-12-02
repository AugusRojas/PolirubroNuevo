using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace POLIRUBRO
{
    public class Buscar
    {
        public void buscar_producto(string nombre)
        {
            SQLiteConnection conexion = Conexion.obtenerConexion(); 
            string consulta = $"SELECT * FROM Producto WHERE Nombre = @Nombre"; 

            SQLiteCommand comando = new SQLiteCommand(consulta, conexion); 
            comando.Parameters.AddWithValue("@Nombre", nombre); 

            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando); // Usar SQLiteDataAdapter
                                                                          // Puedes agregar aquí el código para ejecutar la consulta y procesar los resultados si es necesario.
        }
    }
}

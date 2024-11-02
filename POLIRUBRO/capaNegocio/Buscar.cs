using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIRUBRO
{
    public class Buscar
    {
        public void buscar_producto(string nombre)
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            string consulta = $"selec * from Producto" +
                $"where Nombre == '{nombre}'";
               
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.Parameters.AddWithValue("@Nombre",nombre);


        }

    }
}

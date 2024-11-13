using MySql.Data.MySqlClient;
using POLIRUBRO;
using System;
using System.IO;
using System.Windows.Forms;

public class Reporte
{
    public void generarReporteCSV()
    {
        // Aquí se coloca la conexión a tu base de datos MySQL
        MySqlConnection conexion = Conexion.ObtenerConexion();

        // Definimos la consulta que queremos ejecutar para obtener los datos
        string consulta = "SELECT * FROM Producto"; // Puedes ajustar esta consulta a lo que necesites
        MySqlCommand comando = new MySqlCommand(consulta, conexion);

        try
        {
            // Ejecutamos la consulta y obtenemos los resultados
            MySqlDataReader lector = comando.ExecuteReader();

            // Creamos un archivo CSV donde vamos a guardar los resultados
            string filePath = "reporte_productos.csv";  // Ruta donde se guardará el archivo
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Escribimos los encabezados (si lo deseas, puedes tomar los nombres de las columnas)
                writer.WriteLine("Id_Producto,Id_Proveedor,Id_Categoria,Codigo_barra,Nombre,Stock,Precio,Id_Unidad,Fraccionable");

                // Escribimos cada fila de datos
                while (lector.Read())
                {
                    string linea = $"{lector["Id_Producto"]},{lector["Id_Proveedor"]},{lector["Id_Categoria"]}," +
                                   $"{lector["Codigo_barra"]},{lector["Nombre"]},{lector["Stock"]},{lector["Precio"]}," +
                                   $"{lector["Id_Unidad"]},{lector["Fraccionable"]}";

                    writer.WriteLine(linea); // Escribir la línea en el archivo CSV
                }
            }

            MessageBox.Show("Reporte generado con éxito", "Generación de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al generar el reporte: " + ex.Message);
        }
        finally
        {
            conexion.Close();  // Cerramos la conexión a la base de datos
        }
    }
}

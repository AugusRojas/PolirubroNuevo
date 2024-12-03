using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using POLIRUBRO.capaNegocio;

namespace POLIRUBRO.capaDatos
{
    public class Clase_Datos_Proveedores
    {
        public DataTable Buscar_Proveedores(string filtro, string palabra_escrita)
        {
            DataTable datos = new DataTable();
            datos.Columns.Add("Id_Proveedor", typeof(int));
            datos.Columns.Add("Nombre_proveedor", typeof(string));
            datos.Columns.Add("CUIT", typeof(string));
            datos.Columns.Add("Domicilio", typeof(string));
            datos.Columns.Add("Telefono", typeof(string));

            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();

                string consulta = $@"SELECT 
                                    Id_Proveedor, Nombre_proveedor,
                                    CUIT, Domicilio, Telefono
                                    FROM Proveedor
                                    WHERE {filtro} LIKE '%' || @palabra || '%'";

                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@palabra", palabra_escrita);

                SQLiteDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    DataRow fila = datos.NewRow();
                    fila["Id_Proveedor"] = leer["Id_Proveedor"];
                    fila["Nombre_proveedor"] = leer["Nombre_proveedor"].ToString();
                    fila["CUIT"] = leer["CUIT"].ToString();
                    fila["Domicilio"] = leer["Domicilio"].ToString();
                    fila["Telefono"] = leer["Telefono"].ToString();
                    datos.Rows.Add(fila);
                }

                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar proveedores: {ex.Message}");
            }

            return datos;
        }

        public void Insertar_Proveedor(CargarProveedor.Proveedor proveedor)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();

                string consulta = "INSERT INTO Proveedor (Nombre_proveedor, CUIT, Domicilio, Telefono) VALUES (@Nombre, @CUIT, @Domicilio, @Telefono)";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                comando.Parameters.AddWithValue("@CUIT", proveedor.CUIT);
                comando.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar proveedor: {ex.Message}");
            }
        }

        public void Modificar_Proveedor(CargarProveedor.Proveedor proveedor)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();

                string consulta = "UPDATE Proveedor SET Nombre_proveedor = @Nombre, CUIT = @CUIT, Domicilio = @Domicilio, Telefono = @Telefono WHERE Id_Proveedor = @Id";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Id", proveedor.Id);
                comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                comando.Parameters.AddWithValue("@CUIT", proveedor.CUIT);
                comando.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar proveedor: {ex.Message}");
            }
        }

        public void Eliminar_Proveedor(int id)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();

                string consulta = "DELETE FROM Proveedor WHERE Id_Proveedor = @Id";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Id", id);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar proveedor: {ex.Message}");
            }
        }
    }
}

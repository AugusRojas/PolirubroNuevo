using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace POLIRUBRO.capaDatos
{
    public class Clase_cdatos_facturacion
    {
        public DataTable Buscar_Productos_Nombre_Categoria(string filtro, string palabra_escrita)
        {
            DataTable datos = new DataTable();
            datos.Columns.Add("Id_Producto", typeof(int));
            datos.Columns.Add("Codigo_barra", typeof(string));
            datos.Columns.Add("Nombre", typeof(string));
            datos.Columns.Add("Stock", typeof(decimal));
            datos.Columns.Add("Precio", typeof(decimal));
            datos.Columns.Add("Categoria", typeof(string));
            datos.Columns.Add("Unidad", typeof(string));
            datos.Columns.Add("Fraccionable", typeof(string));

            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = $@"SELECT 
                                        Producto.Id_Producto,
                                        Producto.Codigo_barra,
                                        Producto.Nombre,
                                        Producto.Stock,
                                        Producto.Precio,
                                        Categoria.Nombre_categoria AS Categoria, 
                                        Unidad.Nombre_unidad AS Unidad,
                                        CASE 
                                        WHEN Producto.Fraccionable = 1 THEN 'Sí'
                                        ELSE 'No'
                                        END AS Fraccionable
                                        FROM 
                                        Producto 
                                        LEFT JOIN Categoria ON Producto.Id_Categoria = Categoria.Id_Categoria
                                        LEFT JOIN Unidad ON Producto.Id_Unidad = Unidad.Id_Unidad  
                                        WHERE {filtro} LIKE '%' || @palabra || '%'";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@palabra", palabra_escrita);
                        using (SQLiteDataReader leer = comando.ExecuteReader())
                        {
                            while (leer.Read())
                            {
                                DataRow fila = datos.NewRow();
                                fila["Id_Producto"] = leer["Id_Producto"];
                                fila["Codigo_barra"] = leer["Codigo_barra"].ToString();
                                fila["Nombre"] = leer["Nombre"];
                                fila["Stock"] = leer["Stock"];
                                fila["Precio"] = leer["Precio"];
                                fila["Categoria"] = leer["Categoria"];
                                fila["Unidad"] = leer["Unidad"].ToString();
                                fila["Fraccionable"] = leer["Fraccionable"];
                                datos.Rows.Add(fila);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar productos: {ex.Message}");
            }

            return datos;
        }

        public void Descontar_stock_datos(Dictionary<string, double> stock_nuevo)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    foreach (var s in stock_nuevo)
                    {
                        string consulta = "UPDATE Producto SET Stock = @Stock WHERE Codigo_barra = @Codigo";

                        using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Stock", s.Value);
                            comando.Parameters.AddWithValue("@Codigo", s.Key);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Stock actualizado");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void insert_datos_venta(int id_metodo_pago, TextBox total, TextBox fecha, TextBox hora, out int idVenta)
        {
            idVenta = 0;

            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = @"INSERT INTO Venta (Id_Metodo_pago, Monto_total, Fecha, Hora) VALUES (@IdMetodoPago, @MontoTotal, @Fecha, @Hora);
                                        SELECT last_insert_rowid();";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdMetodoPago", id_metodo_pago);
                        comando.Parameters.AddWithValue("@MontoTotal", decimal.Parse(total.Text));
                        comando.Parameters.AddWithValue("@Fecha", DateTime.Parse(fecha.Text).ToString("d"));
                        comando.Parameters.AddWithValue("@Hora", DateTime.Parse(hora.Text).ToString("HH:mm:ss"));

                        idVenta = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }

        public void insert_datos_producto_en_venta(int idVenta, string idProducto, string cantidad, string descuento, string subtotal)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = "INSERT INTO ProductoXVenta(Id_Venta, Id_Producto, Cantidad, Descuento, Subtotal) VALUES (@IdVenta, @IdProducto, @Cantidad, @Descuento, @Subtotal);";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdVenta", idVenta);
                        comando.Parameters.AddWithValue("@IdProducto", idProducto);
                        comando.Parameters.AddWithValue("@Cantidad", double.Parse(cantidad));
                        comando.Parameters.AddWithValue("@Descuento", double.Parse(descuento));
                        comando.Parameters.AddWithValue("@Subtotal", double.Parse(subtotal));
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el producto en la venta: {ex.Message}");
            }
        }

        public DataTable ObtenerUltimaVenta()
        {
            DataTable datos = new DataTable();

            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = "SELECT * FROM Ultima_Venta";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        datos.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la última venta: {ex.Message}");
            }

            return datos;
        }
    }
}

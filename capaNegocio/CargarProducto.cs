using DocumentFormat.OpenXml.Drawing;
using POLIRUBRO.capaNegocio;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace POLIRUBRO
{
    public class CargarProducto
    {
        public void cargarProducto(Producto p)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                string consulta = "INSERT INTO Producto (Id_Proveedor, Id_Categoria, Codigo_barra, Nombre, Stock, Precio, Id_Unidad, Fraccionable) " +
                                  "VALUES (@Id_Proveedor, @Id_Categoria, @Codigo_barra, @Nombre, @Stock, @Precio, @Id_Unidad, @Fraccionable)";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Id_Proveedor", p.proveedor);
                comando.Parameters.AddWithValue("@Id_Categoria", p.categoria);
                comando.Parameters.AddWithValue("@Codigo_barra", p.codigoBarra);
                comando.Parameters.AddWithValue("@Nombre", p.nombre);
                comando.Parameters.AddWithValue("@Stock", p.stock);
                comando.Parameters.AddWithValue("@Precio", p.precio);
                comando.Parameters.AddWithValue("@Id_Unidad", p.unidad);
                comando.Parameters.AddWithValue("@Fraccionable", p.fraccionable);

                comando.ExecuteNonQuery();
                MessageBox.Show("Producto cargado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public ComboBox cargar_comboBox(ComboBox c, string nombre_a_buscar, string t)
        {
            c.Items.Clear();
            SQLiteConnection conexion = Conexion.obtenerConexion();
            string consulta = $"SELECT {nombre_a_buscar} FROM {t}";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader lector = comando.ExecuteReader();
            c.Items.Add("Seleccione una opción...");

            while (lector.Read())
            {
                c.Items.Add(lector[$"{nombre_a_buscar}"].ToString());
            }

            conexion.Close();
            try
            {
                c.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            return c;
        }

        public void modificarProducto(Producto p)
        {
            SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                // Contar cuántos productos existen con el mismo nombre
                string consultaContar = "SELECT COUNT(*) FROM Producto WHERE Nombre = @Nombre";
                SQLiteCommand comandoContar = new SQLiteCommand(consultaContar, conexion);
                comandoContar.Parameters.AddWithValue("@Nombre", p.nombre);
                int cantidad = Convert.ToInt32(comandoContar.ExecuteScalar());

                string consulta;

                if (cantidad > 1)
                {
                    // Si hay más de un producto con el mismo nombre, actualizamos solo por Nombre
                    consulta = "UPDATE Producto SET Id_Proveedor = @Id_Proveedor, Id_Categoria = @Id_Categoria, Codigo_barra = @Codigo_barra, " +
                               "Stock = @Stock, Precio = @Precio, Id_Unidad = @Id_Unidad, Fraccionable = @Fraccionable " +
                               "WHERE Nombre = @Nombre";
                }
                else
                {
                    // Si hay un solo producto con ese nombre, actualizamos por Código de Barra
                    consulta = "UPDATE Producto SET Id_Proveedor = @Id_Proveedor, Id_Categoria = @Id_Categoria, Codigo_barra = @Codigo_barra, " +
                               "Stock = @Stock, Precio = @Precio, Id_Unidad = @Id_Unidad, Fraccionable = @Fraccionable " +
                               "WHERE Codigo_barra = @Codigo_barra";
                }

                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Id_Proveedor", p.proveedor);
                comando.Parameters.AddWithValue("@Id_Categoria", p.categoria);
                comando.Parameters.AddWithValue("@Codigo_barra", p.codigoBarra);
                comando.Parameters.AddWithValue("@Nombre", p.nombre);
                comando.Parameters.AddWithValue("@Stock", p.stock);
                comando.Parameters.AddWithValue("@Precio", p.precio);
                comando.Parameters.AddWithValue("@Id_Unidad", p.unidad);
                comando.Parameters.AddWithValue("@Fraccionable", p.fraccionable);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                    MessageBox.Show("Producto modificado exitosamente");
                else
                    MessageBox.Show("No se encontró el producto para modificar");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }


        public void eliminarProducto(int Id)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                using (var transaccion = conexion.BeginTransaction())
                {
                    string eliminarVentas = "DELETE FROM ProductoXVenta WHERE Id_Producto = @Id";
                    SQLiteCommand cmd1 = new SQLiteCommand(eliminarVentas, conexion);
                    cmd1.Parameters.AddWithValue("@Id", Id);
                    cmd1.ExecuteNonQuery();

                    string eliminarProducto = "DELETE FROM Producto WHERE Id_Producto = @Id";
                    SQLiteCommand cmd2 = new SQLiteCommand(eliminarProducto, conexion);
                    cmd2.Parameters.AddWithValue("@Id", Id);
                    cmd2.ExecuteNonQuery();

                    transaccion.Commit();
                }
                conexion.Close();
                MessageBox.Show("Producto eliminado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
        }

        public int buscar_id(string columna, string id_a_seleccionar, string tabla, string valor)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = $"SELECT {id_a_seleccionar} FROM {tabla} WHERE {columna} = @valor";
                    SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@valor", valor);

                    int resultado_id = (int?)(long?)comando.ExecuteScalar() ?? -1;
                    return resultado_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }


        public string buscar_valor_id(string selec, string columna, string tabla, int valor)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = $"SELECT {selec} FROM {tabla} WHERE {columna} = @valor";
                    SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@valor", valor);

                    // Acá no casteamos a int, porque no sabemos si es texto, número, etc.
                    object resultado = comando.ExecuteScalar();

                    // Si el resultado es nulo, devolvemos un string vacío
                    return resultado?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }


        public DataTable obtenerTabla()
        {
            using (SQLiteConnection conexion = Conexion.obtenerConexion())
            {
                try
                {

                    DataTable tabla = new DataTable();
                    // Eliminar productos con stock 0 antes de hacer la búsqueda
                    string eliminarProductos = "DELETE FROM Producto WHERE Stock = 0;";
                    SQLiteCommand comandoEliminar = new SQLiteCommand(eliminarProductos, conexion);
                    comandoEliminar.ExecuteNonQuery(); // Ejecuta la eliminación
                    string consulta = $@"SELECT 
                                        Producto.Id_Producto AS Id,
                                        Producto.Codigo_barra,
                                        Producto.Nombre,
                                        Proveedor.Nombre_proveedor,
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
                                        LEFT JOIN Proveedor ON Producto.Id_Proveedor = Proveedor.Id_Proveedor
                                        LEFT JOIN Unidad ON Producto.Id_Unidad = Unidad.Id_Unidad";  
                    SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(tabla);
                    
                    return tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }

                }
            }
        }

        public DataTable buscarProductos(string busqueda)
        {
            SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                DataTable dt = new DataTable();

                // Consulta para buscar productos
                string consulta = "SELECT Producto.Id_Producto AS Id, Proveedor.Nombre_Proveedor, Producto.Codigo_barra, Producto.Nombre, Producto.Stock, Producto.Precio, " +
                                  "Categoria.Nombre_categoria AS Categoria, Unidad.Nombre_unidad AS Unidad, Producto.Fraccionable AS Fraccionable " +
                                  "FROM Producto " +
                                  "INNER JOIN Categoria ON Producto.Id_Categoria = Categoria.Id_Categoria " +
                                  "INNER JOIN Unidad ON Producto.Id_Unidad = Unidad.Id_Unidad " +
                                  "INNER JOIN Proveedor ON Producto.Id_Proveedor = Proveedor.Id_Proveedor " +
                                  "WHERE (Producto.Codigo_barra == @busquedaBarra OR Producto.Nombre LIKE @busqueda)";

                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@busquedaBarra", busqueda);
                comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando);
                adaptador.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }


        public void insertar_medio_de_pago(string insertar)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                string consulta = "INSERT INTO Metodo_pago (Nombre_metodo_pago) VALUES (@insertar)";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@insertar", insertar);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conexion.Close(); }
        }

        public void insertar_categoria(string insertar)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                string consulta = "INSERT INTO Categoria (Nombre_categoria) VALUES (@insertar)";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@insertar", insertar);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conexion.Close(); }
        }

        public void insertar_unidad(string insertar)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                string consulta = "INSERT INTO Unidad (Nombre_unidad) VALUES(@insertar)";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@insertar", insertar);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conexion.Close(); }
        }

        public void eliminar_unidad(int eliminar)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                string consulta = "DELETE FROM Unidad WHERE Id_Unidad = @eliminar";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@eliminar", eliminar);
                comando.ExecuteNonQuery();
                MessageBox.Show("Eliminado exitosamente");
            }
            catch (Exception e) { MessageBox.Show(e.Message);}
            finally { conexion.Close(); }
            
        }

        public void eliminar_pago(int eliminar)
        {
                SQLiteConnection conexion = Conexion.obtenerConexion();
            try
            {
                string consulta = "DELETE FROM Metodo_pago WHERE Id_Metodo_pago = @eliminar";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@eliminar", eliminar);
                comando.ExecuteNonQuery();
                MessageBox.Show("Método de pago eliminado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexion.Close(); }
            
        }

        public void eliminar_categoria(int eliminar)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
                string consulta = "DELETE FROM Categoria WHERE Id_Categoria = @eliminar";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@eliminar", eliminar);

                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Categoría eliminada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

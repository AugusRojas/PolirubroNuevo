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
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
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
                conexion.Close();
                MessageBox.Show("Producto cargado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
                string consulta = "UPDATE Producto SET Id_Proveedor = @Id_Proveedor, Id_Categoria = @Id_Categoria, Codigo_barra = @Codigo_barra, " +
                                  "Stock = @Stock, Precio = @Precio, Id_Unidad = @Id_Unidad, Fraccionable = @Fraccionable " +
                                  "WHERE Codigo_barra = @Codigo_barra OR Nombre = @Nombre";
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
                conexion.Close();
                MessageBox.Show("Producto modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void eliminarProducto(int Id)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
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
        }

        public int buscar_id(string columna, string id_a_seleccionar, string tabla, string valor)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
                string consulta = $"SELECT {id_a_seleccionar} FROM {tabla} WHERE {columna} = @valor";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@valor", valor);

                int resultado_id = (int?)(long?)comando.ExecuteScalar() ?? -1;
                conexion.Close();
                return resultado_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public DataTable obtenerTabla()
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
                DataTable tabla = new DataTable();
                string consulta = "SELECT Producto.Id_Producto AS Id, Proveedor.Nombre_Proveedor, Producto.Codigo_barra, Producto.Nombre, Producto.Stock, Producto.Precio, " +
                                  "Categoria.Nombre_categoria AS Categoria, Unidad.Nombre_unidad AS Unidad, Producto.Fraccionable AS Fraccionable " +
                                  "FROM Producto " +
                                  "INNER JOIN Categoria ON Producto.Id_Categoria = Categoria.Id_Categoria " +
                                  "INNER JOIN Unidad ON Producto.Id_Unidad = Unidad.Id_Unidad " +
                                  "INNER JOIN Proveedor ON Producto.Id_Proveedor = Proveedor.Id_Proveedor";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);

                adapter.Fill(tabla);
                return tabla;
            }
            catch
            {
                return null;
            }
        }

        public DataTable buscarProductos(string busqueda)
        {
            DataTable dt = new DataTable();
            SQLiteConnection conexion = Conexion.obtenerConexion();
            string consulta = "SELECT Producto.Id_Producto AS Id, Proveedor.Nombre_Proveedor, Producto.Codigo_barra, Producto.Nombre as Producto, Producto.Stock, Producto.Precio, " +
                              "Categoria.Nombre_categoria AS Categoria, Unidad.Nombre_unidad AS Unidad, Producto.Fraccionable AS Fraccionable " +
                              "FROM Producto " +
                              "INNER JOIN Categoria ON Producto.Id_Categoria = Categoria.Id_Categoria " +
                              "INNER JOIN Unidad ON Producto.Id_Unidad = Unidad.Id_Unidad " +
                              "INNER JOIN Proveedor ON Producto.Id_Proveedor = Proveedor.Id_Proveedor " +

                              "WHERE Producto.Codigo_barra LIKE @busqueda";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando);

            adaptador.Fill(dt);
            return dt;
        }

        public void insertar_medio_de_pago(string insertar)
        {
            SQLiteConnection conexion = Conexion.obtenerConexion();
            string consulta = "INSERT INTO Metodo_pago (Nombre_metodo_pago) VALUES (@insertar)";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@insertar", insertar);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Medio de pago agregado exitosamente");
        }

        public void insertar_categoria(string insertar)
        {
            SQLiteConnection conexion = Conexion.obtenerConexion();
            string consulta = "INSERT INTO Categoria (Nombre_categoria) VALUES (@insertar)";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@insertar", insertar);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Categoría agregada exitosamente");
        }

        public void eliminar_pago(int eliminar)
        {
            try
            {
                SQLiteConnection conexion = Conexion.obtenerConexion();
                string consulta = "DELETE FROM Metodo_pago WHERE Id_Metodo_pago = @eliminar";
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@eliminar", eliminar);

                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Método de pago eliminado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

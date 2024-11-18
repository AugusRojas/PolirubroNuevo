using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIRUBRO
{
    public class CargarProducto
    {

        public void cargarProducto(Producto p)
        {
            try
            {
                SqlConnection conexion = Conexion.obtenerConexion();//creamos la conexion
                string consulta = "INSERT INTO Producto (Id_Proveedor, Id_Categoria, Codigo_barra, Nombre, Stock, Precio, Id_Unidad,Fraccionable) " +
                                                 "VALUES (@Id_Proveedor, @Id_Categoria, @Codigo_barra, @Nombre, @Stock, @Precio, @Id_Unidad,@Fraccionable)";

                SqlCommand comando = new SqlCommand(consulta, conexion);//creamos el comando
                // Agregar parámetros de forma segura
                comando.Parameters.AddWithValue("@Id_Proveedor", p.proveedor);
                comando.Parameters.AddWithValue("@Id_Categoria", p.categoria);
                comando.Parameters.AddWithValue("@Codigo_barra", p.codigoBarra);
                comando.Parameters.AddWithValue("@Nombre", p.nombre);
                comando.Parameters.AddWithValue("@Stock", p.stock);
                comando.Parameters.AddWithValue("@Precio", p.precio);
                comando.Parameters.AddWithValue("@Id_Unidad", p.unidad);
                comando.Parameters.AddWithValue("@Fraccionable", p.fraccionable);
                comando.ExecuteNonQuery();//ejecutamos la consulta
                conexion.Close();//cerramos conexion
                MessageBox.Show("Carga exitosa");//mandamos la retroalimentacion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//damos un mensaje de error en caso de error
            }
        }

        public ComboBox cargar_comboBox(ComboBox c, string nombre_a_buscar, string t)
        {
            c.Items.Clear();//Limpiamos el combobox por las dudas
            SqlConnection conexion = Conexion.obtenerConexion();//establecemos conexion
            string consulta = $"SELECT DISTINCT {nombre_a_buscar} FROM {t};";//creamos la consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);//creamos el comando
            SqlDataReader lector = comando.ExecuteReader();//lo ejecutamos

            while (lector.Read())//leemos mientra encuentre indices
            {
                c.Items.Add(lector[$"{nombre_a_buscar}"].ToString());//agrega los valores de la columna solicitada
            }
            conexion.Close();//cerramos conexion
            try
            {
                c.SelectedIndex = 0;
            }
            catch(Exception e) { MessageBox.Show(e.Message); return null; }
            // ponemos el valor por default
            return c;//retornamos el ComboBox
        }

        public int buscar_id(string columna, string id_a_seleccionar, string tabla, string valor)
        {
            try
            {
                SqlConnection conexion = Conexion.obtenerConexion();
                string consulta = $"SELECT {id_a_seleccionar} FROM {tabla} where {columna} = @nombre";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", valor);
                int resultado_id = (int?)comando.ExecuteScalar() ?? -1; // Manejar el caso de null,solo devuelvve un valor
                conexion.Close();
                return resultado_id;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
                return 1;
            }
        }
        public DataTable obtenerTabla()
        {
            try
            {
                SqlConnection conexion = Conexion.obtenerConexion();
                DataTable tabla = new DataTable();
                string consulta = "SELECT * FROM Producto";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);
                return tabla;

            } catch { return null; }

        }

        public DataTable buscarProductos(string busqueda)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = Conexion.obtenerConexion();
            string consulta = $"SELECT Nombre,Codigo_barra,Stock,Precio FROM Producto " +
                $"WHERE Nombre LIKE @busqueda";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(dt);
            return dt;
        }

        public void insertar_medio_de_pago(string insertar)
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            SqlCommand comando = new SqlCommand("insertarMetodoPago", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_metodo_pago", insertar);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Agregado medio de pago exitosamente");
        }

        public void insertar_categoria(string insertar)
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            string consulta = $"INSERT INTO Categoria (Nombre_categoria) VALUES (@insertar);";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@insertar", insertar);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Agregado medio de pago exitosamente");
        }

        public void eliminar_pago(int eliminar)
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            SqlCommand comando = new SqlCommand("eliminarPago", conexion);
            comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@eliminar", eliminar);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Eliminado medio de pago exitosamente");
        }

        public void eliminar_categoria(int eliminar)
        {
            SqlConnection conexion = Conexion.obtenerConexion();
            SqlCommand comando = new SqlCommand("eliminarCategoria", conexion);
            comando .CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@eliminar", eliminar);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Eliminado medio de pago exitosamente");
        }



    }
}

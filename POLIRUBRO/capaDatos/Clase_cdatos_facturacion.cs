using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
                SqlConnection conexion = Conexion.obtenerConexion();

                string consulta = $@"SELECT 
                                    Producto.Id_Producto, Producto.Codigo_barra,
                                    Producto.Nombre, Producto.Stock,
                                    Producto.Precio, Categoria.Nombre_categoria AS Categoria, 
                                    Unidad.Nombre_unidad AS Unidad,
              
                                    FROM Producto
                                    LEFT JOIN Categoria ON Producto.Id_Categoria = Categoria.Id_Categoria
                                    LEFT JOIN Unidad ON Producto.Id_Unidad = Unidad.Id_Unidad
                                    WHERE {filtro} LIKE '%" + palabra_escrita + "%'";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    DataRow fila = datos.NewRow();
                    fila["Id_Producto"] = leer["Id_Producto"];
                    fila["Codigo_barra"] = leer["Codigo_barra"].ToString();
                    fila["Nombre"] = leer["Nombre"];
                    fila["Stock"] = leer["Stock"].ToString();
                    fila["Precio"] = leer["Precio"].ToString();
                    fila["Categoria"] = leer["Categoria"];
                    fila["Unidad"] = leer["Unidad"].ToString();
                    fila["Fraccionable"] = leer["Fraccionable"];
                    datos.Rows.Add(fila);
                }

                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar productos: {ex.Message}");
            }


            return datos;
        }


       // public void Descontar_stock_datos(string codigo_barra, double descuento)
        //{
          //  try
            //{
              //  SqlConnection conexion = Conexion.obtenerConexion();

                //string consulta = $"update Producto set Stock = {descuento} where Codigo_barra = {codigo_barra}";

//            }
             
  //          catch
    //        {

      //      }
    
    }    //}

}

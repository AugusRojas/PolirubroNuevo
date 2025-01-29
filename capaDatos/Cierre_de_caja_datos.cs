using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace POLIRUBRO.capaDatos
{
    public class Cierre_de_caja_datos
    {

        public string Hora_apertura;
        public string Hora_cierre;
        public string Fecha;
        public Cierre_de_caja_datos(string hora_apertura, string hora_cierre, string fecha)
        {
            Hora_apertura = hora_apertura;
            Hora_cierre = hora_cierre;
            Fecha = fecha;
        }
        public DataTable ventas_de_la_caja()
        {
            if (string.IsNullOrWhiteSpace(Hora_apertura) ||
                string.IsNullOrWhiteSpace(Hora_cierre) ||
                string.IsNullOrWhiteSpace(Fecha))
            {
                MessageBox.Show("Algunos datos están vacíos o nulos en Cierre_de_caja_datos.");
                return null;
            }


            SQLiteConnection conexion = Conexion.obtenerConexion();
            DataTable table = new DataTable();

            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Cantidad", typeof(decimal));
            table.Columns.Add("Precio", typeof(decimal));
            table.Columns.Add("Subtotal", typeof(decimal));
            table.Columns.Add("Hora", typeof(string));

            try
            {
                string consulta = $@"select Producto.Nombre,ProductoXVenta.Cantidad, Producto.Precio, ProductoXVenta.Subtotal, Venta.Hora from Producto 
                            inner join ProductoXVenta on Producto.Id_Producto = ProductoXVenta.Id_Producto
                            inner join Venta on Venta.Id_Venta = ProductoXVenta.Id_Venta
                            where Venta.Hora BETWEEN '{Hora_apertura}' and '{Hora_cierre}' and Venta.Fecha = '{Fecha}'";

                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                SQLiteDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    DataRow fila = table.NewRow();
                    fila["Nombre"] = lector["Nombre"].ToString();
                    fila["Cantidad"] = Convert.ToDecimal(lector["Cantidad"]);
                    fila["Precio"] = Convert.ToDecimal(lector["Precio"]);
                    fila["Subtotal"] = Convert.ToDecimal(lector["Subtotal"]);
                    fila["Hora"] = lector["Hora"].ToString();
                    table.Rows.Add(fila);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                conexion.Close();
            }

            return table;
        }


    }
}

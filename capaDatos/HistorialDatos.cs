using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace POLIRUBRO.capaDatos
{
    internal class HistorialDatos
    {
        private readonly SQLiteConnection _conexion;

        public HistorialDatos()
        {
            _conexion = Conexion.obtenerConexion();
        }

        public DataTable TotalesPorFecha()
        {
            try
            {
                DataTable table = new DataTable();
                string query = @"
                    SELECT v.Fecha, COUNT(pxv.Id_Producto) AS Cantidad_Productos, SUM(pxv.Subtotal) AS Total
                    FROM Venta v
                    INNER JOIN ProductoXVenta pxv ON v.Id_Venta = pxv.Id_Venta
                    GROUP BY v.Fecha
                    ORDER BY v.Fecha DESC;
                ";
                SQLiteCommand command = new SQLiteCommand(query, _conexion);
                SQLiteDataAdapter ad = new SQLiteDataAdapter(command);
                ad.Fill(table);
                return table;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable DetallesPorFecha(string fecha)
        {
            try
            {
                DataTable table = new DataTable();
                string query = @"
                    SELECT p.Nombre, pxv.Cantidad, pxv.Subtotal
                    FROM Producto p
                    INNER JOIN ProductoXVenta pxv ON p.Id_Producto = pxv.Id_Producto
                    INNER JOIN Venta v ON v.Id_Venta = pxv.Id_Venta
                    WHERE v.Fecha = @Fecha;";
                SQLiteCommand command = new SQLiteCommand(query, _conexion);
                command.Parameters.AddWithValue("@Fecha", fecha);
                SQLiteDataAdapter ad = new SQLiteDataAdapter(command);
                ad.Fill(table);
                return table;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable masVendidos()
        {
            try
            {
                DataTable table = new DataTable();
                string query = "SELECT p.Nombre, SUM(pxv.Cantidad) AS Total_Vendido\r\nFROM Producto p\r\nINNER JOIN ProductoXVenta pxv ON p.Id_Producto = pxv.Id_Producto\r\nGROUP BY p.Nombre\r\nORDER BY Total_Vendido DESC\r\nLIMIT 5;";
                SQLiteCommand command = new SQLiteCommand(query, _conexion);
                SQLiteDataAdapter ad = new SQLiteDataAdapter(command);
                ad.Fill(table);
                return table;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable menosVendidos()
        {
            try
            {
                DataTable table = new DataTable();
                string query = "SELECT p.Nombre, SUM(pxv.Cantidad) AS Total_Vendido\r\nFROM Producto p\r\nINNER JOIN ProductoXVenta pxv ON p.Id_Producto = pxv.Id_Producto\r\nGROUP BY p.Nombre\r\nORDER BY Total_Vendido ASC\r\nLIMIT 5;\r\n";
                SQLiteCommand command = new SQLiteCommand(query, _conexion);
                SQLiteDataAdapter ad = new SQLiteDataAdapter(command);
                ad.Fill(table);
                return table;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable promedioVentas()
        {
            try
            {
                DataTable table = new DataTable();
                string query = "SELECT p.Nombre, AVG(pxv.Cantidad) AS Promedio_Ventas\r\nFROM Producto p\r\nINNER JOIN ProductoXVenta pxv ON p.Id_Producto = pxv.Id_Producto\r\nGROUP BY p.Nombre\r\nORDER BY Promedio_Ventas DESC;\r\n";
                SQLiteCommand command = new SQLiteCommand(query, _conexion);
                SQLiteDataAdapter ad = new SQLiteDataAdapter(command);
                ad.Fill(table);
                return table;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable historialMetodoPago(string nombrePago)
        {
            try
            {
                DataTable table = new DataTable();
                string query = "SELECT \r\n    Producto.Nombre AS Producto,\r\n    ProductoXVenta.Cantidad AS Cantidad,\r\n    ProductoXVenta.Subtotal AS Subtotal,\r\n    Venta.Fecha AS FechaVenta\r\nFROM ProductoXVenta\r\nJOIN Producto ON ProductoXVenta.Id_Producto = Producto.Id_Producto\r\nJOIN Venta ON ProductoXVenta.Id_Venta = Venta.Id_Venta\r\nJOIN Metodo_pago ON Venta.Id_Metodo_pago = Metodo_pago.Id_Metodo_pago\r\nWHERE Metodo_pago.Nombre_metodo_pago = @metodoPago\r\nORDER BY Venta.Fecha DESC;\r\n";
                SQLiteCommand command = new SQLiteCommand(query, _conexion);
                command.Parameters.AddWithValue("@metodoPago", nombrePago);
                SQLiteDataAdapter ad = new SQLiteDataAdapter(command);
                ad.Fill(table);
                return table;
            
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}

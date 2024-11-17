using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIRUBRO.capaDatos;


namespace POLIRUBRO
{
    public class Facturacion_logica
    {
        public DataTable mostrar_productos_filtro(string filtro, string palabra_escrita)
        {
            Clase_cdatos_facturacion a = new Clase_cdatos_facturacion();
            DataTable tabla = a.Buscar_Productos_Nombre_Categoria(filtro, palabra_escrita);

            return tabla;
        }

        public double Total_a_pagar(DataGridView dgv)
        {
            double total = 0;

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                if (double.TryParse(fila.Cells[6].Value.ToString(), out double valor))
                {
                    total += valor;
                }
            }

            return total;
        }

        public bool Comprobacion_Stock(TextBox cantidad, TextBox stock)
        {
            if (double.Parse(stock.Text) <= 0)
            {
                MessageBox.Show("Producto insuficiente");
                return true;
            }

            else if (double.Parse(cantidad.Text) > double.Parse(stock.Text))
            {
                MessageBox.Show("La cantidad a vender es mas que el stock disponible");
                return true;
            }

            return false;
        }

        public void Descuento_stock(Dictionary<string, double> Productos_a_vender, Dictionary<string, double> Stock_inicial)
        {
            Dictionary<string, double> Stock_nuevo = new Dictionary<string, double>();

            foreach (var producto in Productos_a_vender)
            {
                string codigo_ean = producto.Key; 
                double cantidad_a_vender = producto.Value; 
                
                if (Stock_inicial.ContainsKey(codigo_ean))
                {
                    double stock_inicial = Stock_inicial[codigo_ean]; 
                    double nuevo_stock = stock_inicial - cantidad_a_vender;

                    Stock_nuevo[codigo_ean] = nuevo_stock; 
                    
                }
                else
                {
                    MessageBox.Show($"El producto con código {codigo_ean} no existe en el stock inicial.");
                }
            }

            Clase_cdatos_facturacion a = new Clase_cdatos_facturacion();
            a.Descontar_stock_datos(Stock_nuevo);
        }


        public double Aplicar_descuento(double cantidad_a_vender, double precio, TextBox descuento)
        {

            if(descuento.Text == "")
            {
                return precio * cantidad_a_vender;
            }

            else
            {
                double subtotal = precio * cantidad_a_vender;

                double descuento_aplicado = subtotal * double.Parse(descuento.Text) / 100;

                subtotal = subtotal - descuento_aplicado;

                return subtotal;
            }

        }

        public void Insertar_venta(int id_metodo_pago, TextBox total, TextBox fecha, out int idVenta)
        {
            Clase_cdatos_facturacion g = new Clase_cdatos_facturacion();
            g.insert_datos_venta(id_metodo_pago, total, fecha, out idVenta);
        }

        public void Insertar_producto_en_venta(int idVenta, string idProducto, string cantidad, string descuento, string subtotal)
        {
            Clase_cdatos_facturacion g = new Clase_cdatos_facturacion();
            g.insert_datos_producto_en_venta(idVenta, idProducto, cantidad, descuento, subtotal);
        }



    }
}

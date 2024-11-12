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

                if (double.TryParse(fila.Cells[5].Value.ToString(), out double valor))
                {
                    total += valor;
                }
            }

            return total;
        }

        public bool Comprobacion_Stock(TextBox cantidad, TextBox stock)
        {
            if(double.Parse(stock.Text) <= 0)
            {
                MessageBox.Show("Producto insuficiente");
                return true;
            }

            else if(double.Parse(cantidad.Text) > double.Parse(stock.Text))
            {
                MessageBox.Show("La cantidad a vender es mas que el stock disponible");
                return true;
            }

            return false;
        }


    }
}

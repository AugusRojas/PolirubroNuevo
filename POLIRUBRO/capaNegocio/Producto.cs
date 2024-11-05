git using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIRUBRO.capaNegocio
{
    public class Producto
    {
        public string nombre { get; set; }
        public int proveedor { get; set; }
        public int categoria { get; set; }
        public string codigoBarra { get; set; }
        public int  stock { get; set; }
        public double precio { get; set; }
        public int unidad { get; set; }

        public Producto(){}

        public Producto(int proveedor, int categoria, string codigoBarra,string nombre, int stock, double precio, int unidad)
        {
            this.nombre = nombre;
            this.proveedor = proveedor;
            this.categoria = categoria;
            this.codigoBarra = codigoBarra;
            this.stock = stock;
            this.precio = precio;
            this.unidad = unidad;
        }
    }
}

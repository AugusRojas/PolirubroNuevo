using System;
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
        public double  stock { get; set; }
        public double precio { get; set; }
        public int unidad { get; set; }
        public int fraccionable { get; set; }

        public Producto(){}

        public Producto(int proveedor, int categoria, string codigoBarra,string nombre, double stock, double precio, int unidad,int fraccionable)
        {
            this.nombre = nombre;
            this.proveedor = proveedor;
            this.categoria = categoria;
            this.codigoBarra = codigoBarra;
            this.stock = stock;
            this.precio = precio;
            this.unidad = unidad;
            this.fraccionable = fraccionable;
        }
    }
}

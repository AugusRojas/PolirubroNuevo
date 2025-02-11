using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIRUBRO.capaDatos;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using POLIRUBRO.capaNegocio;

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

        public bool Comprobacion_Stock(ref double cantidad, TextBox stock)
        {
            double stockDisponible = double.Parse(stock.Text); // Parseamos el stock una vez.

            if (stockDisponible <= 0)
            {
                MessageBox.Show("Producto insuficiente");
                cantidad = 0; // Reseteamos cantidad.
                return true;
            }
            else if (cantidad > stockDisponible)
            {
                MessageBox.Show("La cantidad a vender es mayor que el stock disponible");
                cantidad = stockDisponible; // Ajustamos a lo máximo permitido.
                return true;
            }

            return false; // Todo OK, no hay problema con el stock.
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


        public double Aplicar_descuento(double cantidad_a_vender, double precio, double descuento)
        {

            if (descuento == 0)
            {
                return precio * cantidad_a_vender;
            }

            else
            {
                double subtotal = precio * cantidad_a_vender;

                double descuento_aplicado = subtotal * descuento / 100;

                subtotal = subtotal - descuento_aplicado;

                return subtotal;
            }

        }

        public void Insertar_venta(int id_metodo_pago, TextBox total, TextBox fecha, TextBox hora, out int idVenta)
        {
            Clase_cdatos_facturacion g = new Clase_cdatos_facturacion();
            g.insert_datos_venta(id_metodo_pago, total, fecha, hora, out idVenta);
        }

        public void Insertar_producto_en_venta(int idVenta, string idProducto, string cantidad, string descuento, string subtotal)
        {
            Clase_cdatos_facturacion g = new Clase_cdatos_facturacion();
            g.insert_datos_producto_en_venta(idVenta, idProducto, cantidad, descuento, subtotal);
        }



        public void CrearPdf(string htmlContent, string outputPdfPath)
        {
            using (FileStream fs = new FileStream(outputPdfPath, FileMode.Create))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // Convierte HTML en PDF
                using (StringReader sr = new StringReader(htmlContent))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                }

                document.Close();
            }
        }

        public void MostrarConfirmacionYAccion()
        {
            DialogResult result = MessageBox.Show("¿Deseas imprimir el comprobante?", "Imprimir Comprobante", MessageBoxButtons.YesNo);

            string htmlContent = @"
<!DOCTYPE html>
<html>
<head>
    <style>
        @page {
            size: A4;
            margin: 10mm;
        }

        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            line-height: 1.5;
        }

        .factura {
            width: 100%;
            max-width: 800px;
            margin: 0 auto;
            margin-bottom: 20px;
            padding: 20px;
            box-sizing: border-box;
            background-color: #fff;
            border: 1px solid #ccc;
            border-radius: 10px;
        }

        h2, h3 {
            text-align: center;
            margin: 10px 0;
            color: #333;
        }

        .header, .footer {
            margin-bottom: 20px;
        }

        .header-info {
            font-size: 14px;
            line-height: 1.5;
            margin-bottom: 20px;
        }

        .header-info p {
            margin: 5px 0;
        }

        .footer {
            text-align: right;
            font-size: 16px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        th, td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
            font-size: 14px;
        }

        th {
            background-color: #f4f4f4;
        }

        td {
            font-size: 13px;
        }

        .total-line {
            border-top: 2px solid #ccc;
            margin-top: 10px;
            padding-top: 10px;
        }

        .total-final {
            font-size: 18px;
            font-weight: bold;
            padding-top: 10px;
            color: #333;
            margin-bottom: 200px;
        }

        @media print {
            body {
                margin: 0;
            }

            .factura {
                border: none;
                margin-right: 100px;
                padding: 0;
                width: 100%;
                max-width: 100%;
            }

            h2, h3 {
                page-break-before: always;
            }

            .total-final {
                page-break-after: always;
            }
        }

        .fecha {
            text-align: right;
            margin-bottom: 20px;
            font-size: 16px;
        }

        h2 {
            margin-bottom: 26px;
        }

        #metodo {
            text-align: left;
            margin-top: 20px;
            font-size: 16px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div class='factura'>
        <p class='fecha'>Fecha: {FECHA}</p>
        <p class='fecha'>Hora: {HORA}</p>
        <h2>N° de Comprobante #{ID_VENTA}</h2>
        <div class='header'>
            <div class='header-info'>
                <p><strong>Polirubro:</strong> DE TODO UN POCO</p>
                <p><strong>Dirección:</strong> Alicia p de Garzon 850</p>
                <p><strong>Teléfono:</strong> 3815730404</p>
            </div>
        </div>
        <table>
            <thead>
                <tr>
                    <th>Producto</th>
                    <th>Cantidad</th>
                    <th>$/Unidad</th>
                    <th>Precio</th>
                    <th>Descuento</th>
                    <th>Subtotal</th>
                </tr>
            </thead>
            <tbody>
                {FILAS_TABLA}
            </tbody>
        </table>
        <p id='metodo'>Método de pago: {METODO_DE_PAGO}</p>
        <div class='footer'>
            <div class='total-line'></div>
            <p class='total-final'>TOTAL: $ {MONTO_TOTAL}</p>
        </div>
    </div>
</body>
</html>";

            
            Clase_cdatos_facturacion datosFacturacion = new Clase_cdatos_facturacion();
            DataTable datosUltimaVenta = datosFacturacion.ObtenerUltimaVenta();

            if (datosUltimaVenta.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos de la última venta.");
                return;
            }

            DataRow fila = datosUltimaVenta.Rows[0];

            htmlContent = htmlContent.Replace("{FECHA}", Convert.ToDateTime(fila["fecha"]).ToString("dd/MM/yyyy"));
            htmlContent = htmlContent.Replace("{ID_VENTA}", fila["Id_Venta"].ToString());
            htmlContent = htmlContent.Replace("{METODO_DE_PAGO}", fila["Metodo_de_pago"].ToString());
            htmlContent = htmlContent.Replace("{MONTO_TOTAL}", fila["Monto_total"].ToString());
            htmlContent = htmlContent.Replace("{HORA}", Convert.ToDateTime(fila["Hora"]).ToString("t"));

            string filasTabla = "";
            foreach (DataRow productoFila in datosUltimaVenta.Rows)
            {
                string producto = productoFila["Producto"].ToString();
                string cantidad = productoFila["Cantidad"].ToString();
                string unidad = productoFila["Unidad"].ToString();
                string precio = productoFila["Precio"].ToString();
                string descuento = productoFila["Descuento"].ToString();
                string subtotal = productoFila["Subtotal"].ToString();

                filasTabla += $@"
                                <tr>
                                  <td>{producto}</td>
                                  <td>{cantidad}</td>
                                  <td>{unidad}</td>
                                  <td>${precio}</td>
                                  <td>{descuento}%</td>
                                  <td>${subtotal}</td>
                                </tr>";
            }

            htmlContent = htmlContent.Replace("{FILAS_TABLA}", filasTabla);

            Creacion_dinamica_carpetas creacion = new Creacion_dinamica_carpetas();
            string carpetaComprobantes = creacion.Crear_carpeta_comprobante();

            string nombreArchivo = $"Comprobante-{DateTime.Now:yyyy-MM-dd_HH-mm}.pdf";
            string rutaArchivo = Path.Combine(carpetaComprobantes, nombreArchivo);

            CrearPdf(htmlContent, rutaArchivo);

            if (result == DialogResult.Yes)
            {
                ImprimirPdf(rutaArchivo);
                MessageBox.Show("El comprobante ha sido guardado e impreso.");
            }
            else
            {
                MessageBox.Show("El comprobante ha sido guardado como PDF.");
            }
        }

        private void ImprimirPdf(string direccion)
        {
            try
            {
                System.Diagnostics.Process.Start(direccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar imprimir: " + ex.Message);
            }
        }


       

    }
}

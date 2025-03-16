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

namespace POLIRUBRO.capaNegocio
{
    public class Cierre_de_caja_logica
    {
        private string hora_apertura;
        private string hora_cierre;
        private string fecha;

        public Cierre_de_caja_logica()
        {

        }

        public Cierre_de_caja_logica(string hora_apertura, string hora_cierre, string fecha)
        {
            this.hora_apertura = hora_apertura;
            this.hora_cierre = hora_cierre;
            this.fecha = fecha;
        }
        public DataTable paso_del_dt()
        {
            Cierre_de_caja_datos d = new Cierre_de_caja_datos(hora_apertura, hora_cierre, fecha);

            return d.ventas_de_la_caja();
        }

        public DataTable cargar_categorias_mas_vendidas()
        {
            Cierre_de_caja_datos d = new Cierre_de_caja_datos(hora_apertura, hora_cierre, fecha);
            return d.categorias_mas_vendidas();
     
        }

        public DataTable cargar_productos_mas_vendidos()
        {
            Cierre_de_caja_datos d = new Cierre_de_caja_datos(hora_apertura, hora_cierre, fecha);
            return d.productos_mas_vendidos();
        }


        public void Impresion_ventas_de_hoy(DataGridView dt, string apertura, string cierre)
        {
            string fecha = DateTime.Now.ToString("dd/MM/yyyy"); 

            string Html = @"<!DOCTYPE html>
<html lang='es'>
<head>
    <title>Reporte de Ventas</title>
    <style>
        @page {
            size: A4;
            margin: 2cm;
        }
        
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 20px;
            background: white;
            font-size: 12pt;
            color: #333;
            line-height: 1.6;
        }

        .report-container {
            max-width: 21cm;
            margin: 0 auto;
            background: white;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }

        .header {
            text-align: center;
            margin-bottom: 40px;
            padding: 20px;
            background: linear-gradient(to right, #f8f9fa, #e9ecef);
            border-radius: 8px;
            border-bottom: 3px solid #0056b3;
        }

        .company-name {
            font-size: 28pt;
            font-weight: bold;
            margin-bottom: 15px;
            color: #0056b3;
            text-transform: uppercase;
            letter-spacing: 2px;
        }

        .report-title {
            font-size: 20pt;
            margin-bottom: 20px;
            color: #495057;
            font-weight: 500;
        }

        .info-section {
            margin-bottom: 30px;
            background: #f8f9fa;
            padding: 20px;
            border-radius: 8px;
            border-left: 4px solid #0056b3;
        }

        .info-row {
            display: flex;
            justify-content: space-between;
            margin-bottom: 12px;
            padding: 8px 0;
            border-bottom: 1px solid #dee2e6;
        }

        .info-row:last-child {
            border-bottom: none;
        }

        .info-label {
            font-weight: bold;
            color: #495057;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin: 25px 0;
            background: white;
        }

        th, td {
            border: 1px solid #dee2e6;
            padding: 12px;
            text-align: left;
        }

        th {
            background: #0056b3;
            color: white;
            font-weight: 600;
            text-transform: uppercase;
            font-size: 11pt;
        }

        tr:nth-child(even) {
            background-color: #f8f9fa;
        }

        .totals-section {
            margin-top: 40px;
            background: #f8f9fa;
            padding: 20px;
            border-radius: 8px;
            border-right: 4px solid #0056b3;
        }

        .total-amount {
            font-size: 18pt;
            font-weight: bold;
            text-align: right;
            color: #0056b3;
            padding: 15px;
            background: white;
            border-radius: 4px;
            margin-top: 15px;
            border: 2px solid #0056b3;
        }

        .footer {
            margin-top: 60px;
            text-align: center;
            font-size: 10pt;
            color: #6c757d;
            padding-top: 20px;
            border-top: 1px solid #dee2e6;
        }

        .footer p {
            margin: 5px 0;
        }

        .currency {
            font-family: 'Consolas', monospace;
            color: #495057;
        }

        @media print {
            body {
                print-color-adjust: exact;
                -webkit-print-color-adjust: exact;
            }

            .header {
                background: #f8f9fa !important;
            }

            th {
                background-color: #0056b3 !important;
                color: white !important;
            }

            .info-section,
            .totals-section {
                border-color: #0056b3 !important;
            }
        }
    </style>
</head>
<body>
    <div class='report-container'>
        <div class='header'>
            <div class='company-name'>Despensa 1112</div>
            <div class='report-title'>Reporte de Ventas Diario</div>
        </div>

        <div class='info-section'>
            <div class='info-row'>
                <span class='info-label'>Fecha:</span>
                <span>{FECHA}</span>
            </div>
            <div class='info-row'>
                <span class='info-label'> Hora de Apertura:</span>
                <span>{APERTURA}</span>
            </div>
            <div class='info-row'>
                <span class='info-label'>Hora de Cierre:</span>
                <span>{CIERRE}</span>
            </div>
        </div>

        <table>
            <thead>
                <tr>
                    <th>Producto</th>
                    <th>Cantidad</th>
                    <th>Precio</th>
                    <th>Subtotal</th>
                    <th>Hora</th>
                </tr>
            </thead>
            <tbody>
                 {T}
            </tbody>
        </table>

        <div class='totals-section'>
            <div class='total-amount'>
                Total: <span class='currency'>{TOTAL}</span>
            </div>
        </div>

        <div class='footer'>
            <p>Este documento fue generado automáticamente por el sistema</p>
            <p>© {AÑO} Despensa 1112</p>
        </div>
    </div>
</body>
</html>";

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas hoy");
                return;
            }

            var filas = new StringBuilder();

            foreach (DataGridViewRow fila in dt.Rows)
            {
                if (!fila.IsNewRow)
                {
                    string nombre = fila.Cells["Nombre"].Value?.ToString();
                    string cantidad = fila.Cells["Cantidad"].Value?.ToString();
                    string precio = fila.Cells["Precio"].Value?.ToString();
                    string subtotal = fila.Cells["Subtotal"].Value?.ToString();
                    string hora = fila.Cells["Hora"].Value?.ToString();
                   

                    filas.Append($@"<tr>
                            <td>{nombre}</td>
                            <td>{cantidad}</td>
                            <td>${precio}</td>
                            <td>{subtotal}</td>
                            <td>{hora}</td>
                        </tr>");
                }
            }

            string Total_filas = Html.Replace("{T}", filas.ToString());
            Total_filas = Total_filas.Replace("{APERTURA}", apertura);
            Total_filas = Total_filas.Replace("{CIERRE}", cierre);
            Total_filas = Total_filas.Replace("{FECHA}", fecha);
            Total_filas = Total_filas.Replace("{AÑO}", DateTime.Now.ToString("yyyy"));

            Creacion_dinamica_carpetas c = new Creacion_dinamica_carpetas();
            string carpetaVentasHoy = c.Crear_carpeta_ventas_de_hoy();

           
            string nombreArchivo = $"Ventas_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
            string outputPath = Path.Combine(carpetaVentasHoy, nombreArchivo);

            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();

                using (StringReader sr = new StringReader(Total_filas))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
            }

            MessageBox.Show("PDF generado exitosamente en: " + outputPath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text; // Biblioteca para PDF
using iTextSharp.text.pdf;
using OfficeOpenXml; // Biblioteca para Excel

namespace POLIRUBRO
{
    public class Reporte
    {
        // Obtener datos desde la base de datos
        public DataTable obtenerDatosReporte()
        {
            try
            {
                using (SqlConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = "SELECT * FROM Producto"; // Ajusta la consulta según tu base de datos
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    return tabla;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos del reporte: {ex.Message}");
            }
        }

        // Generar reporte en formato PDF
        public void generarReportePDF(DataTable data, string rutaPDF)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    PdfPTable pdfTable = new PdfPTable(data.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    foreach (DataColumn column in data.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240), // Color gris claro
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataRow row in data.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            pdfTable.AddCell(new Phrase(item?.ToString() ?? string.Empty));
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al generar el archivo PDF: {ex.Message}");
            }
        }

        // Generar reporte en formato Excel
        public void generarReporteExcel(DataTable data, string rutaArchivo)
        {
            try
            {
                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet hoja = excel.Workbook.Worksheets.Add("Reporte");

                    hoja.Cells["A1"].LoadFromDataTable(data, true);

                    using (var rango = hoja.Cells[1, 1, 1, data.Columns.Count])
                    {
                        rango.Style.Font.Bold = true;
                        rango.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        rango.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        rango.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    }

                    hoja.Cells[hoja.Dimension.Address].AutoFitColumns();

                    FileInfo archivo = new FileInfo(rutaArchivo);
                    excel.SaveAs(archivo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al generar el archivo Excel: {ex.Message}");
            }
        }
    }
}

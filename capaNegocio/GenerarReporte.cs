using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text; // Biblioteca para PDF
using iTextSharp.text.pdf;
using OfficeOpenXml; // Biblioteca para Excel
using System.Data.SQLite;
using System.Windows.Forms;
using System.Globalization;
using iTextSharp.text.pdf.draw;

namespace POLIRUBRO
{
    public class Reporte
    {
        // Obtener datos desde la base de datos
        public DataTable obtenerDatosReporte()
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = @"
SELECT 
    v.Fecha AS Fecha,
    p.Nombre AS NombreProducto,
    pxv.Cantidad AS CantidadVendida,
    v.Monto_total AS MontoTotal
FROM 
    Venta v
JOIN 
    ProductoXVenta pxv ON v.Id_Venta = pxv.Id_Venta
JOIN 
    Producto p ON pxv.Id_Producto = p.Id_Producto";


                    SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando);

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
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

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

        // Datos por mes (Funciona por favor xd)
        public DataTable ObtenerDatosReportesPorMes(int mes, int anio)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = @"
SELECT 
    v.Fecha AS Fecha,
    p.Nombre AS NombreProducto,
    pxv.Cantidad AS CantidadVendida,
    v.Monto_total AS MontoTotal
FROM 
    Venta v
JOIN 
    ProductoXVenta pxv ON v.Id_Venta = pxv.Id_Venta
JOIN 
    Producto p ON pxv.Id_Producto = p.Id_Producto";


                    var comando = new SQLiteCommand(consulta, conexion);
                    var adaptador = new SQLiteDataAdapter(comando);
                    var tabla = new DataTable();
                    adaptador.Fill(tabla);

                    var tablaFiltrada = tabla.Clone();
                    var formatos = new[] {
                "dd/MM/yyyy",
                "dd/MM/yyyy HH:mm:ss",
                "yyyy-MM-dd",
                "yyyy-MM-dd HH:mm:ss"
            };

                    foreach (DataRow row in tabla.Rows)
                    {
                        string textoFecha = row["Fecha"].ToString().Trim();
                        DateTime fecha;

                        bool parsed = DateTime.TryParseExact(textoFecha, formatos,
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

                        if (!parsed)
                        {
                            // Intenta el parse genérico con la cultura local (es-AR)
                            parsed = DateTime.TryParse(textoFecha,
                                new CultureInfo("es-AR"),
                                DateTimeStyles.None, out fecha);
                        }

                        if (parsed && fecha.Month == mes && fecha.Year == anio)
                        {
                            tablaFiltrada.ImportRow(row);
                        }
                        else if (!parsed)
                        {
                            // DEBUG: fechas que no pudo parsear
                            Console.WriteLine($"[DEBUG] Fecha no parseada: '{textoFecha}'");
                        }
                    }

                    // DEBUG final: cuántas filas filtradas
                   // MessageBox.Show($"[DEBUG] Filas filtradas para {mes:D2}/{anio}: {tablaFiltrada.Rows.Count}");

                    return tablaFiltrada;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos del reporte por mes: {ex.Message}");
            }
        }

        // Generar reporte mensual en formato PDF
        public void generarReportePDFPorMes(int mes, int anio, string rutaPDF)
        {
            try
            {
                // 1) Traer datos
                DataTable data = ObtenerDatosReportesPorMes(mes, anio);

                // DEBUG: Ver cuántas filas hay
                MessageBox.Show($"Filas obtenidas: {data.Rows.Count}", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el mes y año seleccionados.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2) Sumar el total
                decimal totalVendido = 0;
                foreach (DataRow row in data.Rows)
                {
                    if (decimal.TryParse(row["MontoTotal"].ToString(), out decimal valor))
                        totalVendido += valor;
                }

                // DEBUG: Mostrar total
                MessageBox.Show($"Total vendido calculado: {totalVendido:N2}", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3) Abrir el documento
                using (var fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                    PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    // 4) Tabla de datos
                    var pdfTable = new PdfPTable(data.Columns.Count) { WidthPercentage = 100 };
                    // Encabezados
                    foreach (DataColumn col in data.Columns)
                    {
                        var hdr = new PdfPCell(new Phrase(col.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                        {
                            BackgroundColor = new BaseColor(230, 230, 230),
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5f
                        };
                        pdfTable.AddCell(hdr);
                    }
                    // Filas
                    foreach (DataRow row in data.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            pdfTable.AddCell(new PdfPCell(new Phrase(item?.ToString() ?? string.Empty, FontFactory.GetFont(FontFactory.HELVETICA, 9)))
                            {
                                Padding = 4f
                            });
                        }
                    }
                    pdfDoc.Add(pdfTable);

                    // 5) Espacio y línea separadora
                    pdfDoc.Add(new Paragraph("\n"));
                    var separator = new LineSeparator(1f, 100f, BaseColor.DARK_GRAY, Element.ALIGN_CENTER, -1);
                    pdfDoc.Add(separator);
                    pdfDoc.Add(new Paragraph("\n"));

                    // 6) Resumen de total
                    var totalFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                    var totalPhrase = new Phrase($"Monto total vendido en el mes: {totalVendido:N2}", totalFont);
                    var totalCell = new PdfPCell(totalPhrase)
                    {
                        Colspan = data.Columns.Count,
                        Border = Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT,
                        Padding = 5f
                    };
                    var totalTable = new PdfPTable(1) { WidthPercentage = 100 };
                    totalTable.AddCell(totalCell);
                    pdfDoc.Add(totalTable);

                    pdfDoc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error al generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Generar reporte mensual en formato Excel
        public void generarReporteExcelPorMes(int mes, int anio, string rutaArchivo)
        {
            try
            {
                DataTable data = ObtenerDatosReportesPorMes(mes, anio);

                // 1) Calcular el monto total vendido
                decimal totalVendido = 0;
                foreach (DataRow row in data.Rows)
                    if (decimal.TryParse(row["MontoTotal"].ToString(), out decimal valor))
                        totalVendido += valor;

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet hoja = excel.Workbook.Worksheets.Add("Reporte");

                    // 2) Cargar los datos en la hoja
                    hoja.Cells["A1"].LoadFromDataTable(data, true);

                    // 3) Estilo para encabezados
                    using (var rango = hoja.Cells[1, 1, 1, data.Columns.Count])
                    {
                        rango.Style.Font.Bold = true;
                        rango.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        rango.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        rango.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    }

                    // 4) Autofit de columnas
                    hoja.Cells[hoja.Dimension.Address].AutoFitColumns();

                    // 5) Agregar resumen del total vendido
                    int filaResumen = data.Rows.Count + 3; // Deja una fila vacía
                    string celdaResumen = $"A{filaResumen}";
                    hoja.Cells[celdaResumen].Value = $"Monto total vendido en el mes: {totalVendido:C2}";
                    hoja.Cells[celdaResumen].Style.Font.Bold = true;
                    hoja.Cells[celdaResumen].Style.Font.Size = 12;
                    hoja.Cells[celdaResumen].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    // Combinar celdas para que abarque todo el ancho
                    hoja.Cells[filaResumen, 1, filaResumen, data.Columns.Count].Merge = true;

                    // 6) Guardar
                    FileInfo archivo = new FileInfo(rutaArchivo);
                    excel.SaveAs(archivo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al generar el archivo Excel mensual: {ex.Message}");
            }
        }

        //Aqui va para la generación del reporte de forma Anual
        public DataTable ObtenerDatosReportesPorAnio(int anio)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = @"
SELECT 
    v.Fecha AS Fecha,
    p.Nombre AS NombreProducto,
    pxv.Cantidad AS CantidadVendida,
    v.Monto_total AS MontoTotal
FROM 
    Venta v
JOIN 
    ProductoXVenta pxv ON v.Id_Venta = pxv.Id_Venta
JOIN 
    Producto p ON pxv.Id_Producto = p.Id_Producto";

                    var comando = new SQLiteCommand(consulta, conexion);
                    var adaptador = new SQLiteDataAdapter(comando);
                    var tabla = new DataTable();
                    adaptador.Fill(tabla);

                    var tablaFiltrada = tabla.Clone();
                    var formatos = new[] {
                "dd/MM/yyyy",
                "dd/MM/yyyy HH:mm:ss",
                "yyyy-MM-dd",
                "yyyy-MM-dd HH:mm:ss"
            };

                    foreach (DataRow row in tabla.Rows)
                    {
                        string textoFecha = row["Fecha"].ToString().Trim();
                        DateTime fecha;

                        bool parsed = DateTime.TryParseExact(textoFecha, formatos,
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

                        if (!parsed)
                        {
                            parsed = DateTime.TryParse(textoFecha,
                                new CultureInfo("es-AR"),
                                DateTimeStyles.None, out fecha);
                        }

                        if (parsed && fecha.Year == anio)
                        {
                            tablaFiltrada.ImportRow(row);
                        }
                        else if (!parsed)
                        {
                            Console.WriteLine($"[DEBUG] Fecha no parseada: '{textoFecha}'");
                        }
                    }

                    return tablaFiltrada;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos del reporte por año: {ex.Message}");
            }
        }

        public void generarReportePDFPorAnio(int anio, string rutaPDF)
        {
            try
            {
                DataTable data = ObtenerDatosReportesPorAnio(anio);

                MessageBox.Show($"Filas obtenidas: {data.Rows.Count}", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el año seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalVendido = 0;
                foreach (DataRow row in data.Rows)
                {
                    if (decimal.TryParse(row["MontoTotal"].ToString(), out decimal valor))
                        totalVendido += valor;
                }

                MessageBox.Show($"Total vendido calculado: {totalVendido:N2}", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (var fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                    PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    var pdfTable = new PdfPTable(data.Columns.Count) { WidthPercentage = 100 };
                    foreach (DataColumn col in data.Columns)
                    {
                        var hdr = new PdfPCell(new Phrase(col.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                        {
                            BackgroundColor = new BaseColor(230, 230, 230),
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 5f
                        };
                        pdfTable.AddCell(hdr);
                    }

                    foreach (DataRow row in data.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            pdfTable.AddCell(new PdfPCell(new Phrase(item?.ToString() ?? string.Empty, FontFactory.GetFont(FontFactory.HELVETICA, 9)))
                            {
                                Padding = 4f
                            });
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Add(new Paragraph("\n"));
                    var separator = new LineSeparator(1f, 100f, BaseColor.DARK_GRAY, Element.ALIGN_CENTER, -1);
                    pdfDoc.Add(separator);
                    pdfDoc.Add(new Paragraph("\n"));

                    var totalFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                    var totalPhrase = new Phrase($"Monto total vendido en el año: {totalVendido:N2}", totalFont);
                    var totalCell = new PdfPCell(totalPhrase)
                    {
                        Colspan = data.Columns.Count,
                        Border = Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT,
                        Padding = 5f
                    };
                    var totalTable = new PdfPTable(1) { WidthPercentage = 100 };
                    totalTable.AddCell(totalCell);
                    pdfDoc.Add(totalTable);

                    pdfDoc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error al generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void generarReporteExcelPorAnio(int anio, string rutaArchivo)
        {
            try
            {
                DataTable data = ObtenerDatosReportesPorAnio(anio);

                decimal totalVendido = 0;
                foreach (DataRow row in data.Rows)
                    if (decimal.TryParse(row["MontoTotal"].ToString(), out decimal valor))
                        totalVendido += valor;

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

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

                    int filaResumen = data.Rows.Count + 3;
                    hoja.Cells[filaResumen, data.Columns.Count - 1].Value = "Total vendido en el año:";
                    hoja.Cells[filaResumen, data.Columns.Count].Value = totalVendido;
                    hoja.Cells[filaResumen, data.Columns.Count].Style.Font.Bold = true;

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

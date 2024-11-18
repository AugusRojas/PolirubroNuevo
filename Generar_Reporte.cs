using System;
using System.Data;
using System.Windows.Forms;

namespace POLIRUBRO.capaPresentacion
{
    public partial class Generar_Reporte : Form
    {
        public Generar_Reporte()
        {
            InitializeComponent();
        }

        // generar PDF
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaDestino = @"C:\Descargas";

                if (!System.IO.Directory.Exists(rutaDestino))
                {
                    System.IO.Directory.CreateDirectory(rutaDestino);
                }

                Reporte reporte = new Reporte();
                DataTable data = reporte.obtenerDatosReporte();

                string rutaPDF = System.IO.Path.Combine(rutaDestino, "Reporte.pdf");
                reporte.generarReportePDF(data, rutaPDF);

                MessageBox.Show("Reporte en PDF generado exitosamente en C:\\Descargas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // generar Excel
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaDestino = @"C:\Descargas";

                if (!System.IO.Directory.Exists(rutaDestino))
                {
                    System.IO.Directory.CreateDirectory(rutaDestino);
                }

                Reporte reporte = new Reporte();
                DataTable data = reporte.obtenerDatosReporte();

                string rutaExcel = System.IO.Path.Combine(rutaDestino, "Reporte.xlsx");
                reporte.generarReporteExcel(data, rutaExcel);

                MessageBox.Show("Reporte en Excel generado exitosamente en C:\\Descargas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

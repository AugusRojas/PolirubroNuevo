using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using POLIRUBRO.capaNegocio;

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
                Creacion_dinamica_carpetas creacionCarpetas = new Creacion_dinamica_carpetas();

                string rutaDestino = creacionCarpetas.Crear_carpeta_reporte();

                Reporte reporte = new Reporte();
                DataTable data = reporte.obtenerDatosReporte();

                string rutaPDF = Path.Combine(rutaDestino, "Reporte.pdf");

                reporte.generarReportePDF(data, rutaPDF);

                MessageBox.Show($"Reporte en PDF generado exitosamente en:\n{rutaPDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Creacion_dinamica_carpetas creacion = new Creacion_dinamica_carpetas();

                string rutaDestino = creacion.Crear_carpeta_reporte();

                Reporte reporte = new Reporte();
                DataTable data = reporte.obtenerDatosReporte();

                string rutaExcel = Path.Combine(rutaDestino, "Reporte.xlsx");

                reporte.generarReporteExcel(data, rutaExcel);

                MessageBox.Show($"Reporte en Excel generado exitosamente en:\n{rutaExcel}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

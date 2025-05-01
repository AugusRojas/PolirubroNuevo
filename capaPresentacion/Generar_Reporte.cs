using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
using POLIRUBRO.capaNegocio;

namespace POLIRUBRO.capaPresentacion
{
    public partial class Generar_Reporte : Form
    {
        private monthPicker monthPicker;

        public Generar_Reporte()
        {
            InitializeComponent();

            // Cargar años desde 2024 hasta el año actual en el comboBoxAnio
            comboBoxAnio.Items.Add("Seleccionar Año");
            int primerAnio = 2024;
            int anioActual = DateTime.Now.Year;

            for (int anio = primerAnio; anio <= anioActual; anio++)
            {
                comboBoxAnio.Items.Add(anio);
            }
            comboBoxAnio.SelectedIndex = 0;

            // Agregar MonthPicker
            monthPicker = new monthPicker();
            monthPicker.Location = new Point(575, 47); // Posición en el formulario
            monthPicker.Width = 240;
            monthPicker.Height = 140;
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.CustomFormat = "MMMM yyyy";
            monthPicker.ShowUpDown = false;
            monthPicker.MinDate = new DateTime(2024, 12, 1); // Fecha de inicio (Segun DB)
            monthPicker.MaxDate = DateTime.Today;   // Hasta hoy
            monthPicker.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            monthPicker.BackColor = Color.White;
            monthPicker.ForeColor = Color.DarkSlateGray;
            Controls.Add(monthPicker);


            monthPicker.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            // Agregar Label descriptivo
            Label lblMes = new Label();
            lblMes.Text = "Seleccioná un mes:";
            lblMes.Location = new Point(40, 20);
            lblMes.AutoSize = true;
            this.Controls.Add(lblMes);
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

                var proceso = new System.Diagnostics.Process();
                proceso.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true
                };
                proceso.Start();
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

                var proceso = new System.Diagnostics.Process();
                proceso.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaExcel,
                    UseShellExecute = true
                };
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mes_CheckedChanged(object sender, EventArgs e)
        {
            monthPicker.Visible = Mes.Checked;
            button3.Visible = Mes.Checked;
            button4.Visible = Mes.Checked;

            if (Mes.Checked)
                Anio.Checked = false;
        }

        private void Anio_CheckedChanged(object sender, EventArgs e)
        {
            monthPicker.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            if (Anio.Checked)
            {
                Mes.Checked = false;
                comboBoxAnio.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }
            else
            {
                comboBoxAnio.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        // Botón para PDF Mensual
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Creacion_dinamica_carpetas creacion = new Creacion_dinamica_carpetas();
                string rutaDestino = creacion.Crear_carpeta_reporte();
                Reporte reporte = new Reporte();

                int mes = monthPicker.Value.Month;
                int anio = monthPicker.Value.Year;

                DataTable data = reporte.ObtenerDatosReportesPorMes(mes, anio);
                string rutaPDF = Path.Combine(rutaDestino, "Reporte_Mensual.pdf");

                reporte.generarReportePDF(data, rutaPDF);
                MessageBox.Show($"Reporte en PDF Mensual generado exitosamente en:\n{rutaPDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el PDF automáticamente
                var proceso = new System.Diagnostics.Process();
                proceso.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true
                };
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte PDF mensual: {ex.Message}");
            }
        }

        // Botón para Excel Mensual
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Creacion_dinamica_carpetas creacion = new Creacion_dinamica_carpetas();
                string rutaDestino = creacion.Crear_carpeta_reporte();
                Reporte reporte = new Reporte();

                int mes = monthPicker.Value.Month;
                int anio = monthPicker.Value.Year;

                string rutaExcel = Path.Combine(rutaDestino, "Reporte_Mensual.xlsx");

                reporte.generarReporteExcelPorMes(mes, anio, rutaExcel);
                MessageBox.Show($"Reporte en Excel Mensual generado exitosamente en:\n{rutaExcel}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el Excel automáticamente
                var proceso = new System.Diagnostics.Process();
                proceso.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaExcel,
                    UseShellExecute = true
                };
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte Excel mensual: {ex.Message}");
            }
        }

        private void comboBoxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Le hice doble click al comboBox, y ya no puedo eliminar esto xd    
        }

        // Botón Generar Reporte Anual PDF
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAnio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccioná un año.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int anio = (int)comboBoxAnio.SelectedItem;

                Creacion_dinamica_carpetas creacion = new Creacion_dinamica_carpetas();
                string rutaDestino = creacion.Crear_carpeta_reporte();
                Reporte reporte = new Reporte();

                DataTable data = reporte.ObtenerDatosReportesPorAnio(anio);
                string rutaPDF = Path.Combine(rutaDestino, $"Reporte_Anual_{anio}.pdf");

                reporte.generarReportePDF(data, rutaPDF);

                MessageBox.Show($"Reporte Anual en PDF generado exitosamente en:\n{rutaPDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var proceso = new System.Diagnostics.Process();
                proceso.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true
                };
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte PDF anual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Generar Reporte Anual Excel
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAnio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccioná un año.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int anio = (int)comboBoxAnio.SelectedItem;

                Creacion_dinamica_carpetas creacion = new Creacion_dinamica_carpetas();
                string rutaDestino = creacion.Crear_carpeta_reporte();
                Reporte reporte = new Reporte();

                string rutaExcel = Path.Combine(rutaDestino, $"Reporte_Anual_{anio}.xlsx");

                reporte.generarReporteExcelPorAnio(anio, rutaExcel);

                MessageBox.Show($"Reporte Anual en Excel generado exitosamente en:\n{rutaExcel}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var proceso = new System.Diagnostics.Process();
                proceso.StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaExcel,
                    UseShellExecute = true
                };
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte Excel anual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

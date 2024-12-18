using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIRUBRO.capaPresentacion
{
    public partial class Historial : Form
    {

        private readonly HistorialLogica _historialLogica;
        private readonly CargarProducto _cargarProducto;
        public Historial()
        {
            InitializeComponent();
            _historialLogica = new HistorialLogica();
            _cargarProducto = new CargarProducto();
        }

        private bool mostrandoDetalles = false;

        private void Historial_Load(object sender, EventArgs e)
        {
            comboBox1 = _cargarProducto.cargar_comboBox(comboBox1,"Nombre_metodo_pago", "Metodo_pago");
            dataGridView1.DataSource = _historialLogica.ObtenerTotalesPorFecha();
            mostrandoDetalles = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !mostrandoDetalles) // Solo carga detalles si no los está mostrando
            {
                string fecha = dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                dataGridView1.DataSource = _historialLogica.ObtenerDetallesPorFecha(fecha);
                mostrandoDetalles = true; // Cambiamos el estado
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _historialLogica.ObtenerTotalesPorFecha();
            mostrandoDetalles = false; // Volvemos a mostrar los totales
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _historialLogica.ObtenerMayoresVendidos();
            mostrandoDetalles = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _historialLogica.ObtenerMenoresVendidos();
            mostrandoDetalles = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _historialLogica.ObtenerPromedio();
            mostrandoDetalles = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string metodoPago = comboBox1.SelectedItem.ToString();
            if(metodoPago == "Seleccione una opción...")
            {
                MessageBox.Show("Seleccione una opción válida para el historial");
                return;
            }
            dataGridView1.DataSource = _historialLogica.ObtenerHistorial(metodoPago);
            mostrandoDetalles = true;
        }
    }
}

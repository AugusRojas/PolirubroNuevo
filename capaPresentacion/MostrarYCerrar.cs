using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIRUBRO.capaNegocio;

namespace POLIRUBRO.capaPresentacion
{
    public partial class MostrarYCerrar : Form
    {
        private string hora_apertura;
        private string hora_cierre;
        private string fecha;
        private bool permitirCierre = false;

        public MostrarYCerrar()
        {
            InitializeComponent(); // Asegúrate de llamar a InitializeComponent
            
        }

        public MostrarYCerrar(double efectivoFinal, double trasnferencia,double tarjeta ,string egresos, string hora_apertura, string hora_cierre, string fecha,string sI,string totalDiario)
        {
            InitializeComponent();
            this.hora_apertura = hora_apertura;
            this.hora_cierre = hora_cierre;
            this.fecha = fecha;
            sItxt.Text = sI;
            txtEfectivo.Text = efectivoFinal.ToString();
            txtEgresos.Text = egresos.ToString();
            txtTransferencia.Text = trasnferencia.ToString();
            label_hora_apertura.Text = hora_apertura;
            label_hora_cierre.Text = hora_cierre;
            label_fecha.Text = fecha;
            txtTotalEsperado.Text = (efectivoFinal + Convert.ToDouble(sItxt.Text) + trasnferencia + tarjeta - Convert.ToDouble(txtEgresos.Text)).ToString();
            txtTotalFinal.Text = (Convert.ToDouble(totalDiario) + Convert.ToDouble(sItxt.Text) - Convert.ToDouble(txtTotalEsperado.Text)).ToString();
        }

        private void MostrarYCerrar_Load(object sender, EventArgs e)
        {
            Cierre_de_caja_logica t = new Cierre_de_caja_logica(hora_apertura, hora_cierre, fecha);
            this.AutoSize = true;
            DataTable r = t.paso_del_dt();
            dataGridViewHistorial.DataSource = r;
            dataGridViewHistorial.RowHeadersVisible = false;
            dataGridViewProductos.DataSource = t.cargar_productos_mas_vendidos();
            dataGridViewCategorias.DataSource = t.cargar_categorias_mas_vendidas();

            label_hora_apertura.Text = hora_apertura;
            label_hora_cierre.Text = hora_cierre;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cierre_de_caja_logica p = new Cierre_de_caja_logica();
            p.Impresion_ventas_de_hoy(dataGridViewHistorial, hora_apertura, hora_cierre);
            Console.WriteLine("Se imprimio el reporte");
            var result = MessageBox.Show("¿Desea cerrar la caja?", "Cerrar caja", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();  // Cierra el formulario
                this.Dispose();
                Environment.Exit(0);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void MostrarYCerrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


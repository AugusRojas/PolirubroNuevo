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

        public MostrarYCerrar(double efectivoInicial, double efectivoFinal, double trasnferencia, double egresos)
        {
            tomardatos(efectivoFinal, efectivoFinal, trasnferencia, egresos);
        }

        public MostrarYCerrar(string hora_apertura, string hora_cierre, string fecha)
        {
            this.hora_apertura = hora_apertura;
            this.hora_cierre = hora_cierre;
            this.fecha = fecha;
            InitializeComponent();
        }

        private void MostrarYCerrar_Load(object sender, EventArgs e)
        {
            Cierre_de_caja_logica t = new Cierre_de_caja_logica(hora_apertura, hora_cierre, fecha);
            DataTable r = t.paso_del_dt();
            dataGridViewHistorial.DataSource = r;
            dataGridViewHistorial.RowHeadersVisible = false;

            label_hora_apertura.Text = hora_apertura;
            label_hora_cierre.Text = hora_cierre;
        }
        private void tomardatos(double efectivoInicial,double efectivoFinal,double trasnferencia,double egresos)
        {
            txtEfectivo.Text = (efectivoFinal - efectivoInicial).ToString();
            txtEgresos.Text = egresos.ToString();
            txtTransferencia.Text = trasnferencia.ToString();
            txtTotalFinal.Text = (Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTransferencia.Text) - Convert.ToDouble(txtEgresos.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cierre_de_caja_logica p = new Cierre_de_caja_logica();

            p.Impresion_ventas_de_hoy(dataGridViewHistorial, hora_apertura, hora_cierre);

        }
    }
}

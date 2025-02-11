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
    public partial class CierreCaja : Form
    {
        public CierreCaja(string horaApertura,string horaCierre,string saldoInicial,string totalDiario)
        {
            InitializeComponent();
            hA= horaApertura;
            hC = horaCierre;
            sI=saldoInicial;
            tD = totalDiario;
        }

        string hA;
        string hC;
        string sI;
        string tD;
        Verificar verificar = new Verificar();
        private void btnCaja_Click(object sender, EventArgs e)
        {
            if (
                !verificar.Verificar_vacio_txt(txtEfectivoTotal) ||
                !verificar.Verificar_vacio_txt(txtTrasnferenciaTotal) ||
                !verificar.Verificar_vacio_txt(txtEgresos))
            {
                MessageBox.Show("Complete todos los campos para avanzar");
            }
            else
            {
                MostrarYCerrar mostarYcerrar = new MostrarYCerrar(txtEfectivoTotal.Text,txtTrasnferenciaTotal.Text,txtEgresos.Text,hA,hC, DateTime.Now.ToString("d/M/yyyy"),sI,tD);
                mostarYcerrar.Show();
            }
        }

        private void txtEfectivoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void txtTrasnferenciaTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void txtEgresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void txtEfectivoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void CierreCaja_Load(object sender, EventArgs e)
        {

        }
    }
}

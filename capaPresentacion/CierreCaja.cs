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
        public CierreCaja(string horaApertura,string horaCierre)
        {
            InitializeComponent();
            hA = horaApertura;
            hC = horaCierre;
        }

        string hA;
        string hC;
        Verificar verificar = new Verificar();
        private void btnCaja_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_txt(txtEfectivoInicial) ||
                !verificar.Verificar_vacio_txt(txtEfectivoTotal) ||
                !verificar.Verificar_vacio_txt(txtTrasnferenciaTotal) ||
                !verificar.Verificar_vacio_txt(txtEgresos))
            {
                MessageBox.Show("Complete todos los campos para avanzar");
            }
            else
            {
                MostrarYCerrar mostarYcerrar = new MostrarYCerrar(Convert.ToDouble(txtEfectivoInicial.Text), Convert.ToDouble(txtEfectivoTotal.Text),Convert.ToDouble(txtTrasnferenciaTotal.Text),Convert.ToDouble(txtEgresos.Text),hA, hC);
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

﻿using System;
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
    public partial class MostrarYCerrar : Form
    {
        public MostrarYCerrar(double efectivoInicial, double efectivoFinal, double trasnferencia, double egresos,string horaApertura,string horaCierre)
        {
            InitializeComponent();
            tomardatos(efectivoFinal,efectivoFinal,trasnferencia,egresos,horaApertura,horaCierre);
        }

        private void MostrarYCerrar_Load(object sender, EventArgs e)
        {

        }
        private void tomardatos(double efectivoInicial,double efectivoFinal,double trasnferencia,double egresos,string horaApertura,string horaCierre)
        {
            txtEfectivo.Text = (efectivoFinal - efectivoInicial).ToString();
            txtEgresos.Text = egresos.ToString();
            txtTransferencia.Text = trasnferencia.ToString();
            txtTotalFinal.Text = (Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTransferencia.Text) - Convert.ToDouble(txtEgresos.Text)).ToString();
            labelHoraApertura.Text = horaApertura;
            labelHoraCierre.Text = horaCierre;
        }
    }
}

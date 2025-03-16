using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIRUBRO.capaDatos;

namespace POLIRUBRO.capaPresentacion
{
    public partial class AperturaCajacs : Form
    {
        public AperturaCajacs()
        {
            InitializeComponent();
        }
        Caja caja = new Caja();
        Verificar verificar = new Verificar();
        CargarProducto cargarProducto = new CargarProducto();

        private void AperturaCajacs_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
            boxCaja = cargarProducto.cargar_comboBox(boxCaja, "Turno", "Caja");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_hora_apertura.Text = DateTime.Now.ToString("T");
        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(sender, e);
        }

        private void txtNumeroCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario u = new AgregarUsuario();
            u.Show();
            this.Hide();
            u.FormClosed += (s, args) => this.Show();
        }

        private void btnAperturaCaja_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxCaja) ||
                !verificar.Verificar_vacio_txt(txtEncargadoNombre) ||
                !verificar.Verificar_vacio_txt(txtSaldoInicial))
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                int numero = cargarProducto.buscar_id("Turno", "Id_Caja", "Caja", boxCaja.Text);
                if (caja.ingresar(txtSaldoInicial.Text, txtEncargadoNombre.Text, numero))
                {
                    var facturacion = new Facturacion(txtSaldoInicial.Text);
                    this.Hide();
                    facturacion.Hora_apertura = textBox_hora_apertura.Text;
                    facturacion.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
        }

        
    }
}

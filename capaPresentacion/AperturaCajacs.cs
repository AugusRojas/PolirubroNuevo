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
        private void btnAperturaCaja_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxCaja)||
                !verificar.Verificar_vacio_txt(txtEncargadoNombre)||
                !verificar.Verificar_vacio_txt(txtSaldoInicial))
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                int numero = cargarProducto.buscar_id("Turno", "Id_Caja", "Caja", boxCaja.Text);
                if (caja.ingresar(txtSaldoInicial.Text ,txtEncargadoNombre.Text,numero))
                {
                    var facturacion = new Facturacion();
                    this.Hide();
                    facturacion.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                

            }
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

        private void AperturaCajacs_Load(object sender, EventArgs e)
        {
            boxCaja = cargarProducto.cargar_comboBox(boxCaja,"Turno","Caja");


            
        }
    }
}

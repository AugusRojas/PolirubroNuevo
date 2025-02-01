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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }
        Caja caja = new Caja();
        Verificar verificar = new Verificar();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!verificar.Verificar_vacio_txt(txtNombre))
                {
                    MessageBox.Show("Complete todos los campos");
                }
                else
                {
                    if (caja.agregarUsuario(txtNombre.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        txtNombre.Clear();
                        return;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

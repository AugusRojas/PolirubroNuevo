using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POLIRUBRO.capaPresentacion
{
    public partial class categoria_metodo_pago : Form
    {
        public categoria_metodo_pago()
        {
            InitializeComponent();
        }
        CargarProducto cargarProducto = new CargarProducto();
        Verificar verificar = new Verificar();
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_txt(textBox1))
            {
                MessageBox.Show("No se permiten campos vacios","Carga categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cargarProducto.insertar_categoria(textBox1.Text);
                boxCategoria = cargarProducto.cargar_comboBox(boxCategoria, "Nombre_categoria", "Categoria");
            }
        }

        private void categoria_metodo_pago_Load(object sender, EventArgs e)
        {
            boxCategoria = cargarProducto.cargar_comboBox(boxCategoria,"Nombre_categoria","Categoria");
            boxPago = cargarProducto.cargar_comboBox(boxPago, "Nombre_metodo_pago", "Metodo_pago");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(e);
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_txt(textBox2))
            {
                MessageBox.Show("No se permiten campos vacios", "Carga metodo de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cargarProducto.insertar_medio_de_pago(textBox2.Text);
                boxPago = cargarProducto.cargar_comboBox(boxPago, "Nombre_metodo_pago", "Metodo_pago");
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxPago))
            {
                MessageBox.Show("No se permiten campos vacios", "Eliminar metodo de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cargarProducto.eliminar_pago(cargarProducto.buscar_id("Nombre_metodo_pago","Id_Metodo_pago","Metodo_pago",boxPago.SelectedItem.ToString()));
                boxPago = cargarProducto.cargar_comboBox(boxPago, "Nombre_metodo_pago", "Metodo_pago");
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxPago))
            {
                MessageBox.Show("No se permiten campos vacios", "Eliminar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                cargarProducto.eliminar_categoria(cargarProducto.buscar_id("Nombre_categoria", "Id_Categoria", "Categoria", boxCategoria.SelectedItem.ToString()));
                boxCategoria = cargarProducto.cargar_comboBox(boxCategoria, "Nombre_categoria", "Categoria");
            }
        }


    }
}

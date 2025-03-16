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
    

        private void categoria_metodo_pago_Load(object sender, EventArgs e)
        {
            boxCategoria = cargarProducto.cargar_comboBox(boxCategoria,"Nombre_categoria","Categoria");
            boxPago = cargarProducto.cargar_comboBox(boxPago, "Nombre_metodo_pago", "Metodo_pago");
            boxUnidad = cargarProducto.cargar_comboBox(boxUnidad, "Nombre_Unidad", "Unidad");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(sender,e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(sender,e);
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxPago))
            {
                MessageBox.Show("No se permiten campos vacíos", "Eliminar método de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Console.WriteLine(boxPago.SelectedItem.ToString());
                    int idPago = cargarProducto.buscar_id("Nombre_metodo_pago", "Id_Metodo_pago", "Metodo_pago", boxPago.SelectedItem.ToString());
                    cargarProducto.eliminar_pago(idPago);
                    boxPago = cargarProducto.cargar_comboBox(boxPago, "Nombre_metodo_pago", "Metodo_pago");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar método de pago: " + ex.Message);
                }
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxCategoria))
            {
                MessageBox.Show("No se permiten campos vacíos", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Console.WriteLine(boxCategoria.SelectedItem.ToString());
                    int idCategoria = cargarProducto.buscar_id("Nombre_categoria", "Id_Categoria", "Categoria", boxCategoria.SelectedItem.ToString());
                    cargarProducto.eliminar_categoria(idCategoria);
                    boxCategoria = cargarProducto.cargar_comboBox(boxCategoria, "Nombre_categoria", "Categoria");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar categoría: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_comboBox(boxUnidad))
            {
                MessageBox.Show("No se permiten campos vacíos", "Eliminar Unidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Console.WriteLine(boxUnidad.SelectedItem.ToString());
                    int idUnidad = cargarProducto.buscar_id("Nombre_unidad", "Id_Unidad", "Unidad", boxUnidad.SelectedItem.ToString());
                    cargarProducto.eliminar_unidad(idUnidad);
                    boxUnidad = cargarProducto.cargar_comboBox(boxUnidad, "Nombre_unidad", "Unidad");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar unidad: " + ex.Message);
                }
            }
        }


    }
}

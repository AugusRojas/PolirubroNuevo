using POLIRUBRO.capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIRUBRO.capaPresentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        //Creo un objeto cargaProducto
        CargarProducto cargarProducto = new CargarProducto();
        Verificar verificar = new Verificar();


        private void Productos_Load(object sender, EventArgs e)
        {
            dataGridViewBuscar.DataSource = cargarProducto.obtenerTabla();
            dataGridViewBuscar.AllowUserToAddRows = false;
            //Cargo inicialmente los valores a los Combo box desde la base de datos
            boxCategoria = cargarProducto.cargar_comboBox(boxCategoria,"Nombre_categoria","Categoria");
            boxProveedor = cargarProducto.cargar_comboBox(boxProveedor, "Nombre_proveedor", "Proveedor");
            boxUnidad = cargarProducto.cargar_comboBox(boxUnidad, "Nombre_Unidad", "Unidad");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            //Extraigo los datos del formulario y verifico que no esten vacios
            if (!verificar.Verificar_vacio_comboBox(boxProveedor) ||
                    !verificar.Verificar_vacio_comboBox(boxCategoria) ||
                    !verificar.Verificar_vacio_txt(txtCodigoBarra) ||
                    !verificar.Verificar_vacio_txt(txtProducto) ||
                    !verificar.Verificar_vacio_txt(txtStock) ||
                    !verificar.Verificar_vacio_txt(txtPrecio) ||
                    !verificar.Verificar_vacio_comboBox(boxUnidad) ||
                    !verificar.Verificar_vacio_comboBox(boxFraccionable))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Finaliza el proceso si hay campos vacíos
            }
            // Asignación de valores si todos los campos están 

            if (    !verificar.verificar_codigoBarra(txtCodigoBarra.Text) ||
                    !verificar.verificar_stock(Convert.ToInt32(txtStock.Text)) ||
                    !verificar.verificar_precio(Convert.ToDouble(txtPrecio.Text)))
            {
                return;
            }
            else
            {
                p.nombre = txtProducto.Text;
                p.precio= Convert.ToDouble(txtPrecio.Text);
                p.codigoBarra = txtCodigoBarra.Text;
                p.stock = Convert.ToInt32(txtStock.Text);
                p.proveedor = cargarProducto.buscar_id("Nombre_proveedor", "Id_Proveedor", "Proveedor", boxProveedor.SelectedItem.ToString());
                p.categoria = cargarProducto.buscar_id("Nombre_Categoria", "Id_Categoria", "Categoria", boxCategoria.SelectedItem.ToString());
                p.unidad = cargarProducto.buscar_id("Nombre_Unidad", "Id_Unidad", "Unidad", boxUnidad.SelectedItem.ToString());
                if (boxFraccionable.SelectedIndex==0) { p.fraccionable = 1; }
                else { p.fraccionable = 0; }
                //Llamo a la funcion cargarProducto y le paso el producto(p)
                cargarProducto.cargarProducto(p);
            }
        }
        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_numeros_evento(e);
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                return;
            }
            else
            {
                string busqueda = txtBusqueda.Text;
                dataGridViewBuscar.DataSource = cargarProducto.buscarProductos(busqueda);

            }

           
      

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtPrecio.Text = dataGridViewBuscar.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                txtCodigoBarra.Text = dataGridViewBuscar.Rows[e.RowIndex].Cells["Codigo_barra"].Value.ToString();
                txtProducto.Text = dataGridViewBuscar.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtStock.Text = dataGridViewBuscar.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                //boxCategoria.SelectedIndex = cargarProducto.buscar_id("Nombre_Categoria", "Id_Categoria", "Categoria",Convert.ToInt32(dataGridViewBuscar.Rows[e.RowIndex].Cells["Id_Categoria"].ToString()));
            }
        }
    }
}

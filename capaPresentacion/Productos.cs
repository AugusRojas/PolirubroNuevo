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
            dataGridView1.DataSource = cargarProducto.obtenerTabla();
            dataGridView1.AllowUserToAddRows = false;
            boxCategoria = cargarProducto.cargar_comboBox(boxCategoria, "Nombre_categoria", "Categoria");
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
                    !verificar.verificar_stock(Convert.ToDouble(txtStock.Text)) ||
                    !verificar.verificar_precio(Convert.ToDouble(txtPrecio.Text)))
            {
                return;
            }
            else
            {

                if (verificar.verificar_repetido(txtCodigoBarra.Text))
                {
                    MessageBox.Show("Codigo de barra ya existente", "Codigo de barra repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    p.nombre = txtProducto.Text;
                    p.precio = Convert.ToDouble(txtPrecio.Text);
                    p.codigoBarra = txtCodigoBarra.Text;
                    p.stock = Convert.ToDouble(txtStock.Text);
                    p.proveedor = cargarProducto.buscar_id("Nombre_proveedor", "Id_Proveedor", "Proveedor", boxProveedor.SelectedItem.ToString());
                    p.categoria = cargarProducto.buscar_id("Nombre_Categoria", "Id_Categoria", "Categoria", boxCategoria.SelectedItem.ToString());
                    p.unidad = cargarProducto.buscar_id("Nombre_Unidad", "Id_Unidad", "Unidad", boxUnidad.SelectedItem.ToString());
                    if (boxFraccionable.SelectedIndex == 0) { p.fraccionable = 1; }
                    else { p.fraccionable = 0; }
                    //Llamo a la funcion cargarProducto y le paso el producto(p)
                    cargarProducto.cargarProducto(p);
                    txtCodigoBarra.Text = string.Empty;
                    txtStock.Text = string.Empty;
                    txtPrecio.Text = string.Empty;
                    txtProducto.Text = string.Empty;
                    dataGridView1.DataSource = cargarProducto.obtenerTabla();
                }
            }
        }
        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificar.verificar_letras_evento(sender,e);
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
        
        private void dataGridViewBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Producto p = new Producto();
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

            if (!verificar.verificar_codigoBarra(txtCodigoBarra.Text) ||
                    !verificar.verificar_stock(Convert.ToDouble(txtStock.Text)) ||
                    !verificar.verificar_precio(Convert.ToDouble(txtPrecio.Text)))
            {
                return;
            }
            else
            {
                p.nombre = txtProducto.Text;
                p.precio = Convert.ToDouble(txtPrecio.Text);
                p.codigoBarra = txtCodigoBarra.Text;
                p.stock = Convert.ToDouble(txtStock.Text);
                p.proveedor = cargarProducto.buscar_id("Nombre_proveedor", "Id_Proveedor", "Proveedor", boxProveedor.SelectedItem.ToString());
                p.categoria = cargarProducto.buscar_id("Nombre_Categoria", "Id_Categoria", "Categoria", boxCategoria.SelectedItem.ToString());
                p.unidad = cargarProducto.buscar_id("Nombre_Unidad", "Id_Unidad", "Unidad", boxUnidad.SelectedItem.ToString());
                if (boxFraccionable.SelectedIndex == 0) { p.fraccionable = 1; }
                else { p.fraccionable = 0; }
                //Llamo a la funcion cargarProducto y le paso el producto(p)
                cargarProducto.modificarProducto(p);
                dataGridView1.DataSource = cargarProducto.obtenerTabla();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource = cargarProducto.buscarProductos(textBox1.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(cargarProducto.buscar_id("Nombre_unidad", "Id_Unidad", "Unidad", dataGridView1.Rows[e.RowIndex].Cells["Unidad"].Value.ToString()));
            if (e.RowIndex >=0)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtPrecio.Text = dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                txtCodigoBarra.Text = dataGridView1.Rows[e.RowIndex].Cells["Codigo_barra"].Value.ToString(); 
                txtProducto.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                boxCategoria.SelectedItem = cargarProducto.buscar_valor_id("Nombre_categoria", "Id_Categoria", "Categoria", cargarProducto.buscar_id("Nombre_categoria", "Id_Categoria", "Categoria", dataGridView1.Rows[e.RowIndex].Cells["Categoria"].Value.ToString()));
                boxUnidad.SelectedItem = cargarProducto.buscar_valor_id("Nombre_unidad","Id_Unidad" , "Unidad", cargarProducto.buscar_id("Nombre_Unidad", "Id_Unidad", "Unidad", dataGridView1.Rows[e.RowIndex].Cells["Unidad"].Value.ToString()));
                boxProveedor.SelectedItem = cargarProducto.buscar_valor_id("Nombre_proveedor", "Id_Proveedor", "Proveedor",  cargarProducto.buscar_id("Nombre_proveedor", "Id_Proveedor", "Proveedor", dataGridView1.Rows[e.RowIndex].Cells["Nombre_Proveedor"].Value.ToString()));
                //Console.WriteLine(respeusta);
                int opcion;
                if (dataGridView1.Rows[e.RowIndex].Cells["Fraccionable"].Value.ToString() == "SI") { opcion = 1; } else { opcion = 0; }
                boxFraccionable.SelectedIndex = opcion;
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!verificar.Verificar_vacio_txt(txtProducto))
            {
                MessageBox.Show("Complete El nombre para eliminar el producto");
            }
            else
            {
                cargarProducto.eliminarProducto(Convert.ToInt32(txtId.Text));
                cargarProducto.obtenerTabla();

            }
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { txtCodigoBarra.Focus(); }
        }

        private void txtCodigoBarra_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { txtPrecio.Focus(); }
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txtStock.Focus(); }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!verificar.Verificar_vacio_txt(textBox2))
                {
                    MessageBox.Show("No se permiten campos vacios", "Carga categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cargarProducto.insertar_categoria(textBox2.Text);
                    boxCategoria = cargarProducto.cargar_comboBox(boxCategoria, "Nombre_categoria", "Categoria");
                    textBox2.Text = " ";
                }
            }

        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!verificar.Verificar_vacio_txt(textBox3))
                {
                    MessageBox.Show("No se permiten campos vacios", "Carga categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cargarProducto.insertar_unidad(textBox3.Text);
                    boxCategoria = cargarProducto.cargar_comboBox(boxUnidad, "Nombre_unidad", "Unidad");
                    textBox3.Text = " ";
                }
            }

        }
    }
}

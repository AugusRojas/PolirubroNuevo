using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIRUBRO.capaNegocio;

namespace POLIRUBRO.capaPresentacion
{
    public partial class Ventana_emergente_buscar__producto : Form
    {
        Facturacion f = new Facturacion();
        Verificar v = new Verificar();
        public Ventana_emergente_buscar__producto(Facturacion f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void textBox_buscar_filtro_TextChanged(object sender, EventArgs e)
        {

            if (v.Combobox_opcion(comboBox1))
            {
                MessageBox.Show("Por favor, elige una opcion para buscar");
            }

            else
            {
                string opcion = comboBox1.SelectedItem.ToString();

                Facturacion_logica llevar = new Facturacion_logica();
                DataTable respuesta;

                string palabra_escrita = textBox_buscar_filtro.Text.Trim();
                string filtro;

                switch (opcion)
                {
                    case "Categoria":
                        filtro = "Nombre_categoria";
                        respuesta = llevar.mostrar_productos_filtro(filtro, palabra_escrita);

                        break;

                    case "Nombre":
                        filtro = "Nombre";
                        respuesta = llevar.mostrar_productos_filtro(filtro, palabra_escrita);

                        break;

                    default:
                        return;
                }

                dvg_filtrado.DataSource = respuesta;
                dvg_filtrado.Columns["Codigo_barra"].Width = 130;
                dvg_filtrado.Columns["Fraccionable"].Width = 110;
            }
           
        }

        private void dvg_filtrado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string Id = dvg_filtrado.Rows[e.RowIndex].Cells["Id_Producto"].Value.ToString();
                string codigo_barra = dvg_filtrado.Rows[e.RowIndex].Cells["Codigo_barra"].Value.ToString();
                string nombre = dvg_filtrado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string stock = dvg_filtrado.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                string precio = dvg_filtrado.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                string unidad = dvg_filtrado.Rows[e.RowIndex].Cells["Unidad"].Value.ToString();
                string fraccionable = dvg_filtrado.Rows[e.RowIndex].Cells["Fraccionable"].Value.ToString();

<<<<<<< HEAD:POLIRUBRO/capaPresentacion/Ventana_emergente_buscar_ producto.cs
                f.Mostrar_datos(Id, codigo_barra, nombre, stock, precio, unidad, fraccionable);
=======
                f.Mostrar_datos(Id,codigo_barra, nombre, stock, precio, unidad, fraccionable);
>>>>>>> 2f1f12c55481a22fa39752452a3fdd24b1eae0ae:capaPresentacion/Ventana_emergente_buscar_ producto.cs

                this.Close();

            }
        }

        private void dvg_filtrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventana_emergente_buscar__producto_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {  
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            textBox_fecha.Text = fecha.ToString("d");

        }

        private void button_buscar_producto_Click(object sender, EventArgs e)
        {
            Ventana_emergente_buscar__producto abrir = new Ventana_emergente_buscar__producto(this);

            abrir.Show();
        }

        public void Mostrar_datos(string codigo_barra, string nombre, string stock, string precio, string unidad, string fraccionable)
        {
            textBox_codigo_ean.Text = codigo_barra;
            textBox_Nombre.Text = nombre;
            textBox_stock.Text = stock;
            textBox_precio.Text = precio;
            textBox_unidad.Text = unidad;
            label_fraccionable.Text = fraccionable;
        }
    }
}

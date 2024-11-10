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

        private void button1_Click(object sender, EventArgs e)
        {
            Verificar v = new Verificar();

            if(v.Verificar_vacio_txt(textBox_codigo_ean) && v.Verificar_vacio_txt(textBox_Nombre) &&
               v.Verificar_vacio_txt(textBox_precio)&&v.Verificar_vacio_txt(textBox_stock) 
               && v.Verificar_vacio_txt(textBox_unidad))
            {
                if (v.Verificar_vacio_txt(textBox_cantidad_vender))
                {
                    double cantidad_vender;
                    double precio;

                    if(double.TryParse(textBox_cantidad_vender.Text, out cantidad_vender))
                    {
                        cantidad_vender = double.Parse(textBox_cantidad_vender.Text);
                        precio = double.Parse(textBox_precio.Text);

                        double subtotal = cantidad_vender * precio;

                        dgv_ventas.Rows.Add(textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal);

                    }

                    else
                    {
                        MessageBox.Show("Ingrese numeros para la cantidad");
                    }
                }

                else
                {
                    MessageBox.Show("Ingrese un cantidad para ser vendida");
                }
            }

            else
            {
                MessageBox.Show("Complete todos los capos para poder realizar la registracion de los productos");
            }

        }
    }
}

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

        CargarProducto b = new CargarProducto();

        private void Facturacion_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            textBox_fecha.Text = fecha.ToString("d");

            comboBox_metodo_pago = b.cargar_comboBox(comboBox_metodo_pago, "Nombre_metodo_pago", "Metodo_pago");
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

        Verificar v = new Verificar();
        Facturacion_logica c = new Facturacion_logica();

        private void button1_Click(object sender, EventArgs e)
        {   
                if (v.Verificar_vacio_txt(textBox_codigo_ean) && v.Verificar_vacio_txt(textBox_Nombre) &&
                    v.Verificar_vacio_txt(textBox_precio) && v.Verificar_vacio_txt(textBox_stock)
                     && v.Verificar_vacio_txt(textBox_unidad))
                {
                    if (v.Verificar_vacio_txt(textBox_cantidad_vender))
                    {
                        if (c.Comprobacion_Stock(textBox_cantidad_vender, textBox_stock));

                        else
                        {
                            double cantidad_vender;

                            bool esFraccionable = label_fraccionable.Text == "Si";

                            if (esFraccionable)
                            {
                                if (double.TryParse(textBox_cantidad_vender.Text, out cantidad_vender))
                                {
                                    double precio = double.Parse(textBox_precio.Text);
                                    double subtotal = c.Aplicar_descuento(cantidad_vender, precio, textBox_descuento);
                                    dgv_ventas.Rows.Add(textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal, textBox_descuento.Text);

                                    textBox_cantidad_vender.Clear(); textBox_codigo_ean.Clear(); textBox_Nombre.Clear(); textBox_precio.Clear(); textBox_stock.Clear(); textBox_unidad.Clear(); textBox_descuento.Clear();
                                    textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString("C2");
                                }

                                else
                                {
                                    MessageBox.Show("Ingrese un número válido para la cantidad.");
                                }
                            }

                            else
                            {
                                if (int.TryParse(textBox_cantidad_vender.Text, out int cantidadEntera))
                                {
                                    cantidad_vender = cantidadEntera;

                                    double precio = double.Parse(textBox_precio.Text);
                                    double subtotal = c.Aplicar_descuento(cantidad_vender, precio, textBox_descuento);

                                    dgv_ventas.Rows.Add(textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal, textBox_descuento.Text);
                                    textBox_cantidad_vender.Clear(); textBox_codigo_ean.Clear(); textBox_Nombre.Clear(); textBox_precio.Clear(); textBox_stock.Clear(); textBox_unidad.Clear(); textBox_descuento.Clear();
                                    textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString("C2");
                                }

                                else
                                {
                                    MessageBox.Show("Este producto no permite cantidades decimales. Ingrese un número entero.");
                                }
                            }
                        }
                        
                    }

                    else
                    {
                        MessageBox.Show("Ingrese una cantidad para ser vendida");
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos para poder realizar la registración de los productos");
                }

        }


        private void dgv_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgv_ventas.Columns["X"].Index && e.RowIndex >= 0)
            {
                dgv_ventas.Rows.RemoveAt(e.RowIndex);

                textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString("c2");
            }
        }

        
    }

}

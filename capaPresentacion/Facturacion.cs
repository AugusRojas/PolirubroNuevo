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

        Dictionary<string, double> Productos_a_vender = new Dictionary<string, double>();

        Dictionary<string, double> Stock_inicial = new Dictionary<string, double>();
        private void Facturacion_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            textBox_fecha.Text = fecha.ToString("d");

            comboBox_metodo_pago = b.cargar_comboBox(comboBox_metodo_pago, "Nombre_metodo_pago", "Metodo_pago");

            textBox_descuento.Text = 0.ToString();
        }

        private void button_buscar_producto_Click(object sender, EventArgs e)
        {
            Ventana_emergente_buscar__producto abrir = new Ventana_emergente_buscar__producto(this);

            abrir.Show();
        }

        public void Mostrar_datos(string Id, string codigo_barra, string nombre, string stock, string precio, string unidad, string fraccionable)
        {
            textBox_Id.Text = Id;
            textBox_codigo_ean.Text = codigo_barra;
            textBox_Nombre.Text = nombre;
            textBox_stock.Text = stock;
            textBox_precio.Text = precio;
            textBox_unidad.Text = unidad;
            label_fraccionable.Text = fraccionable;

            if (!Stock_inicial.ContainsKey(codigo_barra))
            {
                Stock_inicial[codigo_barra] = double.Parse(stock);
            }

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
                    double sumador = double.Parse(textBox_cantidad_vender.Text);
                    if (c.Comprobacion_Stock(ref sumador, textBox_stock))
                    {
                        // Si el método devuelve "true", ya sabés que hay problema de stock.
                        MessageBox.Show($"La cantidad ajustada es {sumador}");
                        return;
                    }

                    else
                    {
                        double cantidad_vender;
                        double descuentoAcumulado = double.Parse(textBox_descuento.Text);
                        bool esFraccionable = label_fraccionable.Text == "Sí";

                        if (esFraccionable)
                        {
                            if (double.TryParse(textBox_cantidad_vender.Text, out cantidad_vender))
                            {
                                double precio = double.Parse(textBox_precio.Text);
                                double subtotal = c.Aplicar_descuento(cantidad_vender, precio, descuentoAcumulado);

                                bool productoRepetido = false;

                                foreach (DataGridViewRow row in dgv_ventas.Rows)
                                {
                                    if (row.Cells["Codigo_barra"].Value.ToString() == textBox_codigo_ean.Text)
                                    {
                                        if(row.Cells["Descuento"].Value.ToString() != textBox_descuento.Text)
                                        {
                                            continue;
                                        }

                                        productoRepetido = true;

                                        double cantidadExistente = double.Parse(row.Cells["Cantidad_a_vender"].Value.ToString());
                                        double nuevaCantidad = cantidadExistente + cantidad_vender;

                                        if(nuevaCantidad > Stock_inicial[textBox_codigo_ean.Text])
                                        {
                                            MessageBox.Show("los productos a vender pasan del stock");
                                            return;
                                        }

                                        row.Cells["Cantidad_a_vender"].Value = nuevaCantidad;

                                        descuentoAcumulado += double.Parse(textBox_descuento.Text);
                                        row.Cells["Descuento"].Value = descuentoAcumulado;
                                        double nuevoSubtotal = c.Aplicar_descuento(nuevaCantidad, precio, descuentoAcumulado);
                                       
                                        row.Cells["Subtotal"].Value = nuevoSubtotal;

                                        break;
                                    }

                                    
                                }

                                if (!productoRepetido)
                                {
                                    dgv_ventas.Rows.Add(textBox_Id.Text, textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal, textBox_descuento.Text);

                                    Stock_inicial[textBox_codigo_ean.Text] = double.Parse(textBox_stock.Text);
                                }


                                textBox_cantidad_vender.Clear(); textBox_codigo_ean.Clear(); textBox_Nombre.Clear(); textBox_precio.Clear();
                                textBox_stock.Clear();
                                textBox_unidad.Clear();
                                textBox_descuento.Clear();
                                textBox_descuento.Text = 0.ToString();
                                textBox_Id.Clear();

                                textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString("0.00");
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
                                double subtotal = c.Aplicar_descuento(cantidad_vender, precio, descuentoAcumulado);

                                bool productoRepetido = false;

                                foreach (DataGridViewRow row in dgv_ventas.Rows)
                                {
                                    if (row.Cells["Codigo_barra"].Value.ToString() == textBox_codigo_ean.Text)
                                    {
                                        if (row.Cells["Descuento"].Value.ToString() != textBox_descuento.Text)
                                        {
                                            continue;
                                        }

                                        productoRepetido = true;

                                        double cantidadExistente = double.Parse(row.Cells["Cantidad_a_vender"].Value.ToString());
                                        double nuevaCantidad = cantidadExistente + cantidad_vender;

                                        if (nuevaCantidad > Stock_inicial[textBox_codigo_ean.Text])
                                        {
                                            MessageBox.Show("los productos a vender pasan del stock");
                                            return;
                                        }

                                        row.Cells["Cantidad_a_vender"].Value = nuevaCantidad;

                                        double nuevoSubtotal = c.Aplicar_descuento(nuevaCantidad, precio, descuentoAcumulado);
                                        descuentoAcumulado += double.Parse(textBox_descuento.Text);
                                        row.Cells["Subtotal"].Value = nuevoSubtotal;

                                        break;
                                    }
                                }

                                if (!productoRepetido)
                                {
                                    dgv_ventas.Rows.Add(textBox_Id.Text, textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal, textBox_descuento.Text);

                                    Stock_inicial[textBox_codigo_ean.Text] = double.Parse(textBox_stock.Text);
                                }

                                textBox_cantidad_vender.Clear();
                                textBox_codigo_ean.Clear();
                                textBox_Nombre.Clear();
                                textBox_precio.Clear();
                                textBox_stock.Clear();
                                textBox_unidad.Clear();
                                textBox_descuento.Clear();
                                textBox_Id.Clear();
                                textBox_descuento.Text = 0.ToString();

                                textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString("0.00");
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
            if (e.ColumnIndex == dgv_ventas.Columns["X"].Index && e.RowIndex >= 0)
            {
                string codigo_barra = dgv_ventas.Rows[e.RowIndex].Cells["Codigo_barra"].Value.ToString();
                double cantidad_a_vender_eliminada = double.Parse(dgv_ventas.Rows[e.RowIndex].Cells["Cantidad_a_vender"].Value.ToString());

                if (Productos_a_vender.ContainsKey(codigo_barra))
                {
                    Productos_a_vender[codigo_barra] -= cantidad_a_vender_eliminada;
                    Productos_a_vender.Remove(codigo_barra);
                }

                dgv_ventas.Rows.RemoveAt(e.RowIndex);

                textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString("0.00");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_ventas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos cargados para vender", "Error", MessageBoxButtons.OK);
                return;
            }

            if (comboBox_metodo_pago.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione un método de pago antes de continuar.", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow fila in dgv_ventas.Rows)
            {
                if (fila.Cells["Codigo_barra"].Value != null && fila.Cells["Cantidad_a_vender"].Value != null)
                {
                    string codigo_barra = fila.Cells["Codigo_barra"].Value.ToString();
                    double cantidad = double.Parse(fila.Cells["Cantidad_a_vender"].Value.ToString());

                    if (Productos_a_vender.ContainsKey(codigo_barra))
                    {
                        Productos_a_vender[codigo_barra] += cantidad;
                    }
                    else
                    {
                        Productos_a_vender.Add(codigo_barra, cantidad);
                    }
                }
                else
                {
                    MessageBox.Show("Hay productos con información incompleta en la tabla.", "Error");
                    return;
                }
            }

            c.Descuento_stock(Productos_a_vender, Stock_inicial);

            int id_metodo_pago = b.buscar_id("Nombre_metodo_pago", "Id_Metodo_pago", "Metodo_pago", comboBox_metodo_pago.SelectedItem.ToString());
            int id_venta;

           
            c.Insertar_venta(id_metodo_pago, textBox_total, textBox_fecha, out id_venta);

            foreach (DataGridViewRow p in dgv_ventas.Rows)
            {
                string idProducto = p.Cells["Id"].Value.ToString();
                string cantidad = p.Cells["Cantidad_a_vender"].Value.ToString();
                string descuento = p.Cells["Descuento"].Value.ToString();
                string subtotal = p.Cells["SubTotal"].Value.ToString();

                c.Insertar_producto_en_venta(id_venta, idProducto, cantidad, descuento, subtotal);
            }

            textBox_total.Clear();
            dgv_ventas.Rows.Clear();
            Productos_a_vender.Clear();

            c.MostrarConfirmacionYAccion();
        }


        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores pr = new Proveedores();
            pr.Show();
        }

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria_metodo_pago mp = new categoria_metodo_pago();
            mp.Show();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar_Reporte gr = new Generar_Reporte();
            gr.Show();
        }

        private void textBox_cantidad_vender_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.verificar_numeros_evento(e);
        }

        private void textBox_codigo_ean_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarProducto cargar = new CargarProducto();
                DataTable dt = new DataTable();
                dt = cargar.buscarProductos(textBox_codigo_ean.Text);
                textBox_Nombre.Text = dt.Rows[0]["Producto"].ToString();
                textBox_stock.Text = dt.Rows[0]["Stock"].ToString();
                textBox_precio.Text = dt.Rows[0]["Precio"].ToString();
                textBox_unidad.Text = dt.Rows[0]["Unidad"].ToString();
                textBox_Id.Text = dt.Rows[0]["Id"].ToString();
                textBox_cantidad_vender.Text = "1";

                if (v.Verificar_vacio_txt(textBox_codigo_ean) && v.Verificar_vacio_txt(textBox_Nombre) &&
               v.Verificar_vacio_txt(textBox_precio) && v.Verificar_vacio_txt(textBox_stock)
                && v.Verificar_vacio_txt(textBox_unidad))
                {
                    if (v.Verificar_vacio_txt(textBox_cantidad_vender))
                    {
                        double sumador = double.Parse(textBox_cantidad_vender.Text);
                        if (c.Comprobacion_Stock(ref sumador, textBox_stock))
                        {
                            // Si el método devuelve "true", ya sabés que hay problema de stock.
                            MessageBox.Show($"La cantidad ajustada es {sumador}");
                        }

                        else
                        {
                            double cantidad_vender;
                            double descuentoAcumulado = double.Parse(textBox_descuento.Text);
                            bool esFraccionable = label_fraccionable.Text == "Si";

                            if (esFraccionable)
                            {
                                if (double.TryParse(textBox_cantidad_vender.Text, out cantidad_vender))
                                {
                                    double precio = double.Parse(textBox_precio.Text);
                                    double subtotal = c.Aplicar_descuento(cantidad_vender, precio, descuentoAcumulado);

                                    bool productoRepetido = false;

                                    foreach (DataGridViewRow row in dgv_ventas.Rows)
                                    {
                                        if (row.Cells["Codigo_barra"].Value.ToString() == textBox_codigo_ean.Text)
                                        {
                                            productoRepetido = true;

                                            double cantidadExistente = double.Parse(row.Cells["Cantidad_a_vender"].Value.ToString());
                                            double nuevaCantidad = cantidadExistente + cantidad_vender;
                                            row.Cells["Cantidad_a_vender"].Value = nuevaCantidad;

                                            double nuevoSubtotal = c.Aplicar_descuento(nuevaCantidad, precio, descuentoAcumulado);
                                            row.Cells["Subtotal"].Value = nuevoSubtotal;

                                            break;
                                        }
                                    }

                                    if (!productoRepetido)
                                    {
                                        dgv_ventas.Rows.Add(textBox_Id.Text, textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal, textBox_descuento.Text);

                                        Stock_inicial[textBox_codigo_ean.Text] = double.Parse(textBox_stock.Text);
                                    }

                                    textBox_cantidad_vender.Clear(); textBox_codigo_ean.Clear(); textBox_Nombre.Clear(); textBox_precio.Clear();
                                    textBox_stock.Clear();
                                    textBox_unidad.Clear();
                                    textBox_descuento.Clear();
                                    textBox_descuento.Text = 0.ToString();
                                    textBox_Id.Clear();

                                    textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString();
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
                                    double subtotal = c.Aplicar_descuento(cantidad_vender, precio, descuentoAcumulado);

                                    bool productoRepetido = false;

                                    foreach (DataGridViewRow row in dgv_ventas.Rows)
                                    {
                                        if (row.Cells["Codigo_barra"].Value.ToString() == textBox_codigo_ean.Text)
                                        {
                                            productoRepetido = true;

                                            double cantidadExistente = double.Parse(row.Cells["Cantidad_a_vender"].Value.ToString());
                                            double nuevaCantidad = cantidadExistente + cantidad_vender;
                                            row.Cells["Cantidad_a_vender"].Value = nuevaCantidad;

                                            double nuevoSubtotal = c.Aplicar_descuento(nuevaCantidad, precio, descuentoAcumulado);
                                            row.Cells["Subtotal"].Value = nuevoSubtotal;

                                            break;
                                        }
                                    }

                                    if (!productoRepetido)
                                    {
                                        dgv_ventas.Rows.Add(textBox_Id.Text, textBox_codigo_ean.Text, textBox_Nombre.Text, textBox_precio.Text, textBox_cantidad_vender.Text, textBox_unidad.Text, subtotal, textBox_descuento.Text);

                                        Stock_inicial[textBox_codigo_ean.Text] = double.Parse(textBox_stock.Text);
                                    }

                                    textBox_cantidad_vender.Clear();
                                    textBox_codigo_ean.Clear();
                                    textBox_Nombre.Clear();
                                    textBox_precio.Clear();
                                    textBox_stock.Clear();
                                    textBox_unidad.Clear();
                                    textBox_descuento.Clear();
                                    textBox_Id.Clear();
                                    textBox_descuento.Text = 0.ToString();

                                    textBox_total.Text = c.Total_a_pagar(dgv_ventas).ToString();
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
        }

        private void textBox_codigo_ean_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

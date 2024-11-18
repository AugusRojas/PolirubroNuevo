using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIRUBRO
{
    public class Verificar
    {
       
        public void verificar_letras_evento(KeyPressEventArgs e)
        {
            try
            {
                if ((!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8))//verifica que no puedan ingresar dijitos ni parametros de control
                { 
                    e.Handled = true; //En caso de que sea, lo ignora
                }

            }
            catch (Exception ex) { MessageBox.Show($"Error {ex.Message}");}
        }

        public void verificar_numeros_evento(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        public bool verificar_producto_texto(string producto)
        {
            if (producto.Length >= 2 && producto.Length<=30) { return true; }
            else {MessageBox.Show("Nombre demasiado largo o demasiado corto","Longitud", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
        }

        public bool verificar_stock(double stock)
        { 
            if (stock <= 1001 && stock>0) { return true; }
            else { MessageBox.Show("No se permite Stock negativo o Stock superior a 1000", "Stock",MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
        }

        public bool verificar_precio(double precio)
        {
            if (precio >0 && precio <= 1000000.00) { return true; }
            else { MessageBox.Show("Precio debe ser mayor a 0 y menor que 1.00.0000","Precio",MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
        }

        public bool verificar_codigoBarra(string codigoBarra)
        {
            if ((codigoBarra.Length == 13))
            {   
                return true;
            }
            else {
                MessageBox.Show("El codigo EAN debe llevar 13 digitos","EAN", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false; }

        }
        public bool Verificar_vacio_txt(TextBox t)
        {
            if (!string.IsNullOrEmpty(t.Text)) { return true; }//verifica si esta vacio o nulo
            else { return false; }
        }

        public bool Verificar_vacio_comboBox(ComboBox c)
        {
            if (c.SelectedIndex != -1) { return true; }// verifica que el combo box no este vacio
            else { return false; }
        }

        public bool Combobox_opcion(ComboBox c)
        {
            if(c.SelectedItem == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

}


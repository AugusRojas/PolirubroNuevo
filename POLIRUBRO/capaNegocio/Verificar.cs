using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIRUBRO
{
    public class Verificar
    {
        public bool campo_vacios(string variable)
        {
            if (variable != "")
            {
                return false;
            }

            else
            {
                return true;
            }

        }
     public void Verificar_proveedor(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar) && e.KeyChar != (char)8)//verifica que no puedan ingresar dijitos ni parametros de control
                { 
                    e.Handled = true; //En caso de que sea, lo ignora
                }

            }
            catch (Exception ex) {
                MessageBox.Show($"Error {ex.Message}");
            }
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
    }

}
>>>>>>> Solucion

﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace POLIRUBRO
{
    public class Verificar
    {

        public void verificar_letras_evento(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Obtenemos el control que disparó el evento (TextBox)
                TextBox textBox = sender as TextBox;

                // Verifica que no ingresen caracteres que no sean letras ni la tecla Backspace (8) ni espacio (32)
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
                {
                    e.Handled = true; // Si no es válido, lo ignora
                }

                // Verifica si el usuario ingresó un espacio y si el último carácter del TextBox también es un espacio
                if (e.KeyChar == ' ' && textBox != null && textBox.Text.EndsWith(" "))
                {
                    e.Handled = true; // No permite doble espacio
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        // Verifica que solo se puedan poner numeros y la barra de borrado
        public void verificar_numeros_evento(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }
        }

        // Verifica que los productos sean mayores a 2 letras pero menores a 30
        public bool verificar_producto_texto(string producto)
        {
            if (producto.Length >= 2 && producto.Length<=30) { return true; }
            else {MessageBox.Show("Nombre demasiado largo o demasiado corto","Longitud", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
        }

        //Verifica si hay algun codigo de barra repetido
        public bool verificar_repetido(string codigoBarra)
        {
            SQLiteConnection conexion = Conexion.obtenerConexion();
            string consulta = @"SELECT COUNT(Codigo_barra) AS TOTAL FROM Producto where Codigo_barra = @codigoBarra;";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            comando.Parameters.AddWithValue(@"codigoBarra", codigoBarra);
            SQLiteDataReader lector = comando.ExecuteReader();
            if (lector.Read()) // Leer la fila
            {
                int count = lector.GetInt32(0); // Obtener el valor de la primera columna

                if (count > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        //verifica que el stock no se pase de 1000
        public bool verificar_stock(double stock)
        { 
            if (stock <= 1001 && stock>0) { return true; }
            else { MessageBox.Show("No se permite Stock negativo o Stock superior a 1000", "Stock",MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
        }

        public bool verificar_Stock0(double stock0)
        {
            if (stock0 == 0) { return true; }
            else { return false; }
        }

        //verifica que el precio no supere el millon
        public bool verificar_precio(double precio)
        {
            if (precio >0 && precio <= 1000000.00) { return true; }
            else { MessageBox.Show("Precio debe ser mayor a 0 y menor que 1.00.0000","Precio",MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
        }
        
        //verifica que el codigo de barra sea de 13,12 o 8 digitos
        public bool verificar_codigoBarra(string codigoBarra)
        {
            if ((codigoBarra.Length == 13) || (codigoBarra.Length==8) || (codigoBarra.Length==12))
            {   
                return true;
            }
            else {
                MessageBox.Show("El codigo EAN debe llevar 13 digitos","EAN", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false; }

        }
        //verifica los vacios de un textbox
        public bool Verificar_vacio_txt(TextBox t)
        {
            if (!string.IsNullOrEmpty(t.Text)) { return true; }//verifica si esta vacio o nulo
            else { return false; }
        }

        //verifica los vacio del combobox
        public bool Verificar_vacio_comboBox(ComboBox c)
        {
            if (c.SelectedIndex != -1 && c.SelectedIndex != 0) { return true; }// verifica que el combo box no este vacio
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


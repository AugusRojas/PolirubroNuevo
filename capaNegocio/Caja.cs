using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIRUBRO.capaDatos;
using System.Data.SqlClient;
using System.Data.SQLite;
using static ClosedXML.Excel.XLPredefinedFormat;
using DocumentFormat.OpenXml.Math;

namespace POLIRUBRO.capaNegocio
{
    public class Caja
    {
        CargarProducto cargarProducto = new CargarProducto();
        public bool ingresar(string saldoInicial, string nombre, int numeroCaja)
        {
            try
            {
                int id_nombre = cargarProducto.buscar_id("Nombre_Usuario", "Id_Usuario", "Usuario", nombre.ToUpper());
                Console.WriteLine("Id_Usuario: " + id_nombre);
                if (id_nombre >= 0)
                {
                    MessageBox.Show("Identificado con exito");
                    modificarCaja(nombre, numeroCaja, saldoInicial);
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar: " + ex.Message);
                return false;
            }
        }




        public void agregarCaja(int Numero_Caja, int Id_Usuario, string Saldo_Inicial)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = "INSERT INTO Caja (Numero_Caja, Id_Usuario, Saldo_Inicial) VALUES (@Numero_Caja,Id_Usuario, @Saldo_Inicial)";
                    SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Numero_Caja", Numero_Caja);
                    comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
                    comando.Parameters.AddWithValue("@Saldo_Inicial", Saldo_Inicial);
                    comando.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        public bool agregarUsuario(string Nombre_Usuario)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    int id_nombre = cargarProducto.buscar_id("Nombre_Usuario", "Id_Usuario", "Usuario", Nombre_Usuario.ToUpper());
                    if (id_nombre > 0)
                    {
                        MessageBox.Show("Usuario existente");
                        return false;
                    }
                    else
                    {
                        string consulta = "INSERT INTO Usuario (Nombre_Usuario) VALUES (@Nombre_Usuario)";
                        SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario.ToUpper());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuario agregado");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
                return false;
            }
        }

        public Table topCategorias()
        {
            try
            {
                Table tabla = new Table();
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = "SELECT Nombre_Producto";
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias: " + ex.Message);
                return null;
            }

        }

        public void extraerEncargadoYSaldo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al extraer encargado y saldo: " + ex.Message);
            }
        }


        public void modificarCaja(string nombreUsuario, int box, string cajaInicial)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    conexion.DefaultTimeout = 3000; // Incrementa el timeout a 30 segundos
                        int id_nombre = cargarProducto.buscar_id("Nombre_Usuario", "Id_Usuario", "Usuario", nombreUsuario.ToUpper());
                        if (id_nombre > 0)
                        {
                            modificar(nombreUsuario, box, cajaInicial, id_nombre);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar caja: " + ex.Message);
            }
        }


        public void modificar(string nombreUsuario, int box, string cajaInicial,int id_nombre)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    conexion.DefaultTimeout = 3000; // Incrementa el timeout a 30 segundos
                    using (SQLiteTransaction transaccion = conexion.BeginTransaction())
                    {

                            string consulta = "UPDATE Caja SET Id_Usuario = @Id_Usuario, Caja_Inicial = @Caja_Inicial WHERE Id_Caja = @Id_Caja";
                            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                            comando.Parameters.AddWithValue("@Id_Usuario", id_nombre);
                            comando.Parameters.AddWithValue("@Id_Caja", box);
                            comando.Parameters.AddWithValue("@Caja_Inicial", cajaInicial);
                            comando.ExecuteNonQuery();
                            transaccion.Commit();
                            MessageBox.Show("Caja modificada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar caja: " + ex.Message);
            }
        }
    }
}

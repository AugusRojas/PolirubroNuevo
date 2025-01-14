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

namespace POLIRUBRO.capaNegocio
{
    public  class Caja
    {
        CargarProducto cargarProducto = new CargarProducto();
        public bool ingresar(string saldoInicial, string nombre, string numeroCaja, string apellido)
        {
            try
            {
                using (SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    conexion.DefaultTimeout = 30;
                    using (SQLiteTransaction transaccion = conexion.BeginTransaction())
                    {
                        string consulta = "SELECT Id_Usuario FROM Usuario WHERE Nombre_Usuario = @Nombre_Usuario AND Apellido_Usuario = @Apellido_Usuario";
                        SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@Nombre_Usuario", nombre.ToUpper());
                        comando.Parameters.AddWithValue("@Apellido_Usuario", apellido.ToUpper());
                        object result = comando.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Usuario no encontrado");
                            return false;
                        }
                        else
                        {
                            int id_nombre = cargarProducto.buscar_id("Id_Usuario", "Nombre_Usuario", "Usuario", nombre.ToUpper());
                            int id_apellido = cargarProducto.buscar_id("Id_Usuario", "Apellido_Usuario", "Usuario", apellido.ToUpper());

                            if (id_nombre > 0)
                            {
                                agregarCaja(numeroCaja, id_nombre, saldoInicial);
                            }
                            else if (id_apellido > 0)
                            {
                                agregarCaja(numeroCaja, id_apellido, saldoInicial);
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado");
                                return false;
                            }

                            transaccion.Commit();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar: " + ex.Message);
                return false;
            }
        }


        public void agregarCaja(string Numero_Caja,int Id_Usuario , string Saldo_Inicial)
        {
            try
            {
                using(SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    string consulta = "INSERT INTO Caja (Numero_Caja, Id_Usuario, Saldo_Inicial) VALUES (@Numero_Caja,Id_Usuario, @Saldo_Inicial)";
                    SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Numero_Caja", Numero_Caja);
                    comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
                    comando.Parameters.AddWithValue("@Saldo_Inicial", Saldo_Inicial);
                    comando.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        public bool agregarUsuario(string Nombre_Usuario, string Apellido_Usuario)
        {
            try
            {
                using(SQLiteConnection conexion = Conexion.obtenerConexion())
                {
                    int id_nombre = cargarProducto.buscar_id("Id_Usuario", "Nombre_Usuario", "Usuario", Nombre_Usuario.ToUpper());
                    int id_apellido = cargarProducto.buscar_id("Id_Usuario", "Apellido_Usuario", "Usuario", Apellido_Usuario.ToUpper());
                    if (id_nombre > 0)
                    {
                        MessageBox.Show("Usuario existente");
                        return false;
                    }
                    else if (id_apellido > 0)
                    {
                        MessageBox.Show("Usuario existente");
                        return false;
                    }
                    else
                    {
                        string consulta = "INSERT INTO Usuario (Nombre_Usuario, Apellido_Usuario) VALUES (@Nombre_Usuario, @Apellido_Usuario)";
                        SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario.ToUpper());
                        comando.Parameters.AddWithValue("@Apellido_Usuario", Apellido_Usuario.ToUpper());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuario agregado");
                        return true;
                    }
                }
            }
            catch(Exception ex)
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
    }
}

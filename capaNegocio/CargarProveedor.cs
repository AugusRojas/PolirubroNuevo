using System;
using System.Collections.Generic;
using System.Data;
using POLIRUBRO.capaDatos;

namespace POLIRUBRO.capaNegocio
{
    public class CargarProveedor
    {
        public class Proveedor
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string CUIT { get; set; }
            public string Domicilio { get; set; }
            public string Telefono { get; set; }
        }

        private Clase_Datos_Proveedores datosProveedores = new Clase_Datos_Proveedores();

        public List<Proveedor> ObtenerProveedores()
        {
            return ConvertirDataTableALista(datosProveedores.Buscar_Proveedores("Nombre_proveedor", ""));
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
                throw new Exception("El nombre del proveedor es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.CUIT))
                throw new Exception("El CUIT es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Domicilio))
                throw new Exception("El domicilio es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            datosProveedores.Insertar_Proveedor(proveedor);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            if (proveedor.Id <= 0)
                throw new Exception("El ID del proveedor no es válido.");

            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
                throw new Exception("El nombre del proveedor es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.CUIT))
                throw new Exception("El CUIT es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Domicilio))
                throw new Exception("El domicilio es obligatorio.");

            if (string.IsNullOrWhiteSpace(proveedor.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            datosProveedores.Modificar_Proveedor(proveedor);
        }

        public List<Proveedor> BuscarProveedores(string criterio)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                return ObtenerProveedores(); 

            return ConvertirDataTableALista(datosProveedores.Buscar_Proveedores("Nombre_proveedor", criterio));
        }

        public void EliminarProveedor(int id)
        {
            if (id <= 0)
                throw new Exception("El ID del proveedor no es válido.");

            datosProveedores.Eliminar_Proveedor(id);
        }

        private List<Proveedor> ConvertirDataTableALista(DataTable dt)
        {
            List<Proveedor> lista = new List<Proveedor>();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Proveedor
                {
                    Id = Convert.ToInt32(row["Id_Proveedor"]),
                    Nombre = row["Nombre_proveedor"].ToString(),
                    CUIT = row["CUIT"].ToString(),
                    Domicilio = row["Domicilio"].ToString(),
                    Telefono = row["Telefono"].ToString()
                });
            }
            return lista;
        }
    }
}
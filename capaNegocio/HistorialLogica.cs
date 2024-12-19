using POLIRUBRO.capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.RightsManagement;

namespace POLIRUBRO.capaNegocio
{
    internal class HistorialLogica
    {
        private readonly HistorialDatos _historialDatos;

        // Constructor para inicializar la instancia
        public HistorialLogica()
        {
            _historialDatos = new HistorialDatos();
        }

        public DataTable ObtenerTotalesPorFecha()
        {
            return _historialDatos.TotalesPorFecha();
        }

        public DataTable ObtenerDetallesPorFecha(string fecha)
        {
            return _historialDatos.DetallesPorFecha(fecha);
        }

        public DataTable ObtenerMayoresVendidos()
        {
            return _historialDatos.masVendidos();
        }

        public DataTable ObtenerMenoresVendidos()
        {
            return _historialDatos.menosVendidos();
        }

        public DataTable ObtenerPromedio()
        {
            return _historialDatos.promedioVentas();
        }

        public DataTable ObtenerHistorial(string nombrePago)
        {
            return _historialDatos.historialMetodoPago(nombrePago);
        }


    }
}

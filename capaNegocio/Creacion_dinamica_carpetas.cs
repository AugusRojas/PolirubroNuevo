using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIRUBRO.capaNegocio
{
    public class Creacion_dinamica_carpetas
    {
        public string Crear_carpeta_comprobante()
        {
            string Ruta_carpeta_documento = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string carpeta_comprobantes = Path.Combine(Ruta_carpeta_documento, "Comprobantes");

            if(!Directory.Exists(carpeta_comprobantes))
            {
                Directory.CreateDirectory(carpeta_comprobantes);
            }

            return carpeta_comprobantes;
        }

        public string Crear_carpeta_reporte()
        {
            string Ruta_carpeta_documento = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string carpeta_reporte = Path.Combine(Ruta_carpeta_documento, "Reportes");

            if (!Directory.Exists(carpeta_reporte))
            {
                Directory.CreateDirectory(carpeta_reporte);
            }

            return carpeta_reporte;
        }
    }
}

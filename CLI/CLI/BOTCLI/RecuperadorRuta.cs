using STICLI.Definiciones;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace STICLI
{
    public class RecuperadorRuta: IRecuperadorRuta
    {
        public string GenerarRuta(string NombreArchivo, string Modelo)
        {
            return Path.Combine(Environment.CurrentDirectory,Modelo, NombreArchivo);
        }

        public string NombreCarpetaActual
        {
            get
            {
                return Path.GetFileName(Environment.CurrentDirectory);
            }
        }

        public string RutaPlantillas
        {
            get
            {
                var RutaCompleta = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Plantillas");
                return RutaCompleta;
            }
        }

    }
}

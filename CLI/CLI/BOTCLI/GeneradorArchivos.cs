using System.IO;

namespace STICLI
{
    /// <summary>
    /// Genera los archivos fisicamente.
    /// </summary>
    public class GeneradorArchivos : IGeneradorArchivos
    {
        /// <summary>
        /// Genera el archivo de texto indicado con el contenido indicado.
        /// </summary>
        /// <param name="RutaArchivo">Ruta en donde se generará el archivo.</param>
        /// <param name="Contenido">Contenido que tendrá el archivo.</param>
        /// <returns>true si se llevó a cabo la generación, false de lo contrario.</returns>
        public bool Generar(string RutaArchivo, string Contenido)
        {
            bool ArchivoGenerado = false;
            GenerarDirectorio(RutaArchivo);
            if (!File.Exists(RutaArchivo))
            {
                using (StreamWriter sw = File.CreateText(RutaArchivo))
                {
                    sw.Write(Contenido);
                    ArchivoGenerado = true;
                }
            }

            return ArchivoGenerado;
        }

        private void GenerarDirectorio(string rutaArchivo)
        {
            var Directorio = Path.GetDirectoryName(rutaArchivo);
            if (!Directory.Exists(Directorio))
            {
                Directory.CreateDirectory(Directorio);
            }
        }
    }
}

namespace STICLI
{
    /// <summary>
    /// Generador de archivos de texto.
    /// </summary>
    public interface IGeneradorArchivos
    {
        /// <summary>
        /// Genera el archivo de texto indicado con el contenido indicado.
        /// </summary>
        /// <param name="RutaArchivo">Ruta en donde se generará el archivo.</param>
        /// <param name="Contenido">Contenido que tendrá el archivo.</param>
        /// <returns>true si se llevó a cabo la generación, false de lo contrario.</returns>
        bool Generar(string RutaArchivo, string Contenido);
    }
}
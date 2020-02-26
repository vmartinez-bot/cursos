namespace STICLI.Definiciones.Servicios
{
    /// <summary>
    /// Definición de un procesador de plantillas de los elementos.
    /// </summary>
    public interface IProcesadorPlantillaElemento
    {
        /// <summary>
        /// Procesa el contenido de la plantilla especificada y sustituye los elementos pasados como parámetros.
        /// </summary>
        /// <param name="NombrePlantilla">Nombre de la plantilla que se procesará</param>
        /// <param name="NombreModelo">Nombre del modelo que se usará dentro de la plantilla.</param>
        /// <param name="NombreOperacion">Nombre de la operación que se tomará para sustituir en la plantilla.</param>
        /// <returns>Contenido de la plantilla despues de procesarla.</returns>
        string ProcesarPlantilla(string NombrePlantilla, string NombreModelo, string NombreOperacion);
    }
}
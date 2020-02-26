using STICLI.Definiciones;
using STICLI.Definiciones.Servicios;
using System.IO;
using System.Text;

namespace STICLI.Servicios
{
    /// <summary>
    /// Procesador de plantillas de los elementos.
    /// </summary>
    public class ProcesadorPlantillaElemento : IProcesadorPlantillaElemento
    {
        private readonly IRecuperadorRuta _RecuperadorRuta;

        public ProcesadorPlantillaElemento(IRecuperadorRuta RecuperadorRuta)
        {
            _RecuperadorRuta = RecuperadorRuta;
        }

        /// <summary>
        /// Procesa el contenido de la plantilla especificada y sustituye los elementos pasados como parámetros.
        /// </summary>
        /// <param name="NombrePlantilla">Nombre de la plantilla que se procesará</param>
        /// <param name="NombreModelo">Nombre del modelo que se usará dentro de la plantilla.</param>
        /// <param name="NombreOperacion">Nombre de la operación que se tomará para sustituir en la plantilla.</param>
        /// <returns>Contenido de la plantilla despues de procesarla.</returns>
        public string ProcesarPlantilla(string NombrePlantilla, string NombreModelo, string NombreOperacion)
        {
            string Contenido = string.Empty;
            string ContenidoPlantilla = File.ReadAllText($"{_RecuperadorRuta.RutaPlantillas}/{NombrePlantilla}.txt", Encoding.UTF8);
            Contenido = ContenidoPlantilla.Replace("{Operacion}", NombreOperacion);
            Contenido = Contenido.Replace("{Modelo}", NombreModelo);
            Contenido = Contenido.Replace("{Proyecto}", _RecuperadorRuta.NombreCarpetaActual);
            return Contenido;
        }
    }
}

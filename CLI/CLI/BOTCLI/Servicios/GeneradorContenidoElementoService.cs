using STICLI.Definiciones;
using STICLI.Definiciones.Servicios;
using STICLI.Modelos;

namespace STICLI.Generadores
{
    /// <summary>
    /// Generador del contenido de los distintos elementos pasados.
    /// </summary>
    public class GeneradorContenidoElementoService : IGeneradorContenidoElementoService
    {
        private readonly IRecuperadorRuta _RecuperadorRuta;
        private readonly IGeneradorArchivos _GeneradorArchivos;
        private readonly IProcesadorPlantillaElemento _ProcesadorPlantilla;

        public GeneradorContenidoElementoService(IRecuperadorRuta RecuperadorRuta,
            IGeneradorArchivos GeneradorArchivos,
            IProcesadorPlantillaElemento ProcesadorPlantilla)
        {
            _RecuperadorRuta = RecuperadorRuta;
            _GeneradorArchivos = GeneradorArchivos;
            _ProcesadorPlantilla = ProcesadorPlantilla;
        }

        /// <summary>
        /// Genera el contenido del elemento cuya información es pasada como parámetro.
        /// </summary>
        /// <param name="Elemento">Información del elemento cuyo contenido se generará.</param>
        /// <returns>true el se generó el contenido, false de lo contrario.</returns>
        public bool GenerarContenidoElemento(ElementoPorGenerar Elemento)
        {
            string ContenidoElemento = _ProcesadorPlantilla.ProcesarPlantilla(Elemento.NombrePlantilla, Elemento.NombreModelo, Elemento.NombreOperacion);
            return _GeneradorArchivos.Generar(_RecuperadorRuta.GenerarRuta($"{Elemento.NombreElemento}.cs", Elemento.UbicacionElemento), ContenidoElemento);
        }
    }
}

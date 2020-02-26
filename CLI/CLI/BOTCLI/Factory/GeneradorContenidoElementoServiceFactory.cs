using STICLI.Definiciones;
using STICLI.Definiciones.Servicios;
using STICLI.Generadores;
using STICLI.Servicios;

namespace STICLI.Factory
{
    public class GeneradorContenidoElementoServiceFactory : IGeneradorContenidoElementoServiceFactory
    {
        private readonly IRecuperadorRuta _RecuperadorRuta;
        private readonly IGeneradorArchivos _GeneradorArchivos;
        private readonly IProcesadorPlantillaElemento _ProcesadorPlantilla;

            public GeneradorContenidoElementoServiceFactory()
        {
            _RecuperadorRuta = new RecuperadorRuta();
            _GeneradorArchivos = new GeneradorArchivos();
            _ProcesadorPlantilla = new ProcesadorPlantillaElemento(_RecuperadorRuta);
        }
                
        public IGeneradorContenidoElementoService CrearGenerador()
        {
            var Generador = new GeneradorContenidoElementoService(_RecuperadorRuta, _GeneradorArchivos, _ProcesadorPlantilla);
            return Generador;
        }
    }
}

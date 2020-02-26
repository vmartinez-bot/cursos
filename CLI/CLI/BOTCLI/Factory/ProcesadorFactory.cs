using STICLI.ProcesadoresCapa;

namespace STICLI.Factory
{
    public enum TipoProcesador
    {
        Negocios,
        Viewmodel,
        Controlador
    }
    public class ProcesadorFactory : IProcesadorFactory
    {
        public IProcesador CrearInstancia(TipoProcesador Tipo)
        {
            switch (Tipo)
            {
                case TipoProcesador.Negocios:
                    return new ProcesadorBussines(new GeneradorContenidoElementoServiceFactory());
                    break;
                case TipoProcesador.Viewmodel:
                    return new ProcesadorViewModel(new GeneradorContenidoElementoServiceFactory());
                    break;
                case TipoProcesador.Controlador:
                    break;
                default:
                    break;
            }

            return null;
        }
    }
}

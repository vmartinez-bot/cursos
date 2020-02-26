using STICLI.ProcesadoresCapa;

namespace STICLI.Factory
{
    public interface IProcesadorFactory
    {
        IProcesador CrearInstancia(TipoProcesador Tipo);
    }
}
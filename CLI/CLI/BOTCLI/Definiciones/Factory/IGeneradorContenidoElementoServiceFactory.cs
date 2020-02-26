using STICLI.Generadores;

namespace STICLI.Factory
{
    /// <summary>
    /// Fabrica de generador de elementos.
    /// </summary>
    public interface IGeneradorContenidoElementoServiceFactory
    {
        /// <summary>
        /// Crea la instancia de un generador de elementos
        /// </summary>
        /// <returns>Instancia del generador de elementos a usar.</returns>
        IGeneradorContenidoElementoService CrearGenerador();
    }
}
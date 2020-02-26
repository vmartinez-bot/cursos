namespace STICLI.ProcesadoresCapa
{
    /// <summary>
    /// Procesador de elementos por cada tipo de capa.
    /// </summary>
    public interface IProcesador
    {
        void Procesar(string Alcance, string Modelo);
    }
}
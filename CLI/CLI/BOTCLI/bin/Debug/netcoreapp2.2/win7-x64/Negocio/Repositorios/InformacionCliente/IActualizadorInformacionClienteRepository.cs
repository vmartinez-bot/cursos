namespace [ProyectoPrincipal].Negocio.Repositorios
{
/// <summary>
/// Repositorio Actualizador para InformacionCliente
/// </summary>
public interface IActualizadorInformacionClienteRepository: ICreadorRepository<InformacionCliente>
{
/// <summary>
/// Crea en el repositorio un nuevo InformacionCliente.
/// </summary>
/// <param name="NuevoInformacionCliente">nuevo InformacionCliente que se agregará al repositorio.</param>
InformacionCliente Crear(InformacionCliente NuevoInformacionCliente);
}
}

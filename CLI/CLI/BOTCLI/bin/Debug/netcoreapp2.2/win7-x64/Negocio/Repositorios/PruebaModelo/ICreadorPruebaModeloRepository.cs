namespace [ProyectoPrincipal].Negocio.Repositorios
{
/// <summary>
/// Repositorio Creador para PruebaModelo
/// </summary>
public interface ICreadorPruebaModeloRepository: ICreadorRepository<PruebaModelo>
{
/// <summary>
/// Crea en el repositorio un nuevo PruebaModelo.
/// </summary>
/// <param name="NuevoPruebaModelo">nuevo PruebaModelo que se agregará al repositorio.</param>
PruebaModelo Crear(PruebaModelo NuevoPruebaModelo);
}
}

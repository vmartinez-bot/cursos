namespace [ProyectoPrincipal].Negocio.Repositorios
{
/// <summary>
/// Repositorio Recuperador para PruebaModelo
/// </summary>
public interface IRecuperadorPruebaModeloRepository: ICreadorRepository<PruebaModelo>
{
/// <summary>
/// Crea en el repositorio un nuevo PruebaModelo.
/// </summary>
/// <param name="NuevoPruebaModelo">nuevo PruebaModelo que se agregará al repositorio.</param>
PruebaModelo Crear(PruebaModelo NuevoPruebaModelo);
}
}

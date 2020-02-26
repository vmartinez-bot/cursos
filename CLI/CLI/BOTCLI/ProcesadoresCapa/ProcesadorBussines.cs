using STICLI.Factory;
using STICLI.Generadores;
using STICLI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STICLI.ProcesadoresCapa
{
    /// <summary>
    /// Procesador para la capa de reglas de negocio
    /// </summary>
    public class ProcesadorBussines : IProcesador
    {
        private readonly IGeneradorContenidoElementoServiceFactory _GeneradorFactory;
        private Dictionary<char, string> _dicOperaciones;
        private StringBuilder DependenciasConfiguradas = new StringBuilder();

        public ProcesadorBussines(IGeneradorContenidoElementoServiceFactory GeneradorFactory)
        {
            _dicOperaciones = new Dictionary<char, string>();
            AsignarOperacionesDiccionario();
            _GeneradorFactory = GeneradorFactory;
        }

        /// <summary>
        /// Asigna los nombres de las operaciones de acuerdo a su sigla.
        /// </summary>
        private void AsignarOperacionesDiccionario()
        {
            _dicOperaciones.Add('C', "Creador");
            _dicOperaciones.Add('R', "RecuperadorIndividual");
            _dicOperaciones.Add('U', "Modificador");
            _dicOperaciones.Add('D', "Eliminador");
            _dicOperaciones.Add('M', "RecuperadorMultiple");
        }

        public void Procesar(string Alcance, string Modelo)
        {
            List<ElementoPorGenerar> lstElementos = new List<ElementoPorGenerar>();
            lstElementos.Add(CrearElementoModelo(Modelo));
            
            foreach (var Operacion in Alcance)
            {
                lstElementos.Add(CrearElementoInterfazRepositorio(Operacion, Modelo));
                lstElementos.Add(CrearElementoInterfazServicio(Operacion, Modelo));
                lstElementos.Add(CrearElementoClaseServicio(Operacion, Modelo));
                lstElementos.Add(CrearElementoInterfazValidador(Operacion, Modelo));
                lstElementos.Add(CrearElementoClaseValidador(Operacion, Modelo));
            }

            lstElementos.Add(GenerarElementoConfiguracionDependencias(Modelo));
            var GeneradorContenido = _GeneradorFactory.CrearGenerador();
            foreach (var ElementoPlaneado in lstElementos.OrderBy(e=>e.UbicacionElemento))
            {
                if (GeneradorContenido.GenerarContenidoElemento(ElementoPlaneado))
                {
                    Console.WriteLine($"{ElementoPlaneado.UbicacionElemento}/{ElementoPlaneado.NombreElemento}");
                }
            }

        }

        private ElementoPorGenerar GenerarElementoConfiguracionDependencias(string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = DependenciasConfiguradas.ToString();
            Elemento.UbicacionElemento = $"ConfiguracionDI";
            Elemento.NombrePlantilla = "ConfiguracionDI";
            Elemento.NombreElemento = $"ConfiguracionDI{Modelo}";
            return Elemento;
        }

        private void ConfigurarDependencia(string Interfaz, string Clase)
        {
            DependenciasConfiguradas.AppendLine($"ContenedorDI.AddTransient<{Interfaz}, {Clase}>();");
        }

        private ElementoPorGenerar CrearElementoModelo(string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = "";
            Elemento.UbicacionElemento = $"Negocio/Modelos";
            Elemento.NombrePlantilla = "Clase-Modelo";
            Elemento.NombreElemento = $"{Modelo}";
            return Elemento;
        }

        private ElementoPorGenerar CrearElementoInterfazRepositorio(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"Negocio/Definiciones/Repositorios/{Modelo}";
            Elemento.NombrePlantilla = "Interfaz-Repositorio";
            Elemento.NombreElemento = $"I{Elemento.NombreOperacion}{Modelo}Repository";
            ConfigurarDependencia(Elemento.NombreElemento, $"{Elemento.NombreOperacion}{Modelo}RepositoryEF");
            return Elemento;
        }

        private ElementoPorGenerar CrearElementoInterfazServicio(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"Negocio/Definiciones/Servicios/{Modelo}";
            Elemento.NombrePlantilla = "Interfaz-Servicio";
            Elemento.NombreElemento = $"I{Elemento.NombreOperacion}{Modelo}Service";
            ConfigurarDependencia(Elemento.NombreElemento, $"{Elemento.NombreOperacion}{Modelo}Service");
            return Elemento;
        }

        private ElementoPorGenerar CrearElementoInterfazValidador(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"Negocio/Definiciones/Validadores/{Modelo}";
            Elemento.NombrePlantilla = "Interfaz-Validador";
            Elemento.NombreElemento = $"IValidador{Elemento.NombreOperacion}{Modelo}";
            ConfigurarDependencia(Elemento.NombreElemento, $"Validador{Elemento.NombreOperacion}{Modelo}");
            return Elemento;
        }

        private ElementoPorGenerar CrearElementoClaseValidador(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"Negocio/Validadores/{Modelo}";
            Elemento.NombrePlantilla = "Clase-Validador";
            Elemento.NombreElemento = $"Validador{Elemento.NombreOperacion}{Modelo}";
            return Elemento;
        }


        private ElementoPorGenerar CrearElementoClaseServicio(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"Negocio/Servicios/{Modelo}";
            Elemento.NombrePlantilla = "Clase-Servicio";
            Elemento.NombreElemento = $"{Elemento.NombreOperacion}{Modelo}Service";
            return Elemento;
        }
    }
}

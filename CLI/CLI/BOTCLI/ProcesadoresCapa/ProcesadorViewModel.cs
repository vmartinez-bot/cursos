using STICLI.Factory;
using STICLI.Modelos;
using System;
using System.Collections.Generic;

namespace STICLI.ProcesadoresCapa
{
    public class ProcesadorViewModel : IProcesador
    {
        private readonly IGeneradorContenidoElementoServiceFactory _GeneradorFactory;
        private Dictionary<char, string> _dicOperaciones;

        public ProcesadorViewModel(IGeneradorContenidoElementoServiceFactory GeneradorFactory)
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
                lstElementos.Add(CrearElementoInterfazServicio(Operacion, Modelo));
                lstElementos.Add(CrearElementoClaseServicio(Operacion, Modelo));
            }

            var GeneradorContenido = _GeneradorFactory.CrearGenerador();
            foreach (var ElementoPlaneado in lstElementos)
            {
                GeneradorContenido.GenerarContenidoElemento(ElementoPlaneado);
                Console.WriteLine($"{ElementoPlaneado.UbicacionElemento}/{ElementoPlaneado.NombreElemento}");
            }
        }

        private ElementoPorGenerar CrearElementoModelo(string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = "";
            Elemento.UbicacionElemento = $"ViewModel/Modelos";
            Elemento.NombrePlantilla = "Clase-ViewModel";
            Elemento.NombreElemento = $"{Modelo}ViewModel";
            return Elemento;
        }

        private ElementoPorGenerar CrearElementoInterfazServicio(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"ViewModel/Definiciones/Servicios/{Modelo}ViewModel";
            Elemento.NombrePlantilla = "Interfaz-ServicioViewModel";
            Elemento.NombreElemento = $"I{Elemento.NombreOperacion}{Modelo}ViewModelService";
            return Elemento;
        }

        private ElementoPorGenerar CrearElementoClaseServicio(char Operacion, string Modelo)
        {
            ElementoPorGenerar Elemento = new ElementoPorGenerar();
            Elemento.NombreModelo = Modelo;
            Elemento.NombreOperacion = _dicOperaciones[Operacion];
            Elemento.UbicacionElemento = $"ViewModel/Servicios/{Modelo}ViewModel";
            Elemento.NombrePlantilla = "Clase-ServicioViewModel";
            Elemento.NombreElemento = $"{Elemento.NombreOperacion}{Modelo}ViewModelService";
            return Elemento;
        }
    }
}

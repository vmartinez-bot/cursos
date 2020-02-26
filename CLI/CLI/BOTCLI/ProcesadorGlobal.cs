using STICLI.Factory;
using System;

namespace STICLI
{
    public class ProcesadorGlobal
    {
        private readonly IProcesadorFactory _FabricaProcesadores;

        public ProcesadorGlobal(IProcesadorFactory FabricaProcesadores)
        {
            _FabricaProcesadores = FabricaProcesadores;
        }
        public void Procesar(IReceptorArgumentos _Argumentos)
        {
            switch (_Argumentos.Capa)
            {
                case "b":
                    ProcesarCapa(_Argumentos, TipoProcesador.Negocios);
                    break;
                case "vm":
                    ProcesarCapa(_Argumentos, TipoProcesador.Viewmodel);
                    break;
                case "c":
                    ProcesarCapa(_Argumentos, TipoProcesador.Controlador);
                    break;
                default:
                    throw new Exception($"No se cuenta con un procesador para la capa: {_Argumentos.Capa}");
                    break;
            }
        }

        private void ProcesarCapa(IReceptorArgumentos argumentos, TipoProcesador Tipo)
        {
            var Procesador = _FabricaProcesadores.CrearInstancia(Tipo);
            Procesador.Procesar(argumentos.Alcance, argumentos.Modelo);
        }
    }
}

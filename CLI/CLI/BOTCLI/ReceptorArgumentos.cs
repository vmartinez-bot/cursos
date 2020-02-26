using System;
using System.IO;

namespace STICLI
{
    /// <summary>
    /// Recepciona los argumentos recibidos y los mapea a las propiedades correspondientes.
    /// </summary>
    public class ReceptorArgumentos : IReceptorArgumentos
    {
        public string Capa { get; set; }
        public string Alcance { get; set; }
        public string Modelo { get; set; }
        public ReceptorArgumentos(string[] Argumentos)
        {
            if (Argumentos.Length<3)
            {
                throw new Exception($"Es necesario indicar la acción, el alcance y el nombre del modelo");
            }

            AsignarCapa(Argumentos[0]);
            AsignarAlcance(Argumentos[1]);
            AsignarModelo(Argumentos[2]);
        }

        private void AsignarModelo(string NombreModeloRecibido)
        {
            if (!string.IsNullOrEmpty(NombreModeloRecibido))
            {
                foreach (var CaracterInvalido in Path.GetInvalidPathChars())
                {
                    if (NombreModeloRecibido.Contains(CaracterInvalido))
                    {
                        throw new Exception($"El nombre: {NombreModeloRecibido} del modelo no es correcto");
                    }
                }
                Modelo = NombreModeloRecibido;
            }
            else
            {
                throw new Exception($"Es necesario indicar el nombre del modelo");
            }
        }

        private void AsignarAlcance(string AlcanceRecibido)
        {
            if (string.IsNullOrEmpty(AlcanceRecibido))
            {
                AlcanceRecibido = "CRUDM";
            }
            else
            {
                if (AlcanceRecibido.Length > 5)
                {
                    throw new Exception($"Solamente se puede especificar cualquiera de las opciones: CRUD");
                }
            }
            Alcance = AlcanceRecibido;
        }

        private void AsignarCapa(string CapaRecibida)
        {
            switch (CapaRecibida)
            {
                case "b":
                case "vm":
                case "c":
                    Capa = CapaRecibida;
                    break;
                default:
                    throw new Exception($"La capa: {CapaRecibida} no es válida para el generador de código.");
                    break;
            }
        }
    }
}

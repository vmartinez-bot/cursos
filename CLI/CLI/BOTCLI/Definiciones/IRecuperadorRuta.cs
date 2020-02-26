using System;
using System.Collections.Generic;
using System.Text;

namespace STICLI.Definiciones
{
    public interface IRecuperadorRuta
    {
        string GenerarRuta(string NombreArchivo, string Modelo);
        string NombreCarpetaActual { get; }
        string RutaPlantillas { get; }
    }
}

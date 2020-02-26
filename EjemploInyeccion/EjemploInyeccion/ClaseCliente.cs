using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploInyeccion
{
   public class ClaseCliente
    {
        /*Inyección por constructor*/
        private IDependencia dependencia;
        public ClaseCliente( IDependencia _dependencia) 
        {
            dependencia = _dependencia;
        }
        public void RealizarAcciones() 
        {
            dependencia.ejecutarAccion();
        }
    }
}

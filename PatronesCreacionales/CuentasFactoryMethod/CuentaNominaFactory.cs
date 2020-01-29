using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
    class CuentaNominaFactory : ICuentaFactory
    {
        public ICuenta crearCuenta(int _numCta)
        {
            return new CuentaNomina(_numCta);
        }
    }
}

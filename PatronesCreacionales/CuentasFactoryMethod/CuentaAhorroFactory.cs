using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
    class CuentaAhorroFactory : ICuentaFactory
    {
        public ICuenta crearCuenta(int _numCta)
        {
            return new CuentaAhorro(_numCta);
        }
    }
}

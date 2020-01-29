using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
    class CuentaChequesFactory : ICuentaFactory
    {
        public ICuenta crearCuenta(int _numCta)
        {
            return new CuentaCheques(_numCta);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
    interface ICuentaFactory
    {
        public ICuenta crearCuenta(int _numCta);
    }
}

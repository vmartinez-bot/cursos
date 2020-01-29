using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
   interface ICuenta
    {
        double RetirarFondos(double _monto);

        void AbonarFondos(double _monto);

        int GetNumeroCuenta();

        string GetTipoCuenta();
    }
}

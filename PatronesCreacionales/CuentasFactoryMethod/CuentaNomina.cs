using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
    class CuentaNomina : ICuenta
    {
        private int numCuenta { get; set; }
        private string tipo { get; set; }

        private double saldo { get; set; }

        public CuentaNomina(int _numCuenta)
        {
            numCuenta = _numCuenta;
            tipo = "NOMINA";
        }

        public double RetirarFondos(double _monto)
        {
            //lógica de retiro
            if (saldo >= _monto)
            {
                saldo = saldo - _monto;
                return _monto;
            }
            else if (saldo > 0)
            {
                double retiro = saldo;
                saldo = 0;
                return retiro;
            }
            else
            {
                return 0;
            }
        }

        public void AbonarFondos(double _monto)
        {
            saldo = saldo + _monto;
        }

        public int GetNumeroCuenta()
        {
            return numCuenta;
        }

        public string GetTipoCuenta()
        {
            return tipo;
        }
    }
}


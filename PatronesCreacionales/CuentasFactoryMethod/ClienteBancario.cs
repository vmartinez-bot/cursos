using System;
using System.Collections.Generic;
using System.Text;

namespace CuentasFactoryMethod
{
    class ClienteBancario
    {
        public void Main() {
            ICuentaFactory fabrica;
            ICuenta cuenta;
            string resultado;

            //--------------------------------
            fabrica = new CuentaAhorroFactory();

            cuenta = fabrica.crearCuenta(21546587);
            cuenta.AbonarFondos(5000.00);
           
            resultado=RetirarFondos( cuenta , 1000.00);

            Console.WriteLine(resultado);

            //----------------------
            fabrica = new CuentaChequesFactory();

            cuenta = fabrica.crearCuenta(669998877);
            cuenta.AbonarFondos(50000.00);

            resultado = RetirarFondos(cuenta, 10000.00);

            Console.WriteLine(resultado);

            //-----------------------
            fabrica = new CuentaNominaFactory();
            cuenta = fabrica.crearCuenta(887799554);
            cuenta.AbonarFondos(100.00);

            resultado = RetirarFondos(cuenta, 10000.00);

            Console.WriteLine(resultado);

        }

        public string RetirarFondos(ICuenta cuenta, double monto) {
            double retiro= cuenta.RetirarFondos(monto);
            if (retiro > 0) {
                return string.Format("El cliente hizo un retiro de ${0} de la cuenta {1} de {2}", retiro, cuenta.GetNumeroCuenta(), cuenta.GetTipoCuenta() );
            }
            else {
                return string.Format("El cliente de la cuenta [{0}] de tipo {1}, no tiene fondos suficientes.",cuenta.GetNumeroCuenta(), cuenta.GetTipoCuenta());
            }
            
        }
    }
}

using STICLI.Factory;
using System;

namespace STICLI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Receptor = new ReceptorArgumentos(args);
                var Procesador = new ProcesadorGlobal(new ProcesadorFactory());
                Procesador.Procesar(Receptor);
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }
    }
}

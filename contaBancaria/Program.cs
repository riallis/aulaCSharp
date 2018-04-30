using System;

namespace contaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            abrirConta cliente1 = new abrirConta();

            cliente1.Deposito(1500.00);
            cliente1.Saca(400.50);
            cliente1.StatusConta();
        }
    }
}

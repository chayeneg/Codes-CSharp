using System;
using System.Globalization;

namespace OperadoraPlanoMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
            double conta;
            int minutos;

            conta = (double)50.00;

            minutos = int.Parse(Console.ReadLine());

            if(minutos <= 100)
            {
                Console.WriteLine("Valor a pagar: R$ " + conta);
            } else
            {
               
                conta += (minutos -100)*2.00;
                // conta = conta + (minutos -100)*2.00;

                Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

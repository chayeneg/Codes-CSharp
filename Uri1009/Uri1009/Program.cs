using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("TOTAL = R$ " + ((vendas*0.15)+salario).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

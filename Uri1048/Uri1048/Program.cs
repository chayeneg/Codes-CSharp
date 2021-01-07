using System;
using System.Globalization;

namespace Uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario <= 400.00)
            {
                reajuste = (salario*15)/100;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario <= 800.00)
            {
                reajuste = (salario*12)/100;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
             else if (salario <= 1200.00)
            {
                reajuste = (salario*10)/100;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
             else if (salario <= 2000.00)
            {
                reajuste = (salario*7)/100;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario:" + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho:" + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7%");
            }
            else {
                reajuste = (salario*4)/100;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}

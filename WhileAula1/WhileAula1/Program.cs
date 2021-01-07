using System;

namespace WhileAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, soma;

            a = int.Parse(Console.ReadLine());
            soma = 0;

            while (a != 0)
            {
                soma = soma + a;
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(soma);
        }
    }
}

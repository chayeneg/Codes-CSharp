using System;
using System.Globalization;

namespace Uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont, soma;
            double media;

            soma = 0;
            cont = 0;
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());

            }

            media = (double)soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

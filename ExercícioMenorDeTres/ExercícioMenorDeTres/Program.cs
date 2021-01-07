using System;
using System.Globalization;

namespace ExercícioMenorDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string[] vet = Console.ReadLine().Split();

            a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            b = int.Parse(vet[1], CultureInfo.InvariantCulture);
            c = int.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("MENOR = " + b);
            }
            else
            {
                Console.WriteLine("MENOR = " + c);
            }
        }
    }
}

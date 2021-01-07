using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = n * i;
                Console.WriteLine(i + " x " + n + " = " + resultado);
            }

        }
    }
}

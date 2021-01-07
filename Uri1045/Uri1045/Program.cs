using System;
using System.Globalization;

namespace Uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, n1, n2, n3;


            string[] vet = Console.ReadLine().Split();

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3)
            {
                a = n1;
                if (n2 > n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n2;
                }
            }
            else if (n2 > n3)
            {
                a = n2;
                if (n1 > n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else
            {
                a = n3;
                if (n1 > n2)
                {
                    b = n1;
                    c = n2;
                }
                else
                {
                    b = n2;
                    c = n1;
                }
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");

            }
            else
            {
                if (a * a == b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (a * a > b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (a * a < b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
            }

            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            }
        }
    }


using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split();

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);


        }
    }
}

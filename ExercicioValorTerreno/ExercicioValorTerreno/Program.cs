using System;
using System.Globalization;

namespace ExercicioValorTerreno
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * valor;

            Console.WriteLine("AREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO: " + preco.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}

using System;
using System.Globalization;

namespace ExercicioBaseAlturaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorBase, valorAltura, area, perimetro, diagonal;

            valorAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = valorBase*valorAltura;
            
            perimetro = 2 * valorAltura + 2 * valorBase;

            diagonal = Math.Sqrt(Math.Pow(valorBase, 2.0) + Math.Pow(valorAltura, 2.0));


            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

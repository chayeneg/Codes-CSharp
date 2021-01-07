using System;
using System.Globalization;

namespace Uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, qtde;
            double total;

            string[] vet = Console.ReadLine().Split();

            item = int.Parse(vet[0]);
            qtde = int.Parse(vet[1]);

            switch (item)
            {
                case 1:
                    total = (double)qtde * 4.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = (double)qtde * 4.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = (double)qtde * 5.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = (double)qtde * 2.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = (double)qtde * 1.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }


            
        }
    }
}

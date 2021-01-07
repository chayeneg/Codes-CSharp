using System;

namespace Uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo, alcool, gasolina, diesel;

            tipo = int.Parse(Console.ReadLine());

            alcool = 0;
            diesel = 0;
            gasolina = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                } else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                } else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

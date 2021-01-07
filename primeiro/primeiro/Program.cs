using System;
using System.Globalization;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.357895;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Hello World!"); // escreve o texto sem a quebra de linha
            Console.WriteLine("Hello World!"); // escreve o texto com a quebra de linha

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F3", CultureInfo.InvariantCulture)); // imprime na tela o valor de x, sendo que o "F3" é a quantidade de numeros depois da vírgula e o CultureInfo.InvariantCulture é para manter o ponto no lugar da vírgula. 

            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.ReadLine();


        }
    }
}
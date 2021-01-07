using System;

namespace entrada_de_dados_pt1
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();
            string[] v = s.Split(' ');

            // string[] v = Console.ReadLine().Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Frase: " + frase);
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}

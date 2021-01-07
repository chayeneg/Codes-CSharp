using System;

namespace Uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, minutoInicial, minutoFinal, instanteInicial, instanteFinal, duracao, duracaoHoras, duracaoMinutos;

            string[] vet = Console.ReadLine().Split();

            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            instanteInicial = horaInicial * 60 + minutoInicial;
            instanteFinal = horaFinal * 60 + minutoFinal;

            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            duracaoHoras = duracao / 60;
            duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}

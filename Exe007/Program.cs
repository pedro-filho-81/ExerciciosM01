using System;
using System.Threading;

namespace Exe007
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIÁVEIS
            int inicio;
            int fim;

            // cabeçalho
            Console.WriteLine("SORTEADOR DE NÚMEROS");
            Console.WriteLine("-----------------------------");
            
            // entrada do primeiro número
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out inicio);

            // entrada do segundo número
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);

            // CRIA o objeto da Classe Random()
            Random gerador = new Random();
            int num = gerador.Next(inicio, fim + 1);

            // mostra o resultado
            Console.WriteLine("-----------------------------");
            Console.Write("Sorteando...");
            // espera 2 segundos
            Thread.Sleep(2000);

            Console.WriteLine($"\rEntre {inicio} e {fim} sorteei o valor {num}");

            Console.ReadKey(); // pausa o programa

        } // fim main
    }
}

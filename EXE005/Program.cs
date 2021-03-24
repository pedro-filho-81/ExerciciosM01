using System;

namespace EXE005
{
    class Program
    {
        static void Main(string[] args)
        {
            // TRABALHANDO COM DATA
            Console.Write("Em que ano você nasceu? ");
            // variável do nascimento
            int anoDeNascimento = 0;
            // usuário informa o valor
            int.TryParse(Console.ReadLine(), out anoDeNascimento);

            Console.WriteLine("---------------------------------------");
            // variável ano atual recebe data atual
            int anoAtual = DateTime.Now.Year;
            // cria variável idade e faz o cálculo
            int idade = anoAtual - anoDeNascimento;

            // mostra ano atual
            Console.WriteLine($"Estamos atualmente no ano de {anoAtual}");
            Console.WriteLine($"Se você nasceu em {anoDeNascimento}, " +
                $"vai ter {idade} anos.");

            Console.ReadKey(); // pausa o programa

        } // fim main
    }// fim classe
} // fim namespace

using System;

namespace Exe003
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrada de dados
            Console.Write("Digite um número real: ");
            float num = 0; // cria a variável float
            // libera a entrada do usuário
            float.TryParse(Console.ReadLine(), out num);

            // mostra o resultado
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Você digitou o valor {num}");
            Console.WriteLine($"A parte inteira do número é {(int)num}");
            Console.WriteLine($"Arredondando, temos o número {Convert.ToInt16(num)}");
            Console.ReadKey();

        }
    }
}

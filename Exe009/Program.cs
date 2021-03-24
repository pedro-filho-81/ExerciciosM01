using System;

namespace Exe009
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            string produto1, produto2;
            float valor1, valor2;
            Console.Write("\nProduto1: ");
            produto1 = Console.ReadLine().Trim();
            Console.Write("Preço: R$ ");
            float.TryParse(Console.ReadLine(), out valor1);
            Console.Write("Produto2: ");
            produto2 = Console.ReadLine().Trim();
            Console.Write("Preço2 R$ ");
            float.TryParse(Console.ReadLine(), out valor2);

            // IMPRIME RESULTADO
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"Produto", -20}{"Preço", 13}");
            Console.ResetColor();

            //Console.SetCursorPosition(0, 11);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"{produto1, -20}{valor1, 13:C}");
            Console.WriteLine($"{produto2,-20}{valor2,13:C}");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}

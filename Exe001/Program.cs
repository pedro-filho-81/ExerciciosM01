using System;
using System.Threading; // BIBLIOTECA PARA PAUSAR O PROGRAMA

namespace Exe001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esercício 001 imprimir uma frase na tela
            Console.SetCursorPosition(10, 5); // na posição coluna 10, linha 5
            // fundo da tela em azul
            Console.BackgroundColor = ConsoleColor.Blue;
            // PAUSA 1 SEGUNDO
            Thread.Sleep(1000);
            // imprima
            Console.Write("MEU");
            Console.ResetColor();          
            
            // fundo de tela amarela
            Console.BackgroundColor = ConsoleColor.Yellow;
            // letras verde
            Console.ForegroundColor = ConsoleColor.Green;
            // PAUSA 1 SEGUNDO
            Thread.Sleep(1000);
            // imprime Brasil
            Console.Write("BRASIL");
            Console.ResetColor();
            
            // fundo de tela amarela
            Console.BackgroundColor = ConsoleColor.Green;
            // letras verde
            Console.ForegroundColor = ConsoleColor.Yellow;
            // PAUSA 1 SEGUNDO
            Thread.Sleep(1000);
            // imprime Brasil
            Console.WriteLine("BRASILEIRO");            
            // limpa a cor
            Console.ResetColor();

            // pausa o sistema
            Console.ReadKey();

        }
    }
}

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string cabeca = "franken";
            string olho_direito = "vegitas";
            string olho_esquerdo = "spritem";
            string boca = "wackus";

            Console.ReadKey(); 

            Console.WriteLine("seu monstro tem o formato de cabeca: " + cabeca);
            Console.ReadKey();

            Console.WriteLine("olho esquerdo: " + olho_esquerdo);
            Console.ReadKey();

            Console.WriteLine("olho direito: " + olho_direito);
            Console.ReadKey();

            Console.WriteLine("boca: " + boca);
            Console.ReadKey();

            Console.WriteLine(" ");

            Console.Write("seu monstro é do tipo " + cabeca);
            Console.Write(" ");
            Console.Write(boca);

            Console.ReadKey(); 
        }
    }
}

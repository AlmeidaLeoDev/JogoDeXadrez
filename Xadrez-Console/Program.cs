using System;
using Xadrez_Console.tabuleiro.cs;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args) 
        {
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadLine();
        }
    }
}

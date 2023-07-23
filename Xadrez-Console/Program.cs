using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0)); //colocar torre na posição 0,0
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3)); //colocar torre na posição 1,3
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4)); //colocar rei na posição 2,4

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using tabuleiro;

namespace Xadrez_Console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) 
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null) //Se não houver nenhuma peça na posição
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        //Chamando o método peça no objeto tab
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using tabuleiro;

namespace Xadrez_Console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) 
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.WriteLine(8 - i + "");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null) //Se não houver nenhuma peça na posição
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tab.peca(i, j));
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branco) //Se for branco imprimi
            {
                Console.Write(peca);
            }
            else //Se for preto imprimi como amarelo
            {
                //ConsoleColor é um tipo do C# que pega a cor do sistema
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}

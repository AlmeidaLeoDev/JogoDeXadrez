using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        private Tabuleiro tab;
        private int turno;
        private Cor jogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branco;
        }
    }
}

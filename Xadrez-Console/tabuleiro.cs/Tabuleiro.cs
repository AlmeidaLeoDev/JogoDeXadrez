using System;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; //Só o tabuleiro mexe nas peças. O tabuleiro possui uma matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }

        //Não é possível acessar peça na classe "Tela", pois minha matriz está private para evitar futuros erros
        //Esse método vai me retornar uma peça e burlar o fato da matriz estar privada
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna]; 
        }

        //Sobrecarga do método Peca (acima) que recebe uma posição pos
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        //Método para testar se existe uma peça em uma dada posição
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //Colocar uma peça "p" na posição "pos". isso significa ir na matriz de peças em dada linha e coluna e exibir a peça "p"
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos; //A posição da peça agora será pós
        }

        //Método para retirar peça do tabuleiro
        public Peca retirarPeca(Posicao pos)
        {
            //tira pra fora, marca a posição como nula e retorna a peça
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos); //aux = auxiliar
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        //Método para testar se uma posição é valida
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Esse método vai receber uma posição e caso está não seja válida, será lançado uma exceção personalizada
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }                 
        }
    }
}

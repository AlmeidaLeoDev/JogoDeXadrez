﻿namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        //Testar se a peça não está bloqueada de movimentos
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i,j] == true) //se existe pelo menos um movimento possível retorna true
                    {
                        return true;
                    }
                }
            }
            return false; //Se percorrer todo o método e não achar movimentos possíveis
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        
        public abstract bool[,] movimentosPossiveis();
    }
}

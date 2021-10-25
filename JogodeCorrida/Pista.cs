using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeCorrida
{
    public class Pista
    { 
        public Pista(int tamanho, Corredor atleta)
        {
            this.Tamanho = tamanho;
            this.Atleta = atleta;
            this.posAtleta = 0;
        }
        public int Tamanho { get; set; }

        private int posAtleta;
        public int PosAtleta
        {
            get { return this.posAtleta; }
        }

        public Corredor Atleta { get; set; }

        public Boolean AtualizarCorrida()
        {
            bool ganhou = false;
            if (this.posAtleta < this.Tamanho)
            {
                this.posAtleta += this.Atleta.Correr();
            }
            if (this.posAtleta >= this.Tamanho)
            {
                ganhou = true;
                this.posAtleta = this.Tamanho;
            }
            return ganhou;
        }

        public void ExibePista()
        {
            string pista = "";
            string corredorPista = "";

            //Monta a imagem do corredor na pista na posição atual
            pista = "";
            corredorPista = "";
            for (int i = 1; i <= this.Tamanho; i++)
            {
                pista += "_";
                if (i == this.posAtleta)
                {
                    corredorPista += this.Atleta.Nome;
                }
                else
                {
                    corredorPista += " ";
                }
            }

            //Exibir a pista e o corredor
            Console.WriteLine(corredorPista);
            Console.WriteLine(pista);
        }
    }
}

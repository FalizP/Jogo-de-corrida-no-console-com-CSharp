using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeCorrida
{
    class Jogo
    {
        static void Main(string[] args)
        {
            bool ganhou = false;

            Corredor c1 = new Corredor("l");
            Corredor c2 = new Corredor("k");

            Pista pista1 = new Pista(100, c1);
            Pista pista2 = new Pista(100, c2);
            

            while (!ganhou)
            {
                Console.Clear();

                if (pista1.AtualizarCorrida()) ganhou = true;
                if (pista2.AtualizarCorrida()) ganhou = true;

                pista1.ExibePista();
                pista2.ExibePista();

                Console.ReadKey();
            }
        }
    }
}

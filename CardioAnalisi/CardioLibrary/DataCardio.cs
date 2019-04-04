using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string Battiti(int età)
        {

            if (età <= 0)
            {
                return "Impossibile";
            }
            else
            {
                double Battito_Massimo = 220 - età;
                double Massimo_Consigliato = Battito_Massimo / 100 * 90;
                double Minimo_Consigliato = Battito_Massimo / 100 * 70;
                string Consigliato = ($"{Minimo_Consigliato};{Massimo_Consigliato}");
                return Consigliato;

            }  
        }

        public static string FrequenzaCardio (int battiti)
        {
            if(battiti<0)
            {
                risp = "Imposssibile";
            }

            if(battiti==0)
            {
                risp = "Morto";
            }

            if (battiti < 60 )
            {
                risp = "Bradicardia";
            }

            if (battiti >=60 && battiti<=100)
            {
                risp = "Normale";
            }

            if (battiti > 100)
            {
                risp= "Tachicardia";
            }

            return risp;
        }


    }
}

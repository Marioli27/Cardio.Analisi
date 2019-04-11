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

        public static string FrequenzaCardio(int battiti)
        {
            string risp = "";
            if (battiti < 0)
            {
                risp = "Impossibile";
            }
            else if (battiti == 0)
            {
                risp = "Morto";
            }
            else if (battiti < 60)
            {
                risp = "Bradicardia";
            }
            else if (battiti >= 60 && battiti <= 100)
            {
                risp = "Normale";
            }
            else if (battiti > 100)
            {
                risp = "Tachicardia";
            }

            return risp;
        }

        public static string CalorieBruciate(int A,int P, int F, int T, string sesso)
        {
            string calorie = "";
            if (A > 0 && F > 0 && T > 0 && P > 0)
            {
                if (sesso == "uomo")
                {
                    calorie = Convert.ToString(((A * 0.2017) - (P * 0.199) + (F * 0.6309) - 55.0969) * T / 4.184);
                    return calorie;
                }
                else if (sesso == "donna")
                {
                    calorie = Convert.ToString(((A * 0.074) - (P * 0.126) + (F * 0.4472) - 20.4022) * T / 4.184);
                    return calorie;
                }
            }
            return "Impossibile";
        }


    }
}

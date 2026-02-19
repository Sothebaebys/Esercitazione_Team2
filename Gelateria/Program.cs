using System;
using System.Security.Cryptography.X509Certificates;

class Gelateria
{
    string[] gusti = new { "cioccolato", "vaniglia", "fragola", "pistacchio", "limone" };
    double[] prezzi = new { 1.50, 1.20, 1.30, 1.60, 1.10 };

    static void Main(string[] args)
    {
        bool continua = true;
        string selezione = "";
        //StampaMenu(["Pippo","pluto","paperino"],[12.5,5.1,3.3],[1,2,3]);
        while (continua)
        {
            //StampaMenu();
            Console.WriteLine("Inserisci l'indice del gusto: ");
            int sceltaGusto = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci numero palline: ");
            int sceltaPalline = int.Parse(Console.ReadLine);

            Console.WriteLine("Vuoi aggiungerne un altro gusto? S/N: ");
            if (Console.ReadLine() != "S")
            {
                continua = false;
                Console.WriteLine("Ordine terminato.");
                //CalcolaTotale();
            }

        }

    }

    public static void StampaMenu(string[] gusti, double[] prezzi, int[] indice)
    {
        Console.WriteLine("Gusti:");

        for (int i = 0; i < indice.Length; i++)
        {
            Console.WriteLine($"    -{gusti[i]}\n                 Prezzo:  €{prezzi[i]}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}



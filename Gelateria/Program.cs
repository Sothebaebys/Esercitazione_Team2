using System;

class Gelateria
{
    string[] gusti = new { "cioccolato", "vaniglia", "fragola", "pistacchio", "limone" };
    double[] prezzi = new { 1.50, 1.20, 1.30, 1.60, 1.10 };

    static void Main(string[] args)
    {
        bool continua = true;
        string selezione = "";

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
}


using System;
//using System.Security.Cryptography.X509Certificates;

class GelateriaGelo
{
    // Costante per la soglia sconto
    const double SOGLIA_SCONTO = 10.0;
    public static string[] gusti = ["cioccolato", "vaniglia", "fragola", "pistacchio", "limone"];
    public static double[] prezzi = [1.50, 1.20, 1.30, 1.60, 1.10];
    //int lunghezza= gusti.Length;
    //int[] indice = new int[gusti.Length];

    //Funzione per mandare in stampa il menù
    //In realtà l'argomento si può rimuovere senza problemi e si itera direttamente 
    //tra la lunghezza dell'array gusti/prezzi
    public static void StampaMenu(/*string[] gusti, double[] prezzi , int[] indice*/)
    {
        Console.WriteLine("\n---------------\nMenù dei gelati\n---------------\n");
        // Manda in stampa il menù completo iterando tra gusti e prezzi
        Console.WriteLine("Gusti:");

        // Eventualmente si può sostituire indice con gusti/prezzi
        for (int i = 0; i < gusti.Length /*indice.Length */; i++)
        {
            Console.WriteLine($"    -{i} {gusti[i]}\n                 Prezzo per pallina:  €{prezzi[i]}");
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
    

    static void Main(string[] args)
    {
        bool continua = true;
        string selezione = "";
        //StampaMenu(["Pippo","pluto","paperino"],[12.5,5.1,3.3],[1,2,3]);

        //messaggio di benvenuto
        Console.WriteLine("Benvenuti alla gelateria del gelo! ");
        //StampaMenu(gusti,prezzi);

        while (continua)
        {
            //StampaMenu(gusti,prezzi);
            Console.WriteLine("Inserisci l'indice del gusto: ");
            int sceltaGusto = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci numero palline: ");
            int sceltaPalline = int.Parse(Console.ReadLine());

            Console.WriteLine("Vuoi aggiungerne un altro gusto? S/N: ");
            if (Console.ReadLine() != "S" || Console.ReadLine() != "s" )
            {
                continua = false;
                Console.WriteLine("Ordine terminato.");
                //CalcolaTotale();
            }

        }

    }


}



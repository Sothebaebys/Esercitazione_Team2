using System;

//using System.Security.Cryptography.X509Certificates;

class GelateriaGelo
{
    // Costante per la soglia sconto
    const double SOGLIA_SCONTO = 10.0;
    public static string[] gusti = ["cioccolato", "vaniglia", "fragola", "pistacchio", "limone"];
    public static double[] prezzi = [1.50, 1.20, 1.30, 1.60, 1.10];
    static double totale = 0;
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

    static double CalcoloTotale(double p, int quan, bool subtot)
    {
        if(subtot)
        {
            totale += p * quan;
            //Console.WriteLine($"Gusto: {p} --- Quantita: {quan}"); //--- DEBUG
        }
        if(totale > 10.0d && !subtot)
        {
            totale *= 0.9;
        }
        return totale;
    }


    static void Main(string[] args)
    {
        bool continua = true;
        int totQuantita = 0;
    

        while (continua)
        {
            StampaMenu();
            int sceltaGusto;
            do
            {
                //scegliere un gusto (tramite indice)
                Console.WriteLine("Scegli il gusto desiderato: ");
                sceltaGusto = int.Parse(Console.ReadLine());
                
                //indice non valido, messaggio errore
                if (sceltaGusto < 1 || sceltaGusto > gusti.Length)
                {
                    Console.WriteLine("Selezione errata, riprova.");
                }
            } while (sceltaGusto < 1 || sceltaGusto > gusti.Length);
            

            //inserire la quantità di palline
            int quantita;
            do
            {
                Console.WriteLine("Quante palline vuoi? ");
                quantita = int.Parse(Console.ReadLine());

                // quantità negativa, messaggio errore
                if (quantita <= 0)
                {
                    Console.WriteLine("Selezione errata, riprova.");
                }
            } while (quantita <= 0);
            totQuantita += quantita;


            //decidere se aggiungere un altro gusto o terminare l’ordine.
            Console.WriteLine("Vuoi aggiungere un altro gusto? S/N: ");
            string altroGusto = Console.ReadLine();

            if (altroGusto != "S" || altroGusto != "s")
            {  //CalcolaPrezzo;

                //Al termine, stampa il riepilogo dell’ordine (gusti scelti, quantità, subtotali, sconto e totale finale
                Console.WriteLine($"Hai ordinato {totQuantita} di palline in questi gusti ");
                continua = false;
                Console.WriteLine($"Subtotale: {totale}");
                Console.WriteLine($"Totale con sconto applicato: {CalcoloTotale(prezzi[sceltaGusto], quantita, continua)}");
            }
            CalcoloTotale(prezzi[sceltaGusto], quantita, continua);
        }
    
    }
}
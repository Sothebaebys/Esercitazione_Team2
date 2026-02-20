using System;
class Program
{
    //Array dei gusti: Crea un array di stringhe che contenga almeno 5 gusti di gelato 
    static string[] gusti = { "Cioccolato", "Vaniglia", "Fragola", "Pistacchio", "Limone" };
    //Array dei prezzi: Crea un array parallelo di double con il prezzo per pallina di ciascun gusto.
    static double[] costi = { 1.50, 1.20, 1.30, 1.60, 1.10 };

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

            if (altroGusto != "S")
            {  //CalcolaPrezzo;

                //Al termine, stampa il riepilogo dell’ordine (gusti scelti, quantità, subtotali, sconto e totale finale
                Console.WriteLine($"Hai ordinato {totQuantita} di palline in questi gusti ");
                continua = false;
            }
        }
    }

    //Funzione di stampa menu: Scrivi una funzione StampaMenu() che mostri tutti i gusti con i relativi prezzi.
	
	/*    public static void StampaMenu(string[] gusti, double[] prezzi, int[] indice)
    {
        Console.WriteLine("Gusti:");

        for (int i = 0; i < indice.Length; i++)
        {
            Console.WriteLine($"    -{gusti[i]}\n                 Prezzo:  €{prezzi[i]}");
            Console.WriteLine("--------------------------------------------------");
        }
    }

*/
	
    public static void StampaMenu()
    {
        Console.WriteLine("Benvenuto! Ecco il menù: ");
        Console.WriteLine($"1-{gusti[0]}, {costi[0]}");
        Console.WriteLine($"2-{gusti[1]}, {costi[1]}");
        Console.WriteLine($"3-{gusti[2]}, {costi[2]}");
        Console.WriteLine($"4-{gusti[3]}, {costi[3]}");
        Console.WriteLine($"5-{gusti[4]}, {costi[4]}");
    }

    /*Funzione di calcolo prezzo: Scrivi una funzione CalcolaTotale(int gusto, int quantita) 
            che ritorni il prezzo totale per quel gusto e quella quantità.*/
    public static void CalcolaPrezzo(int totGusti, int totQuantita)
    {

        //Se il totale supera una certa soglia (es. 10€), applica uno sconto del 10%.
    }
}
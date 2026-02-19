using System;

class Gelateria
{
    static double CalcoloTotale(double[] prezzo, string quan, string sel, bool subtot)
    {
        double totale = 0;
        string[] selezioni = sel.Split(" ");
        string[] quantita = quan.Split(" ");
        int giro = 0;
        foreach(string s in selezioni)
        {
            totale += prezzo[(int.Parse(s)) - 1] * double.Parse(quantita[giro]);
            //Console.WriteLine($"Gusto: {prezzo[int.Parse(s) - 1]} --- Quantita: {quantita[giro]}"); //--- DEBUG
            giro++;
        }
        if(totale > 10.0d && !subtot)
        {
            totale *= 0.9;
        }
        return totale;
    }


        //  NEL MAIN CAMBIARE LE SCELTE DI GUSTO E QUANTITA DA INT A STRING, PER FARLO FUNZIONARE CON LA FUNZIONE
        //  DATO CHE LA FUNZIONE FA QUESTO:
        //  SPLITTA ENTRAMBE LE STRINGHE E LE METTE IN UN'ARRAY
        //  IL FOREACH SCORRE L'ARRAY DEL PREZZO BASANDOSI SUGLI INDICI SELEZIONATI DALL'UTENTE (es. IN CASO "SELEZIONE"
        //  NEL MAIN HA COME ORDINE "2 2 5 4 1" NEL FOREACH I PREZZI CHE VERRANNO USATI SARANNO "1.20 - 1. 20 - 1.10 - 1.60 - 1.50").

        //  UN ESEMPIO CHE POTREBBE FUNZIONARE E' string scelte = (Console.ReadLine() + " "), DATO CHE SERVE UN CARATTERE PER SPLITTARE LA STRINGA.
        //  STESSA COSA PER LA QUANTITA'





    /* static void Main(string [] args)
    {
        string[] gusti = new string[]{ "cioccolato", "vaniglia", "fragola", "pistacchio", "limone" };
        double[] prezzi = new double[]{ 1.50, 1.20, 1.30, 1.60, 1.10 };
        string selezione = "1 2 3 4 5";
        string quantita = "2 2 3 2 1";
        bool calcolosubtotale = true;
        Console.WriteLine($"Il subtotale è: {CalcoloTotale(prezzi, quantita, selezione, calcolosubtotale)}");
        calcolosubtotale = false;
        Console.WriteLine($"Il totale è: {CalcoloTotale(prezzi, quantita, selezione, calcolosubtotale)}");
    } //*/ 
}
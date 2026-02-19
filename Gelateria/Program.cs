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
            //Console.WriteLine($"Gusto: {prezzo[int.Parse(s) - 1]} --- Quantita: {quantita[giro]}"); --- DEBUG
            giro++;
        }
        if(totale > 10.0d && !subtot)
        {
            totale *= 0.9;
        }
        return totale;
    }
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
    } */
}
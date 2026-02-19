using System;
using System.Security.Cryptography.X509Certificates;

class Gelateria
{

   public static void StampaMenu(string[] gusti, double[] prezzi, int[] indice)
   { 
      Console.WriteLine("Gusti:");

      for(int i=0; i < indice.Length; i++)
      {
         Console.WriteLine($"    -{gusti[i]}\n                 Prezzo:  €{prezzi[i]}");
         Console.WriteLine("--------------------------------------------------");
      }
   }
   
   static void Main(string [] args)
   {
      //StampaMenu(["Pippo","pluto","paperino"],[12.5,5.1,3.3],[1,2,3]);
   }
}
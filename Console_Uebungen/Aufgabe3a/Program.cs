using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3a
{
   class Program
   {
      static void Main(string[] args)
      {
         //Die obere Grenze wird eingegeben
         Console.Write("Bitte gib eine obere Grenze ein: ");
         int obereGrenze = Convert.ToInt32(Console.ReadLine());

         //Die Start-Zahl wird eingegeben
         Console.Write("Bitte gib eine Start-Zahl ein: ");
         int StartZahl = Convert.ToInt32(Console.ReadLine());

         // Schleifenkopf
         while (StartZahl <= obereGrenze)
         { // Schleifenrumpf
            Console.WriteLine(StartZahl);
            StartZahl = StartZahl + 1; // oder: zähler++ um um 1 zu erhöhen;
         }
      }
   }
}

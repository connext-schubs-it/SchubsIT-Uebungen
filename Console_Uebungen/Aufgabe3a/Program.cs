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
          // Programmbezeichnung
          Console.WriteLine("Programm: Zählschleife");

          // Die obere Grenze wird eingegeben
          Console.Write("Gebe eine obere Grenze ein: ");
          int obereGrenze = Convert.ToInt32(Console.ReadLine());

          // Der Startwert wird eingegeben
          Console.Write("Gebe einen Startwert ein: "); 
          int startwert = Convert.ToInt32(Console.ReadLine());

          // Zählschleife
          while (startwert <= obereGrenze)
          { 
              Console.WriteLine(startwert);
              startwert = startwert + 1; // oder: startwert++, um den Startwert um 1 zu erhöhen;
          }
      }
   }
}

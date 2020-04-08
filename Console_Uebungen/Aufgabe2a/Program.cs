using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2a
{
   class Program
   {
      static void Main(string[] args)
      {
          // Programmbezeichnung
          Console.WriteLine("Programm: Altersüberprüfung");

          // Eingabeaufforderung (Alter wird eingelesen)
          Console.Write("Bitte gebe dein Alter ein: ");
          int alter = Convert.ToInt32(Console.ReadLine()); 

          // Überprüfe auf Volljährigkeit
          if (alter < 18)
          { 
              Console.WriteLine("Genieße die Kinderzeit!");
          }

          else
          {
              Console.WriteLine("Willkommen in der Welt der Erwachsenen!");
          }
      }
   }
}

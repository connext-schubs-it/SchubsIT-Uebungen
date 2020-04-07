using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1a
{
   class Program
   {
      static void Main(string[] args)
      {
          // Programmbezeichnung
          Console.WriteLine("Programm: Vorstellung gegenüber Konsole");

          // Vorname wird eingegeben
          Console.Write("Gebe deinen Voramen ein: ");
          string vorname = Console.ReadLine();

          // Nachname wird eingegeben
          Console.Write("Gebe deinen Nachnamen ein: ");
          string nachname = Console.ReadLine();

          // Alter wird eingegeben
          Console.Write("Gebe dein Alter ein: ");
          int alter = Convert.ToInt32(Console.ReadLine());

          // Vorname, Nachname und Alter werden ausgegeben
          Console.WriteLine("Hallo, " + vorname + " " + nachname + " du bist " + alter + " Jahre alt.");
      }
   }
}

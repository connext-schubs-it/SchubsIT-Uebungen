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
         //Konsolen Titel wird eingetragen
         Console.Title = "Aufgabe 1a";

         //Vorname wird eingegeben
         Console.Write("Bitte gib deinen Voramen ein: ");
         string vorname = Console.ReadLine();

         //Nachname wird eingegeben
         Console.Write("Bitte gib deinen Nachnamen ein: ");
         string nachname = Console.ReadLine();

         //Alter wird eingegeben
         Console.Write("Bitte gib dein Alter ein: ");
         int alter = Convert.ToInt32(Console.ReadLine());

         //Vorname, Nachname und Alter wird ausgegeben
         Console.WriteLine("Hallo, " + vorname + " " + nachname + " du bist " + alter + " Jahre alt.");

         //Durch Tastendruck wird Konsolenanwendung beendet
         Console.ReadKey();
      }
   }
}

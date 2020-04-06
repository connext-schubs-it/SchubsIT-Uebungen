using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Benutzereingaben den Variablen zuordnen
            Console.Write("Gebe eine Zahl ein: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gebe eine weitere Zahl ein: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            // Einfache Berechnungen durchführen und Ergebnisse in Variablen speichern
            int summe = zahl1 + zahl2;
            int differenz = zahl1 - zahl2;
            int produkt = zahl1 * zahl2;
            int quotient = zahl1 / zahl2;
            int rest = zahl1 % zahl2;

            // Ausgangswerte und Ergebnisse formatiert ausgeben
            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + summe);
            Console.WriteLine(zahl1 + " - " + zahl2 + " = " + differenz);
            Console.WriteLine(zahl1 + " * " + zahl2 + " = " + produkt);
            Console.WriteLine(zahl1 + " / " + zahl2 + " = " + quotient);
            Console.WriteLine(zahl1 + " % " + zahl2 + " = " + rest);

            Console.ReadKey();
        }
    }
}
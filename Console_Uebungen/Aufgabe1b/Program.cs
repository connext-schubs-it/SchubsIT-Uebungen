using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmbezeichnung
            Console.WriteLine("Programm: Rechnen mit Zahlen");

            // Initialisierung
            double ergebnis;

            // 1. Eingabeaufforderung
            Console.Write("Gebe eine Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            // 2. Eingabeaufforderung
            Console.Write("Gebe eine weitere Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            // 3. Eingabeaufforderung
            Console.Write("Gebe einen Operator ein: ");
            string eingabe = Console.ReadLine();

            // Überprüfung des Operators
            if (eingabe == "+")
            {
                ergebnis = zahl1 + zahl2;
                Console.WriteLine(ergebnis);
            }
            else if (eingabe == "-")
            {
                ergebnis = zahl1 - zahl2;
                Console.WriteLine(ergebnis);
            }
            else if (eingabe == "*")
            {
                ergebnis = zahl1 * zahl2;
                Console.WriteLine(ergebnis);
            }
            else if (eingabe == "/")
            {
                ergebnis = zahl1 / zahl2;
                Console.WriteLine(ergebnis);
            }
            else // sonst...
            {
                Console.WriteLine("Ungültiger Operator!");
            }
        }
    }
}
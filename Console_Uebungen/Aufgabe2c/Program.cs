using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2c
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmbezeichnung
            Console.WriteLine("Programm: Rechnen mit Zahlen");

            // Initialisierung der Variable "ergebnis"
            double ergebnis;

            // 1. Eingabeaufforderung (1. Zahl wird eingelesen)
            Console.Write("Gebe eine Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            // 2. Eingabeaufforderung (2. Zahl wird eingelesen)
            Console.Write("Gebe eine weitere Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            // 3. Eingabeaufforderung (Operator wird eingelesen)
            Console.Write("Gebe einen Operator ein: ");
            string eingabe = Console.ReadLine();

            // Überprüfung des Operators über einer Switch-Anweisung
            switch (eingabe)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    Console.WriteLine(ergebnis);
                    break;

                case "-":
                    ergebnis = zahl1 - zahl2;
                    Console.WriteLine(ergebnis);
                    break;

                case "*":
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine(ergebnis);
                    break;

                case "/":
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine(ergebnis);
                    break;

                default:
                    Console.WriteLine("Ungültiger Operator!");
                    break;
            }
        }
    }
}

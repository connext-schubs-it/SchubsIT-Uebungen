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
            double ergebnis;
            Console.Write("Gebe eine Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gebe eine weitere Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gebe einen Operator ein: ");
            string eingabe = Console.ReadLine();
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
            else
            {
                Console.WriteLine("Unbekannter Operator!");   
            }

            Console.ReadKey();
        }
    }
}

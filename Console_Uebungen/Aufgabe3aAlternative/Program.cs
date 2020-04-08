using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3aAlternative
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
            for (int i = startwert; i <= obereGrenze; i++)
            {
                Console.WriteLine(i);                
            }
        }
    }
}

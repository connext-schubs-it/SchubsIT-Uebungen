using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getraenkeautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            double preis = 0;
            double eingezahlt = 0;

            Console.WriteLine("Programm: Getränkeautomat");
            Console.WriteLine("Drücken Sie die Taste");
            Console.WriteLine("[1] für Cola - 1.20€");
            Console.WriteLine("[2] für Limonade - 1.00€");
            Console.WriteLine("[3] für Wasser - 0.80€");
            Console.WriteLine("[0] für Beenden");
            Console.Write("Eingabe: ");

            int eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe)
            {
                case 1:
                    preis = 1.2;
                    break;
                case 2:
                    preis = 1;
                    break;
                case 3:
                    preis = 0.8;
                    break;
                case 0:
                    break;
            }

            if (eingabe != 0)
            {
                Console.Write("Geben Sie die gewünschte Anzahl von Getränken ein: ");
                int anzahl = Convert.ToInt32(Console.ReadLine());
                double betrag = preis * anzahl;
                double rest = betrag;

                while (eingezahlt < betrag)
                {
                    Console.WriteLine("Zahlen Sie " + String.Format("{0:0.00}", rest) + " EUR ein: ");
                    double einwurf = Convert.ToDouble(Console.ReadLine());
                    eingezahlt += einwurf;
                    rest -= einwurf;
                }

                Console.WriteLine("Eingezahlt: " + String.Format("{0:0.00}", eingezahlt) + " EUR");
                double rueckbetrag = eingezahlt - betrag;
                Console.WriteLine("Rückbetrag: " + String.Format("{0:0.00}", rueckbetrag) + " EUR");

                if (rueckbetrag > 0)
                {
                    Console.WriteLine("Entnehmen Sie Ihr Rückgeld.");
                }

                for (int i = 1; i <= anzahl; i++)
                {
                    Console.WriteLine("Getränk " + i + " von " + anzahl + " wurde ausgegeben.");
                }
                Console.WriteLine("Vielen Dank. Entnehmen Sie nun Ihre Getränke.");
            }

            else
            {
                Console.WriteLine("Das Programm wurde beendet.");
            }
        }
    }
}

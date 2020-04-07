﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmbezeichnung
            Console.WriteLine("Programm: Eingabeüberprüfung");

            // Eingabeaufforderung (Name wird eingelesen)
            Console.Write("Name?: ");
            string eingabe = Console.ReadLine();

            // Solange eine Eingabe erfolgt
            while (eingabe != "")
            {
                Console.WriteLine("Hallo " + eingabe + " !");

                // Erneute Eingabeaufforderung (Name wird erneut eingelesen)
                Console.Write("Name?: ");
                eingabe = Console.ReadLine();
            }
        }
    }
}
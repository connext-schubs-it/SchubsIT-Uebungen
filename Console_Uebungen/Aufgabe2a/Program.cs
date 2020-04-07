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
         Console.Write("Bitte gib Dein Alter ein: ");

         string eingabe = Console.ReadLine();
         int alter = Convert.ToInt32(eingabe);

         if (alter < 18)
         {
            Console.WriteLine("Du bist leider noch nicht erwachsen.");
         }

         else
         {
            Console.WriteLine("Willkommen in der Welt der Erwachsenen!");
         }
      }
   }
}

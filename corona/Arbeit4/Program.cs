using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeit4
{
    class Program
    {
        public static double Summe(double wert1, double wert2)
        {
            var ergebnis = wert1 + wert2;
            //Console.WriteLine("Ergebnis: {0}", ergebnis);
            return ergebnis;
        }
        static void Main(string[] args)
        {
            //Johanna Innerhofer
            //erste Aufgabe
            int i = 3;
            string[] namen = new string[i];
            try
            {
                for (int z = 0; z <= i + 1; z++)
                {
                    Console.Write("Geben Sie einen Namen ein: ");
                    string name = Console.ReadLine();
                    namen[z] = name;
                }
            }
            catch(Exception e)
            { 
                Console.WriteLine(e.Message);
            }

            //zweite Aufgabe

            try
            {
                var zahl1 = 10;
                var zahl2 = 0;

                var quotient = zahl1 / zahl2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //dritte Aufgabe

            Console.Write("erster Wert: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("zweiter Wert: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if(a != 10 || b != 10)
            {
                try
                {
                    Console.WriteLine(Summe(a, b));
                }
                catch
                {
                    
                }
            }
            else
            {
                throw new Exception("10 ist nicht erlaubt");
            }
        }
    }
}

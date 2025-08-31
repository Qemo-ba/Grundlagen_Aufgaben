using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Calculator
{
    internal class Calculator
    {
        private static double lastResult = 0;

        static internal string add(int a, int b)
        {
            int summe = a + b;
            lastResult = summe;
            return $"{a} + {b} gibt {summe}";
        }

        static internal string sub(int a, int b)
        {
            int summe = a - b;
            lastResult = summe;
            return $"{a} - {b} gibt {summe}";
        }

        static internal string mult(int a, int b)
        {
            int summe = a * b;
            lastResult = summe;
            return $"{a} * {b} gibt {summe}";
        }

        static internal string div(int a, double b)
        {
            double summe = a / b;
            lastResult = summe;
            return $"{a} / {b} gibt {summe}";
        }

        static internal bool schluss()
        {
            Console.WriteLine("Wollen sie nochmal berechnen? ja / nein");
            string choice = Console.ReadLine()?.Trim().ToLower();
            if (choice == "ja")
            {
                return true;
            }
            else if (choice == "nein")
            {
                Console.WriteLine("Calc off");
                return false;
            }
            else
            {
                Console.WriteLine("Ungültig");
                return false;
            }
        }

        static internal double speichern()
        {
            return lastResult;
        }
    }
}

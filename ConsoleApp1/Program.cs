<<<<<<< HEAD
﻿using System.Text;

namespace ConsoleApp1
=======
﻿using System;

namespace HelloWorld
>>>>>>> 98d2682794c1c3857479173c07d85bbabefb2de1
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Ascii();
        }
        static void Ascii()
        {
            Console.WriteLine("Sy\tDez\tHex\tBin");

            for (int code = 32; code < 128; code++)
            {
                char symbol = (char)code;
                string bin = Convert.ToString(code, 2).PadLeft(7, '0'); // 7-Bit Binär
                Console.WriteLine($"{symbol}\t{code}\t0x{code:X2}\t0b{bin}");
            }
        }
    }
}
=======
            Console.WriteLine("Willkommen zum ggT/kgV-Rechner!");

            bool weiter = true;
            while (weiter)
            {
                int a = MyMath.ReadInt();
                int b = MyMath.ReadInt();

                Console.WriteLine("Möchten Sie ggT oder kgV berechnen?");
                string choice = Console.ReadLine();

                if (choice == "ggt")
                {
                    int ggt = MyMath.Calc_ggT(a, b);
                    int ggt_r = MyMath.Calc_ggT_r(a, b);
                    Console.WriteLine(MyMath.ShowResult("ggt", a, b, ggt));
                    Console.WriteLine($"rekursiv berechnet: {ggt_r}");
                }
                else if (choice == "kgv")
                {
                    int kgv = MyMath.Calc_kgv(a, b);
                    Console.WriteLine(MyMath.ShowResult("kgv", a, b, kgv));
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl!");
                }

                Console.Write("Neu Berechnen? (j/n): ");
                string answer = Console.ReadLine();
                if (answer != "j")
                {
                    weiter = false;
                }
            }

            Console.WriteLine("\nArray Test");
            int[] arr = MyMath.ReadArray();
            Console.WriteLine($"Mittelwert: {MyMath.Avg(arr)}");
            Console.WriteLine($"Kleinster Wert: {MyMath.Min(arr)}");
            Console.WriteLine($"Grösster Wert: {MyMath.Max(arr)}");

            Console.WriteLine("\n--- Swap Test ---");
            int x = 5, y = 10;
            Console.WriteLine($"Vor Swap: x={x}, y={y}");
            MyMath.Swap(ref x, ref y);
            Console.WriteLine($"Nach Swap: x={x}, y={y}");

            Console.WriteLine("Programm beendet.");
        }
    }
}
>>>>>>> 98d2682794c1c3857479173c07d85bbabefb2de1

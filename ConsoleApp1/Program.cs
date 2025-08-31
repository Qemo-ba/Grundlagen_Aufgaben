using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

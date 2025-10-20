namespace kontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde = new Kunde();
            kunde.Add();
            Console.WriteLine("nochmal eins");
            kunde.Add();
            Console.WriteLine("OKE REICHT");
            kunde.Remove();
        }
    }
}

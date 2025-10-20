namespace lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde("Robuster", "Tango", 100, "KEY", 10);
            Lagerist lagerist1 = new Lagerist("rüstem", "test", 102, "KEY1", 1.80);
            Kind kind1 = new Kind("kind", "kind", 233, "KEY3", 9);

            kunde1.TestKey();
            kunde1.Essen();
            kunde1.Trage();
            kunde1.Kaufe();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kind1.Essen();
            kind1.Trage();

        }
    }
}

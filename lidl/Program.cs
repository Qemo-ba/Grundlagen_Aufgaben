namespace lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde("Robuster", "Tango", 100, "KEY", 10);
            Lagerist lagerist1 = new Lagerist("rüstem", "test", 102, "KEY1", 1.80);
            Kind kind1 = new Kind("kind", "kind", 233, "KEY3", 9);
            //Chatbot bot1 = new Chatbot();
            //Chatbot bot2 = new Chatbot();
            //Chatbot bot3 = new Chatbot();
            //Chatbot[] bots = {bot1, bot2, bot3};
            //foreach (var bot in bots)
            //{
            //bot.publiziere("video");
            //}
            List<Chatbot> bots = new List<Chatbot>();
            bots.Add(new Chatbot());
            bots.Add(new Chatbot());
            bots.Add(new Chatbot());
            bots.Add(new Chatbot());
            bots.Add(new Chatbot());


            foreach (var bot in bots)
            {
                Console.Write($"Der bot publiziert ");
                bot.publiziere("video");
            }

            Console.WriteLine("\n\nKunde");
            kunde1.zahle(5);
            kunde1.publiziere("video");
            Console.WriteLine("\nKind");
            kind1.publiziere("video");
            Console.WriteLine("\nLagerist");
            lagerist1.zahle(70);
            lagerist1.publiziere("video");

            

        

        }
    }
}

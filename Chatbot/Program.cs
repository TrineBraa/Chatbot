using System.Diagnostics;

namespace Chatbot
{
    internal class Program
    {
        public static void Main()
        {
            //Chættbått’n
            //    Du skal lage en app hvor man kan lage sin egen chatbot - og deretter velge å snakke med den:)
            //    Brukeren skal få prompt på chættbått navn, og deretter mulighet til å skrive inn forskjellige tilbakemeldinger / svar som chættbått’n skal trekke et tilfeldig svar fra og svare brukeren med når den startes opp.
            //    Bruk gjerne en meny for å gå inn i de forskjellige modusene: “mekke en chættbått” og “preke med en chættbått”
            //BONUS:
            //Mulighet til å lage flere chættbåtts, brukeren skal kunne se en liste av tilgjengelige chættbåtts og velge hvem h * n vil snakke med - her må det brukes List fra neste ukes pensum.


            // Lage en tom string liste til setninger(prompts) som legges inn av bruker (i chatbot class)
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to this chatboxchatter/Maker\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("Choose what you wish to do:");
            Console.WriteLine();
            Console.WriteLine("1 Chat with a chatbot");
            Console.WriteLine("2 Make a New Chatbot");
            Console.WriteLine("3 exit app");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Container.ShowBots();
                    Main();
                    break;
                case "2":
                    Container.createBot();
                    Main();
                    break;
                case "3":
                    Environment.Exit(69);
                    break;
            }

        }
    }
}

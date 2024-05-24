using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    public class chatbot
    {
        public string Name;
        public List<string> Responses = new List<string>();
        private string currentBot;


        public chatbot(string name, List<string> response)
        {
            Name = name;
            Responses = response;
        }

        public chatbot(string name)
        {
            Name = name;
        }

        public void AddBotAnswers(int howMany)
        {
            Console.WriteLine("What responses do you want to add to the Chatbot?\n");

            for (int i = 0; i < howMany; i++)
            {
                Responses.Add(Console.ReadLine());
                Console.WriteLine("You added a New Response to the bot!");
            }
        }

        public void chatWithBot()
        {
            if (Responses.Count > -1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string userInput = Console.ReadLine();
                if (userInput == "x" || userInput == "X")
                {
                    Program.Main();
                }
                else
                {
                    string response = Responses[getRandomNumber()];
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Container.currentBot.Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(": " + response + "\n");
                    Console.WriteLine("\nPress X to go back.\n");
                    chatWithBot();
                }
            }
        }

        private int getRandomNumber()
        {
            Random r = new Random();
            int listCount = Responses.Count;
            return r.Next(0, listCount);
        }
    }


}

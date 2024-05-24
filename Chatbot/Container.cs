namespace Chatbot
{
    public class Container
    {

        public static List<chatbot> chatBots = new List<chatbot>
        {
            new("Peder", ["Hello", "bye"]),
        };

        public static chatbot currentBot;



        public static void createBot()
        {
            Console.WriteLine("Create your own Chatbot! \n");
            Console.WriteLine("What do you want to name the bot?");
            var newBot = new chatbot(Console.ReadLine());
            chatBots.Add(newBot);
            CreateResponses(newBot);


        }

        public static void ShowBots()
        {
            for (int i = 0; i < chatBots.Count; i++)
            {
                var currentbot = chatBots[i];
                Console.WriteLine((i+1) + ") " + currentbot.Name);
            }

            ChooseBot();
        }

        private static void ChooseBot()
        {
            Console.Write("\nChoose what bot to chat with: ");
            var answerStr = Console.ReadLine();
            var answer = Convert.ToInt32(answerStr);
            currentBot = chatBots[answer-1];
            currentBot.chatWithBot();
        }

        private static void CreateResponses(chatbot botInProgress)
        {
            Console.WriteLine("\nHow many responses do you want the bot to have?");
            string howManyStr = Console.ReadLine();

            if (Int32.TryParse(howManyStr, out int howManyInt))
            {
                botInProgress.AddBotAnswers(howManyInt);
            }
            else
            {
                Console.WriteLine("Please input a number.");
                CreateResponses(botInProgress);
            }
        }
    }
}
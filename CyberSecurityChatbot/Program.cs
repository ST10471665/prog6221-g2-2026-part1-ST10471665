using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
====================================
 CYBERSECURITY AWARENESS CHATBOT
====================================
");
            Console.ResetColor();
          
            Console.Write("Enter your name: ");
                string name = Console.ReadLine();

            Console.WriteLine($"Welcome, {name}! I will help you stay safe online.");

            // 🤖 Create chatbot
            Chatbot bot = new Chatbot();

            // 🔁 Chat loop
            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine();

                if (input.ToLower().Contains("exit"))
                    break;

                string response = bot.GetResponse(input);
                Console.WriteLine("Bot: " + response);
            }
        }
    }
}
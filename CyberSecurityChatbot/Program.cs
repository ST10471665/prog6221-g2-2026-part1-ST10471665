using System;
using System.Media;
using System.Diagnostics;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🎤 VOICE GREETING
            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "welcome.wav");

                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio error: " + ex.Message);
            }

            // 🖼️ ASCII HEADER
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
====================================
 CYBERSECURITY AWARENESS CHATBOT
====================================
");

            Console.ResetColor();

            // 👤 USER INPUT
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

                // ✅ VALIDATION FIRST
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter something.");
                    continue;
                }

                if (input.ToLower().Contains("exit"))
                    break;

                string response = bot.GetResponse(input);
                Console.WriteLine("Bot: " + response);
            }
        }
    }
}

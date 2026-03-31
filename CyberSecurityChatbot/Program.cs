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
        }
    }
}
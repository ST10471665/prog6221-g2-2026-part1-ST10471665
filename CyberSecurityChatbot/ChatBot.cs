using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm doing great!";

            if (input.Contains("purpose"))
                return "I help users stay safe online.";

            if (input.Contains("what can i ask"))
                return "You can ask about passwords, phishing, and safe browsing.";

            if (input.Contains("password"))
                return "Use strong, unique passwords.";

            if (input.Contains("phishing"))
                return "Avoid suspicious emails.";

            if (input.Contains("safe browsing"))
                return "Only visit trusted websites.";

            return "I didn’t quite understand that. Could you rephrase?";
        }
    }
}

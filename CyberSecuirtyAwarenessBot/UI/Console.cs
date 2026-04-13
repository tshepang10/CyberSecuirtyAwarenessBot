using System.Text;

namespace CyberSecurityAwarenessBot.UI
{
    public static class ConsoleUI
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("==============================================================");
            Console.ResetColor();

            Console.ForegroundColor = (ConsoleColor.Blue);
            Console.WriteLine(@" 
     ____  _                 _       _____                 
   / ___|| |__   ___   ___ | | __  | ____|_ __ ___  _ __  
   \___ \| '_ \ / _ \ / _ \| |/ /  |  _| | '_ ` _ \| '_ \ 
    ___) | | | | (_) | (_) |   <   | |___| | | | | | |_) |
   |____/|_| |_|\___/ \___/|_|\_\  |_____|_| |_| |_| .__/ 
                                                  |_|     
                     
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stay alert. Stay secure. Stay informed.");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Bot: ");
            Console.ResetColor();
            TypeText(message);
            Console.WriteLine();
        }

        public static void WriteUserPrompt(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void TypeText(string text, int delay = 20)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}
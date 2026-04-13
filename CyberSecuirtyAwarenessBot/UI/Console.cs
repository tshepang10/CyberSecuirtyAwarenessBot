using System;
using System.Threading;

namespace CyberSecurityAwarenessBot.UI
{
    public static class ConsoleUI
    {
        // 🔥 MATRIX EFFECT
        public static void ShowMatrixEffect(int duration = 2000)
        {
            Random rand = new Random();
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            DateTime end = DateTime.Now.AddMilliseconds(duration);

            Console.ForegroundColor = ConsoleColor.Green;

            while (DateTime.Now < end)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                Console.SetCursorPosition(x, y);
                Console.Write((char)rand.Next(33, 126));

                Thread.Sleep(5);
            }

            Console.ResetColor();
            Console.Clear();
        }

        // 🎬 HEADER WITH TYPING EFFECT
        public static void DisplayHeader()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==============================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeLine("        🔐 CYBERSECURITY AWARENESS BOT 🔐", 40);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==============================================================");
            Console.ResetColor();

            // ASCII ART
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
   ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝ ╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║       ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║        ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗    ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝    ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeLine("        [ PROTECT • DETECT • PREVENT ]", 30);
            TypeLine("     >>> Think Before You Click <<<", 30);
            Console.WriteLine();
            Console.ResetColor();
        }

        // 🔐 LOGIN SYSTEM
        public static bool Login()
        {
            const string correctUser = "admin";
            const string correctPass = "1234";

            WriteBotMessage("=== LOGIN REQUIRED ===");

            for (int i = 0; i < 3; i++)
            {
                WriteUserPrompt("Username: ");
                string? user = Console.ReadLine();

                WriteUserPrompt("Password: ");
                string? pass = Console.ReadLine();

                if (user == correctUser && pass == correctPass)
                {
                    WriteSuccess("✔ Login successful!");
                    return true;
                }

                WriteError("Invalid credentials. Try again.");
            }

            WriteError("Too many failed attempts. Exiting...");
            return false;
        }

        // 🤖 BOT MESSAGE (Typing effect)
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
            Console.Write("You: ");
            Console.ResetColor();

            Console.Write(message);
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
            Console.ResetColor();
        }

        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // 🔤 TYPING EFFECT (for chatbot)
        private static void TypeText(string text, int delay = 20)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        // 🔤 TYPING EFFECT (for title lines)
        private static void TypeLine(string text, int delay = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
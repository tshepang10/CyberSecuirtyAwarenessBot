using CyberSecurityAwarenessBot.Models;
using CyberSecurityAwarenessBot.UI;

namespace CyberSecurityAwarenessBot.Services
{
    public class ChatbotService
    {
        private readonly ResponseService _responseService;

        public ChatbotService()
        {
            _responseService = new ResponseService();
        }

        public void StartChat(UserProfile user)
        {
            bool isRunning = true;

            while (isRunning)
            {
                string input = GetUserInput(user.Name);

                if (!IsValidInput(input))
                {
                    ShowInputError();
                    continue;
                }

                DisplayResponse(input, user.Name);

                if (IsExitCommand(input))
                {
                    isRunning = false;
                }
            }
        }

        // Handles user input
        private string GetUserInput(string userName)
        {
            ConsoleUI.WriteUserPrompt($"{userName}: ");
            return Console.ReadLine() ?? string.Empty;
        }

        // Validates input
        private bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Displays error message
        private void ShowInputError()
        {
            ConsoleUI.WriteError("Invalid input. Please type a valid question.");
        }

        // Processes and displays chatbot response
        private void DisplayResponse(string input, string userName)
        {
            string response = _responseService.GetResponse(input, userName);
            ConsoleUI.WriteBotMessage(response);
        }

        // Checks if user wants to exit
        private bool IsExitCommand(string input)
        {
            return input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase);
        }
    }
}
namespace CyberSecurityAwarenessBot.Services
{
    public class ResponseService
    {
        public string GetResponse(string userInput, string userName)
        {
            string input = userInput.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return "You entered nothing. Please type a question so I can help you.";
            }

            if (input.Contains("how are you"))
            {
                return $"I am doing well, {userName}. Thank you for asking. I am ready to help you with cybersecurity awareness.";
            }

            if (input.Contains("what's your purpose") || input.Contains("what is your purpose"))
            {
                return "My purpose is to educate users about cybersecurity risks and help them stay safe online.";
            }

            if (input.Contains("what can i ask you about"))
            {
                return "You can ask me about password safety, phishing, suspicious links, scams, safe browsing, and basic online protection.";
            }

            if (input.Contains("password"))
            {
                return "Use strong passwords with a mix of uppercase letters, lowercase letters, numbers, and symbols. Avoid using your name or birth date.";
            }

            if (input.Contains("phishing"))
            {
                return "Phishing is a scam where attackers pretend to be trusted organisations to steal your personal information. Do not click suspicious links or share passwords.";
            }

            if (input.Contains("safe browsing") || input.Contains("browse safely") || input.Contains("browsing"))
            {
                return "To browse safely, only visit trusted websites, check for HTTPS, avoid clicking unknown pop-ups, and keep your browser updated.";
            }

            if (input.Contains("suspicious link") || input.Contains("link"))
            {
                return "Before clicking a link, hover over it to inspect the URL. If it looks strange, shortened, or unrelated to the sender, do not click it.";
            }

            if (input.Contains("scam"))
            {
                return "Online scams often create urgency or fear. Be cautious of messages asking for money, OTPs, passwords, or banking details.";
            }

            if (input == "exit")
            {
                return $"Goodbye, {userName}. Stay safe online!";
            }

            return "I didn’t quite understand that. Could you rephrase? You can ask about passwords, phishing, or safe browsing.";
        }
    }
}
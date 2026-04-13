namespace CyberSecurityAwarenessBot.Services
{
    public class ResponseService
    {
        public string GetResponse(string userInput, string userName)
        {
            string input = NormalizeInput(userInput);

            if (IsEmpty(input))
                return GetEmptyResponse();

            if (Contains(input, "how are you"))
                return GetGreetingResponse(userName);

            if (Contains(input, "what's your purpose", "what is your purpose"))
                return GetPurposeResponse();

            if (Contains(input, "what can i ask you about"))
                return GetHelpResponse();

            if (Contains(input, "password"))
                return GetPasswordAdvice();

            if (Contains(input, "phishing"))
                return GetPhishingInfo();

            if (Contains(input, "safe browsing", "browse safely", "browsing"))
                return GetSafeBrowsingTips();

            if (Contains(input, "suspicious link", "link"))
                return GetLinkWarning();

            if (Contains(input, "scam"))
                return GetScamWarning();

            if (IsExit(input))
                return GetExitMessage(userName);

            return GetDefaultResponse();
        }

        // -------- Helper Methods --------

        private string NormalizeInput(string input)
        {
            return input.ToLower().Trim();
        }

        private bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        private bool Contains(string input, params string[] keywords)
        {
            foreach (var keyword in keywords)
            {
                if (input.Contains(keyword))
                    return true;
            }
            return false;
        }

        private bool IsExit(string input)
        {
            return input == "exit";
        }

        // -------- Response Methods --------

        private string GetEmptyResponse()
        {
            return "You entered nothing. Please type a question so I can help you.";
        }

        private string GetGreetingResponse(string userName)
        {
            return $"I am doing well, {userName}. Thank you for asking. I am ready to help you with cybersecurity awareness.";
        }

        private string GetPurposeResponse()
        {
            return "My purpose is to educate users about cybersecurity risks and help them stay safe online.";
        }

        private string GetHelpResponse()
        {
            return "You can ask me about password safety, phishing, suspicious links, scams, safe browsing, and basic online protection.";
        }

        private string GetPasswordAdvice()
        {
            return "Use strong passwords with a mix of uppercase letters, lowercase letters, numbers, and symbols. Avoid using your name or birth date.";
        }

        private string GetPhishingInfo()
        {
            return "Phishing is a scam where attackers pretend to be trusted organisations to steal your personal information. Do not click suspicious links or share passwords.";
        }

        private string GetSafeBrowsingTips()
        {
            return "To browse safely, only visit trusted websites, check for HTTPS, avoid clicking unknown pop-ups, and keep your browser updated.";
        }

        private string GetLinkWarning()
        {
            return "Before clicking a link, hover over it to inspect the URL. If it looks strange, shortened, or unrelated to the sender, do not click it.";
        }

        private string GetScamWarning()
        {
            return "Online scams often create urgency or fear. Be cautious of messages asking for money, OTPs, passwords, or banking details.";
        }

        private string GetExitMessage(string userName)
        {
            return $"Goodbye, {userName}. Stay safe online!";
        }

        private string GetDefaultResponse()
        {
            return "I didn’t quite understand that. Could you rephrase? You can ask about passwords, phishing, or safe browsing.";
        }
    }
}
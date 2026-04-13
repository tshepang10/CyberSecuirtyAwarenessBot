using System;
using System.IO;
using System.Media;

namespace CyberSecurityAwarenessBot.Services
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Play();
                }
                else
                {
                    Console.WriteLine("[Audio file not found. Continuing without voice greeting.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Audio error: " + ex.Message + "]");
            }
        }
    }
}

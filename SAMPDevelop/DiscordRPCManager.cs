using DiscordRPC;
using System;
using System.IO;

namespace SAMPDevelop
{
    public class DiscordRPCManager
    {
        private DiscordRpcClient discordClient;
        private DateTime fileEditingStartTime;
        private string currentFileName;
        private string currentFileDirectory;

        public DiscordRPCManager()
        {
            InitializeDiscordRPC();
        }

        private void InitializeDiscordRPC()
        {
            discordClient = new DiscordRpcClient("1216334413923618867");
            discordClient.OnReady += (sender, e) =>
            {
                Console.WriteLine("Conectado ao Discord!");
            };

            discordClient.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Atualização de presença enviada para o Discord!");
            };

            discordClient.Initialize();
        }

        public void UpdatePresenceOnFileOpenOrEdit(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            currentFileName = Path.GetFileName(filePath);
            currentFileDirectory = Path.GetDirectoryName(filePath);
            fileEditingStartTime = DateTime.UtcNow;
            UpdateDiscordPresence($"Editing {currentFileName}", $"File {extension}");
        }

        private void UpdateDiscordPresence(string details, string state)
        {
            TimeSpan elapsedTime = DateTime.UtcNow - fileEditingStartTime;

            discordClient.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Timestamps = new Timestamps(DateTime.UtcNow - elapsedTime),
                Assets = new Assets()
                {
                    LargeImageKey = "pawn-icon",
                    LargeImageText = "PawnDevelop",
                    SmallImageKey = "code-icon",
                    SmallImageText = $"{Path.GetExtension(currentFileName)}"
                }
            });
        }

        public void OnFormClosing()
        {
            Dispose();
        }

        public void Dispose()
        {
            discordClient.Dispose();
        }
    }
}
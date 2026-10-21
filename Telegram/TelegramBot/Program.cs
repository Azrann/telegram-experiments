using System;

namespace TelegramBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientFactory clientFactory = new ClientFactory();
            var client = clientFactory.GetClient().Result;
            var bot = new TelegramBot(client);
            
            
            var chats = bot.GetChannels().Result;
            int chatId = 1233391324;
            long channelaccessId = 0;
            foreach (var chat in chats)
            {
                if (chat.Title.Contains("CryptoTraders"))
                {
                    chatId = chat.Id;
                    channelaccessId = chat.AccessHash;
                }
            }
            
            int userId = 446447317;
            long access = 0;
            long channelaccess = 0;
            var result = bot.FindUser("", userId).Result;
            //bot.AddUserToChannel(userId, chatId, access,channelaccess).Wait();
            //bot.Subscribe();
            Console.WriteLine("Waiting for updates");
            Console.ReadKey();
        }
    }
}

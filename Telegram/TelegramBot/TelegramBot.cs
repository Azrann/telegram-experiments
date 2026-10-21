using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenTl.ClientApi;
using OpenTl.Schema;
using OpenTl.Schema.Channels;

namespace TelegramBot
{
    public class TelegramBot
    {
        private readonly IClientApi _client;

        public TelegramBot(IClientApi client)
        {
            _client = client;
        }

        public void Subscribe()
        {
            _client.UpdatesService.RecieveUpdates += UpdatesServiceOnRecieveUpdates;
        }

        internal Task UpdatesServiceOnRecieveUpdates(IUpdates update)
        {
                switch (update)
                {
                    case TUpdates updates:
                        break;
                    case TUpdatesCombined updatesCombined:
                        break;
                    case TUpdateShort updateShort:
                        break;
                    case TUpdateShortChatMessage updateShortChatMessage:
                        break;
                    case TUpdateShortMessage updateShortMessage:
                        break;
                    case TUpdateShortSentMessage updateShortSentMessage:
                        break;
                    case TUpdatesTooLong updatesTooLong:
                        break;
                }
            return null;
        }

        internal async Task<IEnumerable<TChannel>> GetChannels()
        {
            var result = new List<TChannel>();
            var response = await _client.MessagesService.GetUserDialogsAsync(100);
            foreach (var chat in response.Chats)
            {
                if (chat is TChannel channel)
                {
                    result.Add(channel);
                }
            }
            return result;
        }

        internal async Task<IEnumerable<TContact>> Contacts()
        {
            var result = await _client.ContactsService.GetContactsAsync();
            return result.Contacts.Select(x => (OpenTl.Schema.TContact)x);
        }

        public async Task<TUserFull> FindUser(string username, int userId)
        {
            return await _client.UsersService.GetUserFullAsync(
                new TInputUser()
                {
                    UserId = userId
                });
        }

        internal async Task AddUserToChannel(int userId, int channelId, long accessHash, long accessHashChannel)
        {
            var requestInvite = new RequestInviteToChannel();
            requestInvite.Channel = new TInputChannel()
            {
                ChannelId = channelId,
                AccessHash = accessHashChannel
            };
            requestInvite.Users = new TVector<IInputUser>(new TInputUser()
            {
                UserId = userId,
                AccessHash = accessHash
            });

           
            await _client.CustomRequestsService.SendRequestAsync(requestInvite);
            // await tClient.TClientAPI.CustomRequestsService.SendRequestAsync(requestInvite);
            //var result = await _client.MessagesService.AddChatUserAsync(channelId,,0);
            return;
        }
    }

    public class InviteUser : IRequest
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZendeskApi_v2.Models.Locales;
using ZendeskApi_v2.Models.Tickets;

namespace ZendeskApi_v2.Requests;

public interface ISideConversations : ICore
{
    #if SYNC
    GroupSideConversationResponse GetAllOnTicket(long ticketId);
    #endif

    #if ASYNC
    Task<GroupSideConversationResponse> GetAllOnTicketAsync(long ticketId);
    #endif
}

public class SideConversations : Core, ISideConversations
{
    public SideConversations(string yourZendeskUrl, string user, string password, string apiToken, string p_OAuthToken)
        : base(yourZendeskUrl, user, password, apiToken, p_OAuthToken) {}

    #if SYNC
    public GroupSideConversationResponse GetAllOnTicket(long ticketId)
    {
        return GenericGet<GroupSideConversationResponse>($"tickets/{ticketId}/side_conversations.json");
    }
    #endif

    #if ASYNC
    public async Task<GroupSideConversationResponse> GetAllOnTicketAsync(long ticketId)
    {
        return await GenericGetAsync<GroupSideConversationResponse>($"tickets/{ticketId}/side_conversations.json");
    }
    #endif
}

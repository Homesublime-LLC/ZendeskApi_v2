using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ZendeskApi_v2.Models.Tickets;

namespace ZendeskApi_v2.Models.Locales;

public class GroupSideConversationResponse : GroupResponseBase
{
    [JsonProperty("side_conversations")]
    public IList<SideConversation> SideConversations { get; set; }
}

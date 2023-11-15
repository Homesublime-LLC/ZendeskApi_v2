using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.Tickets;

public class Participant
{
    [JsonProperty("user_id")]
    public long UserId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("slack_workspace_id")]
    public string SlackWorkspaceId { get; set; }

    [JsonProperty("slack_channel_id")]
    public string SlackChannelId { get; set; }

    [JsonProperty("support_group_id")]
    public string SupportGroupId { get; set; }

    [JsonProperty("support_agent_id")]
    public string SupportAgentId { get; set; }

    [JsonProperty("msteams_channel_id")]
    public string MsTeamsChannelId { get; set; }

}

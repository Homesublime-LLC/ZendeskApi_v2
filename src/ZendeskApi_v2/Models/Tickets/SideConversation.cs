using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ZendeskApi_v2.Models.Tickets;

public class SideConversation
{
    [JsonProperty("created_at")]
    [JsonConverter(typeof(IsoDateTimeConverter))]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("message_added_at")]
    [JsonConverter(typeof(IsoDateTimeConverter))]
    public DateTimeOffset MessageAddedAt { get; set; }

    [JsonProperty("participants")]
    public IList<Participant> Participants { get; set; }

    [JsonProperty("preview_text")]
    public string PreviewText { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("state_updated_at")]
    [JsonConverter(typeof(IsoDateTimeConverter))]
    public DateTimeOffset StateUpdatedAt { get; set; }

    [JsonProperty("subject")]
    public string Subject { get; set; }

    [JsonProperty("ticket_id")]
    public long TicketId { get; set; }

    [JsonProperty("updated_at")]
    [JsonConverter(typeof(IsoDateTimeConverter))]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

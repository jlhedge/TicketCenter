using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TicketCenter.Data.Models.Extensions;
using TicketCenter.Data.Models.TicketCenterAdmin;

namespace TicketCenter.Data.Models.TicketCenter;

[Table("TicketInteractions", Schema="TicketCenter")]
public class TicketInteraction : Logging
{
    public Guid TicketId { get; set; }
    [EmailAddress]
    public string? Email { get; set; } = default!;
    public long StatusId { get; set; }
    public string? Notes { get; set; }

    [JsonIgnore]
    public Ticket Ticket { get; set; } = new Ticket();
    public StatusType StatusType { get; set; } = new StatusType();
}
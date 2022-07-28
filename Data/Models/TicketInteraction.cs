using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TicketCenter.Data.Models;

[Table("TicketInteractions", Schema="Tickets")]
public class TicketInteraction
{
    public Guid TicketId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public string? CreatedByLogon { get; set; }
    [EmailAddress]
    public string? Email { get; set; } = default!;
    public string? Notes { get; set; }

    [JsonIgnore]
    public Ticket Ticket { get; set; }
}
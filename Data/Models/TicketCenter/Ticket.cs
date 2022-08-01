using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketCenter.Data.Models.Extensions;
using TicketCenter.Data.Models.TicketCenterAdmin;

namespace TicketCenter.Data.Models.TicketCenter;

[Table("Tickets", Schema="TicketCenter")]
public class Ticket : Logging
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public long StatusId { get; set; }
    [EmailAddress]
    public string Email { get; set; } = default!;

    public List<TicketInteraction> TicketInteractions { get; set; }
    public StatusType StatusType { get; set; }
}
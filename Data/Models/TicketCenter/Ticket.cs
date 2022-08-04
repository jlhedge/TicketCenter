using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketCenter.Data.Models.Extensions;
using TicketCenter.Data.Models.TicketCenterAdmin;

namespace TicketCenter.Data.Models.TicketCenter;

[Table("Tickets", Schema="TicketCenter")]
public class Ticket : Logging
{
    [Key]
    public Guid TicketId { get; set; } = Guid.NewGuid();
    public long StatusTypeId { get; set; }
    public List<TicketInteraction> TicketInteractions { get; set; }
    public StatusType StatusType { get; set; }
}
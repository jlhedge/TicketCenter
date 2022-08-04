using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketCenter.Data.Models.Extensions;
using TicketCenter.Data.Models.TicketCenter;

namespace TicketCenter.Data.Models.TicketCenterAdmin;

[Table("StatuseTypes", Schema="TicketCenterAdmin")]
public class StatusType : Logging
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long StatusTypeId { get; set; }                                           
    public long RequestTypeId { get; set; }
    public string Description { get; set; } = default!;

    public RequestType RequestType { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<TicketInteraction> TicketInteractions { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCenter.Data.Models;

[Table("Tickets", Schema="Tickets")]
public class Ticket
{
    [Key]
    public Guid TicketId { get; set; } = new Guid();
    public Guid ApplicationId { get; set; }
    public Guid SectionId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public string? CreatedByLogon { get; set; }
    [EmailAddress]
    public string Email { get; set; } = default!;

    public List<TicketInteraction> TicketInteractions { get; set; } = new List<TicketInteraction>();
}
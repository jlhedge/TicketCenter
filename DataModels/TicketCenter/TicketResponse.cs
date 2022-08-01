using System.ComponentModel.DataAnnotations;
using TicketCenter.Data.Models.TicketCenter;

namespace TicketCenter.DataModels.TicketCenter;

public class TicketResponse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public long StatusId { get; set; }
    [EmailAddress]
    public string Email { get; set; } = default!;
    public DateTime CreatedOnUtc { get; set; }
    public List<TicketInteractionResponse> TicketInteractions { get; set; }
}
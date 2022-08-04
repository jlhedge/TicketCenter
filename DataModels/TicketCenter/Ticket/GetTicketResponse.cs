using System.ComponentModel.DataAnnotations;
using TicketCenter.Data.Models.TicketCenter;
using TicketCenter.DataModels.TicketCenter.TicketInteraction;

namespace TicketCenter.DataModels.TicketCenter.Ticket;

public class GetTicketResponse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public long StatusId { get; set; }
    [EmailAddress]
    public string Email { get; set; } = default!;
    public DateTime CreatedOnUtc { get; set; }
    public List<GetTicketInteractionResponse> TicketInteractions { get; set; }
}
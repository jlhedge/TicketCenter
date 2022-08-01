using System.ComponentModel.DataAnnotations;
namespace TicketCenter.DataModels.TicketCenter;

public class TicketInteractionResponse
{
    public Guid TicketId { get; set; }
    [EmailAddress]
    public string? Email { get; set; } = default!;
    public long StatusId { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedOnUtc { get; set; }
}
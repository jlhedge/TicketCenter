using System.ComponentModel.DataAnnotations;
using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenter.TicketInteraction;

public class PutTicketInteractionRequest : PutLogging
{
    public Guid UserId { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public long StatusId { get; set; }
    public string Notes { get; set; }
}
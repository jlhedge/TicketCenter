using System.ComponentModel.DataAnnotations;
using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenter;

public class PostTicketRequest : PostLogging
{
    public Guid UserId { get; set; }
    [EmailAddress]
    public string Email { get; set; }
}
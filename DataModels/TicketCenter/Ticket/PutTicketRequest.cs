using System.ComponentModel.DataAnnotations;
using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenter.Ticket;

public class PutTicketRequest : PutLogging
{
    public Guid UserId { get; set; }
    [EmailAddress]
    public string Email { get; set; }
}
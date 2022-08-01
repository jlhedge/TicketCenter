using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenter;
using TicketCenter.DataModels.TicketCenter;

namespace TicketCenter.Interfaces.TicketCenter;

public interface ITicketService
{
    Task<List<TicketInteraction>> GetAll();
    Task<List<TicketInteraction>> GetByTicketId(long TicketId);
    Task<TicketInteraction> GetTicketInteraction(long TicketId, DateTime CreatedOn);
    Task<Ticket> Update(long TicketId, DateTime CreatedOn);
    Task<ActionResult<Ticket>> Create(PostTicketRequest request, CancellationToken xl); 
}
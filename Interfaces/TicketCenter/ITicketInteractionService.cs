using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenter;
using TicketCenter.DataModels.TicketCenter.TicketInteraction;

namespace TicketCenter.Interfaces.TicketCenter;

public interface ITicketInteractionService
{
    Task<List<Ticket>> GetAll();
    Task<Ticket> GetById(long Ticket);
    Task<Ticket> Update(Ticket request);
    Task<ActionResult<Ticket>> Create(PostTicketInteractionRequest request, CancellationToken xl); 
}
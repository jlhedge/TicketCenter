using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenter;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenter;
using TicketCenter.DataModels.TicketCenter.TicketInteraction;

namespace TicketCenter.Services.TicketCenter;

public class TicketInteractionService : ITicketInteractionService
{
    dbContext _dbContext;

    public TicketInteractionService(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<Ticket>> Create(PostTicketInteractionRequest request, CancellationToken xl)
    {
        throw new NotImplementedException();
    }

    public Task<List<Ticket>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> GetById(long Ticket)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> Update(Ticket request)
    {
        throw new NotImplementedException();
    }
}
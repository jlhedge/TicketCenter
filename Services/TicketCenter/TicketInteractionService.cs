using TicketCenter.Data.Models;
using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenter;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.TicketCenter;
using TicketCenter.Data.Models.TicketCenter;

namespace TicketCenter.Services.TicketCenter;

public class TicketInteractionService : ITicketInteractionService
{
    TicketCenterDbContext _dbContext;

    public TicketInteractionService(TicketCenterDbContext dbContext)
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
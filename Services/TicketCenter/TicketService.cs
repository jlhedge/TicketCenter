using TicketCenter.Data.Models;
using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenter;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.TicketCenter;
using TicketCenter.Data.Models.TicketCenter;

namespace TicketCenter.Services.TicketCenter;

public class TicketService : ITicketService
{
    TicketCenterDbContext _dbContext;

    public TicketService(TicketCenterDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<Ticket>> Create(PostTicketRequest request, CancellationToken xl)
    {
        throw new NotImplementedException();
    }

    public Task<List<TicketInteraction>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<TicketInteraction>> GetByTicketId(long TicketId)
    {
        throw new NotImplementedException();
    }

    public Task<TicketInteraction> GetTicketInteraction(long TicketId, DateTime CreatedOn)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> Update(long TicketId, DateTime CreatedOn)
    {
        throw new NotImplementedException();
    }
}
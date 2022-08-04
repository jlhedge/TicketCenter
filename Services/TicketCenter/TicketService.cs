using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenter;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.TicketCenter.Ticket;

namespace TicketCenter.Services.TicketCenter;

public class TicketService : ITicketService
{
    dbContext _dbContext;

    public TicketService(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<PostTicketResponse>> Create(PostTicketRequest request, CancellationToken xl)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetTicketResponse>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<GetTicketResponse>> GetByTicketId(long TicketId)
    {
        throw new NotImplementedException();
    }

    public Task<GetTicketResponse> GetTicketWithInteractions(long TicketId, DateTime CreatedOn)
    {
        throw new NotImplementedException();
    }

    public Task<PutTicketResponse> Update(PutTicketRequest request)
    {
        throw new NotImplementedException();
    }
}
using TicketCenter.Data.Models;
using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenterAdmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.TicketCenterAdmin;
using TicketCenter.Data.Models.TicketCenterAdmin;

namespace TicketCenter.Services.TicketCenterAdmin;

public class RequestTypeService : IRequestTypeService
{
    TicketCenterDbContext _dbContext;

    public RequestTypeService(TicketCenterDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<RequestType>> Create(PostRequestTypeRequest request, CancellationToken xl)
    {
        throw new NotImplementedException();
    }

    public Task<List<RequestType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<RequestType> GetById(Guid RequestTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<RequestType> Update(RequestType request)
    {
        throw new NotImplementedException();
    }
}
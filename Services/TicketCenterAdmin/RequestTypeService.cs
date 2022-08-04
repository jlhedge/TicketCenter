using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenterAdmin;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenterAdmin;
using TicketCenter.DataModels.TicketCenterAdmin.RequestType;

namespace TicketCenter.Services.TicketCenterAdmin;

public class RequestTypeService : IRequestTypeService
{
    dbContext _dbContext;

    public RequestTypeService(dbContext dbContext)
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
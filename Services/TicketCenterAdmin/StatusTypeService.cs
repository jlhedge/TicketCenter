using TicketCenter.Data.Models.TicketCenterAdmin;
using TicketCenter.Data;
using TicketCenter.Interfaces.TicketCenterAdmin;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.TicketCenterAdmin.StatusType;

namespace TicketCenter.Services.TicketCenterAdmin;

public class StatusTypeService : IStatusTypeService
{
    dbContext _dbContext;

    public StatusTypeService(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<StatusType>> Create(PostStatusTypeRequest request, CancellationToken xl)
    {
        throw new NotImplementedException();
    }

    public Task<List<StatusType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<StatusType> GetById(Guid AppId)
    {
        throw new NotImplementedException();
    }

    public Task<StatusType> Update(StatusType request)
    {
        throw new NotImplementedException();
    }
}
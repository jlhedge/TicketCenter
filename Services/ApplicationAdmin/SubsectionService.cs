using TicketCenter.Data.Models;
using TicketCenter.Data;
using TicketCenter.Interfaces.ApplicationAdmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.ApplicationAdmin;
using TicketCenter.Data.Models.ApplicationAdmin;

namespace TicketCenter.Services.ApplicationAdmin;

public class SubSectionService : ISubsectionService
{
    TicketCenterDbContext _dbContext;

    public SubSectionService(TicketCenterDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<App>> Create(PostAppRequest request, CancellationToken xl)
    {
        throw new NotImplementedException();
    }

    public Task<List<App>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<App> GetById(Guid AppId)
    {
        throw new NotImplementedException();
    }

    public Task<App> Update(App request)
    {
        throw new NotImplementedException();
    }
}
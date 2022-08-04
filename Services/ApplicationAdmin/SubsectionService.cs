using TicketCenter.Data;
using TicketCenter.Interfaces.ApplicationAdmin;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.App;
using TicketCenter.DataModels.ApplicationAdmin.Subsection;

namespace TicketCenter.Services.ApplicationAdmin;

public class SubSectionService : ISubsectionService
{
    dbContext _dbContext;

    public SubSectionService(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ActionResult<App>> Create(PostSubsectionRequest request, CancellationToken xl)
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
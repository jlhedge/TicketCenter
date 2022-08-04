using TicketCenter.Data;
using TicketCenter.Interfaces.ApplicationAdmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.App;

namespace TicketCenter.Services.ApplicationAdmin;

public class ApplicationService : IApplicationService
{
    dbContext _dbContext;

    public ApplicationService(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<App>> GetAll()
    {
        return await _dbContext.Applications
            .ToListAsync();
    }

    public async Task<App> GetById(Guid AppId)
    {
        return await _dbContext.Applications.FindAsync(AppId);
    }

    public Task<App> Update(App request)
    {
        throw new NotImplementedException();
    }

    async Task<ActionResult<App>> IApplicationService.Create(PostAppRequest request, CancellationToken xl)
    {
        App x = new App(){
            AppId = Guid.NewGuid(),
            ApplicationDescription = request.ApplicationDescription, 
            ApplicationName = request.ApplicationName, 
            CreatedByLogon = request.CreatedByLogon, 
            CreatedOnUtc = DateTime.UtcNow
        };

        var y = _dbContext.Add(x);

        await _dbContext.SaveChangesAsync(cancellationToken: xl);

        return x; 
    }

    async Task<List<App>> IApplicationService.GetAll()
    {
        return await _dbContext.Applications
            .ToListAsync();
    }

    async Task<App> IApplicationService.GetById(Guid AppId)
    {
        return await _dbContext.Applications
            .FindAsync(AppId);
    }

    Task<App> IApplicationService.Update(App request)
    {
        throw new NotImplementedException();
    }
}
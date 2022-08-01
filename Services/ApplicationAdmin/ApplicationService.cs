using TicketCenter.Data.Models;
using TicketCenter.Data;
using TicketCenter.Interfaces.ApplicationAdmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.ApplicationAdmin;
using TicketCenter.Data.Models.ApplicationAdmin;

namespace TicketCenter.Services.ApplicationAdmin;

public class ApplicationService : IApplicationService
{
    TicketCenterDbContext _dbContext;

    public ApplicationService(TicketCenterDbContext dbContext)
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

    async Task<ActionResult<AppResponse>> IApplicationService.Create(PostAppRequest request, CancellationToken xl)
    {
        App x = new App(){
            Id = Guid.NewGuid(),
            ApplicationDescription = request.ApplicationDescription, 
            ApplicationName = request.ApplicationName, 
            CreatedByLogon = request.CreatedByLogon, 
            CreatedOnUtc = DateTime.UtcNow
        };

        var y = _dbContext.Add(x);

        await _dbContext.SaveChangesAsync(cancellationToken: xl);

        return x; 
    }

    async Task<List<AppResponse>> IApplicationService.GetAll()
    {
        return await _dbContext.Applications
            .ToListAsync();
    }

    async Task<AppResponse> IApplicationService.GetById(Guid AppId)
    {
        return await _dbContext.Applications
            .FindAsync(AppId);
    }

    Task<AppResponse> IApplicationService.Update(App request)
    {
        throw new NotImplementedException();
    }
}
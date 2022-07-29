using TicketCenter.Data.Models;
using TicketCenter.Data;
using TicketCenter.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace TicketCenter.Services;

public class ApplicationService : IApplicationService
{
    TicketCenterDbContext _dbContext;

    public ApplicationService(TicketCenterDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    async Task<App> IApplicationService.Create(App request)
    {
        App x = new App(){
            ApplicationDescription = request.ApplicationDescription, 
            ApplicationName = request.ApplicationName, 
            CreatedByLogon = request.CreatedByLogon, 
            IsEnabled = request.IsEnabled, 
            CreatedOnUtc = DateTime.UtcNow
        };

        await _dbContext.AddAsync(x);

        return x;
    }

    async Task<List<App>> IApplicationService.GetAll()
    {
        return await _dbContext.Applications
            .ToListAsync();
    }

    Task<App> IApplicationService.GetById(Guid AppId)
    {
        throw new NotImplementedException();
    }

    Task<App> IApplicationService.Update(App request)
    {
        throw new NotImplementedException();
    }
}
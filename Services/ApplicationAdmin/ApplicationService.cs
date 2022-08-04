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

    public async Task<List<GetAppResponse>> GetAll()
    {
        return await _dbContext.Applications
            .Select(i => new GetAppResponse()
            {
                ApplicationName = i.ApplicationName, 
                ApplicationDescription = i.ApplicationDescription, 
                AppId = i.AppId
            })
            .ToListAsync();
    }

    public async Task<GetAppResponse> GetById(Guid AppId)
    {
        App app = await _dbContext.Applications
            .FindAsync(AppId) ?? new App();
            
        return new GetAppResponse()
        {
            ApplicationName = app.ApplicationName, 
            ApplicationDescription = app.ApplicationDescription, 
            AppId = app.AppId
        };
    }

    public async Task<PutAppResponse> Update(PutAppRequest request)
    {
        App app = await _dbContext.Applications
            .FindAsync(request.AppId) ?? new App();

        app.ApplicationDescription = request.ApplicationDescription ?? app.ApplicationDescription;
        app.ApplicationName = request.ApplicationName ?? app.ApplicationName;
        app.IsEnabled = request.IsEnabled; 
        // app.UpdatedByLogon = request.UpdatedByLogon;
        app.UpdatedOnUtc = DateTime.UtcNow;
        
        await _dbContext.SaveChangesAsync();

        PutAppResponse response = new PutAppResponse()
        {
            AppId = app.AppId, 
            ApplicationName = app.ApplicationName, 
            ApplicationDescription = app.ApplicationDescription
        };

        return response;

    }

    public async Task<ActionResult<PostAppResponse>> Create(PostAppRequest request, CancellationToken xl)
    {
        App app = new App(){
            AppId = Guid.NewGuid(),
            ApplicationDescription = request.ApplicationDescription, 
            ApplicationName = request.ApplicationName, 
            CreatedByLogon = request.CreatedByLogon, 
            CreatedOnUtc = DateTime.UtcNow
        };

        _dbContext.Add(app);
        await _dbContext.SaveChangesAsync(cancellationToken: xl);

        return new PostAppResponse()
        {
            AppId = app.AppId, 
            ApplicationName = app.ApplicationName, 
            ApplicationDescription = app.ApplicationDescription
        }; 
    }
}
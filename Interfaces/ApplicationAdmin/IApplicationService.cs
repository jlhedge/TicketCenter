using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.App;

namespace TicketCenter.Interfaces.ApplicationAdmin;

public interface IApplicationService
{
    Task<List<App>> GetAll();
    Task<App> GetById(Guid AppId);
    Task<App> Update(App request);
    Task<ActionResult<App>> Create(PostAppRequest request, CancellationToken xl); 
}
using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.Page;

namespace TicketCenter.Interfaces.ApplicationAdmin;

public interface IPageService
{
    Task<List<App>> GetAll();
    Task<App> GetById(Guid AppId);
    Task<App> Update(App request);
    Task<ActionResult<App>> Create(PostPageRequest request, CancellationToken xl); 
}
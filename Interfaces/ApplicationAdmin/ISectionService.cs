using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.Section;

namespace TicketCenter.Interfaces.ApplicationAdmin;

public interface ISectionService
{
    Task<List<App>> GetAll();
    Task<App> GetById(Guid AppId);
    Task<App> Update(App request);
    Task<ActionResult<App>> Create(PostSectionRequest request, CancellationToken xl); 
}
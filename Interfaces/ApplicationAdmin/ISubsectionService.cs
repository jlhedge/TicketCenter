using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.Subsection;

namespace TicketCenter.Interfaces.ApplicationAdmin;

public interface ISubsectionService
{
    Task<List<App>> GetAll();
    Task<App> GetById(Guid AppId);
    Task<App> Update(App request);
    Task<ActionResult<App>> Create(PostSubsectionRequest request, CancellationToken xl); 
}
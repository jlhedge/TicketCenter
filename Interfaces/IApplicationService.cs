using TicketCenter.Data.Models;

namespace TicketCenter.Interfaces;

public interface IApplicationService
{
    Task<List<App>> GetAll();
    Task<App> GetById(Guid AppId);
    Task<App> Update(App request);
    Task<App> Create(App request); 
}
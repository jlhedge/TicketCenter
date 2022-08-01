using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin;

namespace TicketCenter.Interfaces.ApplicationAdmin;

public interface IApplicationService
{
    Task<List<AppResponse>> GetAll();
    Task<AppResponse> GetById(Guid AppId);
    Task<AppResponse> Update(App request);
    Task<ActionResult<AppResponse>> Create(PostAppRequest request, CancellationToken xl); 
}
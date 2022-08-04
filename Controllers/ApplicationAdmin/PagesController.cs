using TicketCenter.Interfaces.ApplicationAdmin;
using TicketCenter.Data.Models.ApplicationAdmin;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.ApplicationAdmin;
using TicketCenter.DataModels.ApplicationAdmin.Page;

namespace TicketCenter.Controllers.ApplicationAdmin;

[ApiController]
[Route("ApplicationAdmin/[Controller]/[Action]")]
public class PagesController : ControllerBase
{
    IPageService _svc;

    public PagesController(IPageService svc)
    {
        _svc = svc;
    }

    [HttpGet]
    public async Task<App> GetById(Guid AppId)
    {
        return await _svc.GetById(AppId);
    }

    [HttpGet]
    public async Task<List<App>> GetAll()
    {
        return await _svc.GetAll();
    }

    [HttpPost]
    public async Task<ActionResult<App>> CreateAsync(PostPageRequest request)
    {
        return await _svc.Create(request, new CancellationToken());
    }

}
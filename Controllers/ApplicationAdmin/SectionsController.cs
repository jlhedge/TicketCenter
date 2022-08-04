using TicketCenter.Interfaces.ApplicationAdmin;
using TicketCenter.Data.Models.ApplicationAdmin;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.DataModels.ApplicationAdmin.Section;

namespace TicketCenter.Controllers.ApplicationAdmin;

[ApiController]
[Route("ApplicationAdmin/[Controller]/[Action]")]
public class SectionsController : ControllerBase
{
    ISectionService _svc;

    public SectionsController(ISectionService svc)
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
    public async Task<ActionResult<App>> CreateAsync(PostSectionRequest request)
    {
        return await _svc.Create(request, new CancellationToken());
    }

}
using TicketCenter.Interfaces;
using TicketCenter.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace TicketCenter.Controllers;

[ApiController]
[Route("[Controller]/[Action]")]
public class ApplicationController : ControllerBase
{
    IApplicationService _svc;

    public ApplicationController(IApplicationService svc)
    {
        _svc = svc;
    }

    public async Task<App> CreateAsync(App request)
    {
        return await _svc.Create(request);
    }
}
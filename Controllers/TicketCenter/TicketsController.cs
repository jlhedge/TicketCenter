using TicketCenter.Data.Models.ApplicationAdmin;
using Microsoft.AspNetCore.Mvc;
using TicketCenter.Interfaces.TicketCenter;
using TicketCenter.DataModels.TicketCenter.Ticket;

namespace TicketCenter.Controllers.TicketCenter;

[ApiController]
[Route("TicketCenter/[Controller]/[Action]")]
public class TicketsController : ControllerBase
{
    ITicketService _svc;

    public TicketsController(ITicketService svc)
    {
        _svc = svc;
    }

    [HttpGet]
    public async Task<GetTicketResponse> GetAll()
    {
        return await _svc.GetAll();
    }

    [HttpGet]
    public async Task<List<App>> GetAll()
    {
        return await _svc.GetAll();
    }

    [HttpPost]
    public async Task<ActionResult<App>> CreateAsync(PostTicketRequest request)
    {
        return await _svc.Create(request, new CancellationToken());
    }

}
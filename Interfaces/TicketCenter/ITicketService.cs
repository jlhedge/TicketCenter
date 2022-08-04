using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenter;
using TicketCenter.DataModels.TicketCenter.Ticket;

namespace TicketCenter.Interfaces.TicketCenter;

public interface ITicketService
{
    Task<List<GetTicketResponse>> GetAll();
    Task<List<GetTicketResponse>> GetByTicketId(long TicketId);
    Task<GetTicketResponse> GetTicketWithInteractions(long TicketId, DateTime CreatedOn);
    Task<PutTicketResponse> Update(PutTicketRequest request);
    Task<ActionResult<PostTicketRequest>> Create(PostTicketRequest request, CancellationToken xl); 
}
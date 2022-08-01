using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenterAdmin;
using TicketCenter.DataModels.TicketCenterAdmin;

namespace TicketCenter.Interfaces.TicketCenterAdmin;

public interface IRequestTypeService
{
    Task<List<RequestType>> GetAll();
    Task<RequestType> GetById(Guid RequestTypeId);
    Task<RequestType> Update(RequestType request);
    Task<ActionResult<RequestType>> Create(PostRequestTypeRequest request, CancellationToken xl); 
}
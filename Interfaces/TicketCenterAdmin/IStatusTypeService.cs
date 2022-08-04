using Microsoft.AspNetCore.Mvc;
using TicketCenter.Data.Models.TicketCenterAdmin;
using TicketCenter.DataModels.TicketCenterAdmin.StatusType;

namespace TicketCenter.Interfaces.TicketCenterAdmin;

public interface IStatusTypeService
{
    Task<List<StatusType>> GetAll();
    Task<StatusType> GetById(Guid AppId);
    Task<StatusType> Update(StatusType request);
    Task<ActionResult<StatusType>> Create(PostStatusTypeRequest request, CancellationToken xl); 
}
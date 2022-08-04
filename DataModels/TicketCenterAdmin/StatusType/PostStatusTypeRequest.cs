using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenterAdmin.StatusType;

public class PostStatusTypeRequest : PostLogging
{
    public string StatusTypeName { get; set; }
    public string StatusTypeDescription { get; set; }
}
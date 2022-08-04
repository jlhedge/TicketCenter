using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenterAdmin.StatusType;

public class PutStatusTypeRequest : PutLogging
{
    public string StatusTypeName { get; set; }
    public string StatusTypeDescription { get; set; }
}
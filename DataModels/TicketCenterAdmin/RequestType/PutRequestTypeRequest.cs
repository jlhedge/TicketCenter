using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenterAdmin.RequestType;

public class PostRequestTypeRequest : PostLogging
{
    public string RequestName { get; set; }
    public string RequestDescription { get; set; }
}
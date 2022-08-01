using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.TicketCenterAdmin;

public class PutRequestTypeRequest : PutLogging
{
    public string RequestName { get; set; }
    public string RequestDescription { get; set; }
}
using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin;

public class PutPageRequest : PutLogging
{
    public string PageName { get; set; }
    public string PageDescription { get; set; }
}
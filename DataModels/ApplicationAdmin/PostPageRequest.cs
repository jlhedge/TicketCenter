using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin;

public class PostPageRequest : PostLogging
{
    public string PageName { get; set; }
    public string PageDescription { get; set; }
}
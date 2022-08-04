using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin.App;

public class PostAppRequest : PostLogging
{
    public string ApplicationName { get; set; }
    public string ApplicationDescription { get; set; }
}
using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin.App;

public class PutAppRequest : PutLogging
{
    public string ApplicationName { get; set; }
    public string ApplicationDescription { get; set; }
    public Guid AppId { get; set; }
    public bool IsEnabled { get; set; }
    public Guid UserId { get; set; }
}
using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin;

public class PostSubsectionRequest : PostLogging
{
    public string SubsectionName { get; set; }
    public string SubsectionDescription { get; set; }
}
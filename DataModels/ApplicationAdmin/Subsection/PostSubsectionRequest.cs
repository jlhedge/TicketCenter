using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin.Subsection;

public class PostSubsectionRequest : PostLogging
{
    public string SubsectionName { get; set; }
    public string SubsectionDescription { get; set; }
}
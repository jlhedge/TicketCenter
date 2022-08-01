using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin;

public class PutSubsectionRequest : PutLogging
{
    public string SubsectionName { get; set; }
    public string SubsectionDescription { get; set; }
}
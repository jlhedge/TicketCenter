using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin;

public class PutSectionRequest : PutLogging
{
    public string SectionName { get; set; }
    public string SectionDescription { get; set; }
}
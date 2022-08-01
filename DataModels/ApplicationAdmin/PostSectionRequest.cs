using TicketCenter.DataModels.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin;

public class PostSectionRequest : PostLogging
{
    public string SectionName { get; set; }
    public string SectionDescription { get; set; }
}
namespace TicketCenter.DataModels.ApplicationAdmin.Section;

public class SectionResponse{

    public Guid Id { get; set; } = Guid.NewGuid();    
    public Guid PageId { get; set; }
    public string SectionName { get; set; }
    public string SectionDescription { get; set; }
}
namespace TicketCenter.DataModels.ApplicationAdmin;

public class SubsectionResponse{

    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SectionId { get; set; }
    public string SubsectionName { get; set; }
    public string SubsectionDescription { get; set; }

}
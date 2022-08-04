namespace TicketCenter.DataModels.TicketCenterAdmin;

public class RequestTypeResponse
{
    public long Id { get; set; }                                           
    public Guid SubSectionId { get; set; }
    public string Description { get; set; } = default!;

}
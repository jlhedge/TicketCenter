namespace TicketCenter.DataModels.TicketCenterAdmin;

public class StatusTypeResponse
{
    public long Id { get; set; }                                           
    public long RequestTypeId { get; set; }
    public string Description { get; set; } = default!;
}
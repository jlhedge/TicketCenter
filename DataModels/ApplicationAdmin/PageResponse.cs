namespace TicketCenter.Data.Models.ApplicationAdmin;
public class PageResponse{

    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ApplicationId { get; set; }
    public string PageName { get; set; }
    public string PageDescription { get; set; }
    public bool IsEnabled { get; set; }
}
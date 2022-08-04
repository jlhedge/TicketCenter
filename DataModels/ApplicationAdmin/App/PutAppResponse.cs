using System.ComponentModel.DataAnnotations;

namespace TicketCenter.DataModels.ApplicationAdmin.App;

public class PutAppResponse {

    [Key]
    public Guid AppId { get; set; }
    
    [Required]
    [MaxLength(77)]
    public string ApplicationName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string ApplicationDescription { get; set; }
}
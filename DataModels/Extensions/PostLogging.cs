using System.ComponentModel.DataAnnotations;

namespace TicketCenter.DataModels.Extensions;

public class PostLogging
{   
    [Required]
    [MaxLength(250)]
    public string CreatedByLogon { get; set; }

    [Required]
    public DateTime CreatedOnUtc { get; set; }
}
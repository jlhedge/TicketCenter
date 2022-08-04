using System.ComponentModel.DataAnnotations;

namespace TicketCenter.Data.Models.Extensions;

public class Logging
{
    [Required]
    public bool IsEnabled { get; set; }
    
    [Required]
    [MaxLength(250)]
    public Guid CreatedByUserId { get; set; }

    [Required]
    public DateTime CreatedOnUtc { get; set; }

    [MaxLength(250)]
    public Guid? UpdatedByUserId { get; set; }

    public DateTime? UpdatedOnUtc { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCenter.Data.Models;

public class Application{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    [MaxLength(77)]
    public string ApplicationName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string ApplicationDescription { get; set; }

    [Required]
    public bool IsEnabled { get; set; }
    
    [Required]
    [MaxLength(250)]
    public string CreatedByLogon { get; set; }

    [Required]
    public DateTime CreatedOnUtc { get; set; }

    [MaxLength(250)]
    public string UpdatedByLogon { get; set; }

    public DateTime UpdatedOnUtc { get; set; }

    public List<Ticket> Tickets { get; set; }

    public List<Section> Sections { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCenter.Data.Models;

[Table("Section", Schema = "TicketCenter")]
public class Section{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public Guid ApplicationId { get; set; }

    [Required]
    [MaxLength(77)]
    public string SectionName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string SectionDescription { get; set; }

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
    public App Application { get; set; }
}
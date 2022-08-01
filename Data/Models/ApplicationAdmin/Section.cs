using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketCenter.Data.Models.Extensions;

namespace TicketCenter.Data.Models.ApplicationAdmin;

[Table("Sections", Schema = "dbo")]
public class Section : Logging{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public Guid PageId { get; set; }

    [Required]
    [MaxLength(77)]
    public string SectionName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string SectionDescription { get; set; }

    public Page Page { get; set; }
    public List<Subsection> Subsections { get; set; }
}
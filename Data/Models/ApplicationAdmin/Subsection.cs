using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketCenter.Data.Models.TicketCenterAdmin;
using TicketCenter.Data.Models.Extensions;

namespace TicketCenter.Data.Models.ApplicationAdmin;

[Table("SubSections", Schema = "dbo")]
public class Subsection : Logging{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public Guid SectionId { get; set; }

    [Required]
    [MaxLength(77)]
    public string SubsectionName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string SubsectionDescription { get; set; }

    public Section Section { get; set; }
    public List<RequestType> RequestTypes { get; set; }
}
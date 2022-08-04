using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketCenter.Data.Models.Extensions;
using TicketCenter.Data.Models.ApplicationAdmin;

namespace TicketCenter.Data.Models.TicketCenterAdmin;

[Table("RequestTypes", Schema="TicketCenterAdmin")]
public class RequestType : Logging
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long RequestTypeId { get; set; }                                           
    public Guid SubSectionId { get; set; }
    public string Description { get; set; } = default!;

    public Subsection Subsection { get; set; }
    public List<StatusType> StatusTypes { get; set; }

}
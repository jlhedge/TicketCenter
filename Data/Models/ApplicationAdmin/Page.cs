using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TicketCenter.Data.Models.Extensions;

namespace TicketCenter.Data.Models.ApplicationAdmin;

[Table("Pages", Schema = "ApplicationAdmin")]
public class Page : Logging{

    [Key]
    public Guid PageId { get; set; } = Guid.NewGuid();
    
    public Guid AppId { get; set; }

    [Required]
    [MaxLength(77)]
    public string PageName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string PageDescription { get; set; }

    [JsonIgnore]
    public App App { get; set; }
    [JsonIgnore]
    public List<Section> Sections { get; set; } = new List<Section>();
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TicketCenter.Data.Models.Extensions;

namespace TicketCenter.DataModels.ApplicationAdmin.App;

[Table("Applications", Schema = "dbo")]
public class AppResponse : Logging {

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    [MaxLength(77)]
    public string ApplicationName { get; set; }
    
    [Required]
    [MaxLength(750)]
    public string ApplicationDescription { get; set; }

    // [JsonIgnore]
    // public List<Pages> Pages { get; set; } = new List<Page>();
}
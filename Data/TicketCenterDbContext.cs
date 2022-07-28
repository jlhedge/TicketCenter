using Microsoft.EntityFrameworkCore;
using TicketCenter.Data.Models;

namespace TicketCenter.Data.Models;

public class TicketCenterDbContext : DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketInteraction> TicketInteractions { get; set; }

    public TicketCenterDbContext() : base()
    {

    } 

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        
    }
}
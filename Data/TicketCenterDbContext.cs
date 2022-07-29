using Microsoft.EntityFrameworkCore;
using TicketCenter.Data.Models;

namespace TicketCenter.Data;

public class TicketCenterDbContext : DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketInteraction> TicketInteractions { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Section> Sections { get; set; }

    public TicketCenterDbContext() : base()
    {

    } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(entity => {
            entity.HasKey(i => i.TicketId)
                .HasName("PK_Ticket_TicketId");
        });

        modelBuilder.Entity<Ticket>(entity => {
            entity.HasMany(i => i.TicketInteractions)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId)
                .HasPrincipalKey(i => i.TicketId)
                .HasConstraintName("FK_Ticket_TicketInteraction_TicketId");
        });

        modelBuilder.Entity<Ticket>(entity => {
            entity.HasOne(i => i.Section)
                .WithMany(i => i.Tickets)
                .HasForeignKey(i => i.SectionId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Ticket_Section_SectionId");
        });

        modelBuilder.Entity<Section>(entity => {
            entity.HasOne(i => i.Application)
                .WithMany(i => i.Sections)
                .HasForeignKey(i => i.ApplicationId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Section_Application_ApplicationId");
        });

        modelBuilder.Entity<Section>(entity => {
            entity.HasKey(i => i.Id)
            .HasName("PK_Section_Id");
        });

        modelBuilder.Entity<Application>(entity => {
            entity.HasKey(i => i.Id)
            .HasName("PK_Application_Id");
        });

        modelBuilder.Entity<TicketInteraction>(entity => {
            entity.HasIndex(i => new {
                i.TicketId, 
                i.CreatedOnUtc
            }).IsClustered(true);
        });

    }
}
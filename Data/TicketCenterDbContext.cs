using Microsoft.EntityFrameworkCore;
using TicketCenter.Data.Models.ApplicationAdmin;
using TicketCenter.Data.Models.TicketCenter;
using TicketCenter.Data.Models.TicketCenterAdmin;

namespace TicketCenter.Data;

public class TicketCenterDbContext : DbContext
{
    public DbSet<App> Applications { get; set; }
    public DbSet<Page> Pages { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Subsection> Subsections { get; set; }
    public DbSet<RequestType> RequestTypes { get; set; }
    public DbSet<StatusType> StatusTypes { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketInteraction> TicketInteractions { get; set; }

    public TicketCenterDbContext(DbContextOptions<TicketCenterDbContext> options) : base(options)
    {

    } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<TicketInteraction>(entity => {
            entity.HasKey(i => new {
                i.TicketId, 
                i.CreatedOnUtc
            })
            .HasName("PK_TicketInteractions_TicketId_CreatedOnUtc");

            entity.HasOne(i => i.Ticket)
                .WithMany(i => i.TicketInteractions)
                .HasForeignKey(i => i.TicketId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_TicketInteractions_Tickets_TicketId")
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(i => i.StatusType)
                .WithMany(i => i.TicketInteractions)
                .HasForeignKey(i => i.StatusId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_TicketInteractions_Status_StatusId");
        });
        
        modelBuilder.Entity<Ticket>(entity => {
            entity.HasKey(i => i.Id)
                .HasName("PK_Ticket_Id");

            entity.HasOne(i => i.StatusType)
                .WithMany(i => i.Tickets)
                .HasForeignKey(i => i.StatusId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Tickets_Statuses_StatusId");
        });

        modelBuilder.Entity<StatusType>(entity => {
            entity.HasKey(i => i.Id)
            .HasName("PK_Status_StatusId");

            entity.HasOne(i => i.RequestType)
                .WithMany(i => i.StatusTypes)
                .HasForeignKey(i => i.RequestTypeId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Statuses_RequestTypes_RequestTypeId");
        });

        modelBuilder.Entity<RequestType>(entity => {
            entity.HasKey(i => i.Id)
            .HasName("PK_RequestType_Id");

            entity.HasOne(i => i.Subsection)
                .WithMany(i => i.RequestTypes)
                .HasForeignKey(i => i.SubSectionId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_RequestTypes_Subsections_SubsectionId");
        });

        modelBuilder.Entity<Subsection>(entity => {
            entity.HasKey(i => i.Id)
                .HasName("PK_Subsections_Id");

            entity.HasOne(i => i.Section)
                .WithMany(i => i.Subsections)
                .HasForeignKey(i => i.SectionId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Subsections_Sections_SectionId");
        });

        modelBuilder.Entity<Section>(entity => {
            entity.HasKey(i => i.Id)
            .HasName("PK_Sections_Id");

            entity.HasOne(i => i.Page)
                .WithMany(i => i.Sections)
                .HasForeignKey(i => i.PageId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Sections_Pages_PageId");
        });

        modelBuilder.Entity<Page>(entity => {
            entity.HasKey(i => i.Id)
                .HasName("PK_Pages_PageId");

            entity.HasOne(i => i.App)
                .WithMany(i => i.Pages)
                .HasForeignKey(i => i.ApplicationId)
                .HasPrincipalKey(i => i.Id)
                .HasConstraintName("FK_Pages_Applications_ApplicationId");
        });

        modelBuilder.Entity<App>(entity => {
            entity.HasKey(i => i.Id)
            .HasName("PK_Application_Id");
        });
    }
}
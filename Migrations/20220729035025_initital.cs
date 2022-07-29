using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketCenter.Migrations
{
    public partial class initital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TicketCenter");

            migrationBuilder.CreateTable(
                name: "Application",
                schema: "TicketCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(77)", maxLength: 77, nullable: false),
                    ApplicationDescription = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                schema: "TicketCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionName = table.Column<string>(type: "nvarchar(77)", maxLength: 77, nullable: false),
                    SectionDescription = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "TicketCenter",
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                schema: "TicketCenter",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket_TicketId", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_Section_SectionId",
                        column: x => x.SectionId,
                        principalSchema: "TicketCenter",
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "TicketCenter",
                        principalTable: "Application",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TicketInteractions",
                schema: "TicketCenter",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketInteractions", x => new { x.TicketId, x.CreatedOnUtc });
                    table.ForeignKey(
                        name: "FK_TicketInteraction_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalSchema: "TicketCenter",
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Section_ApplicationId",
                schema: "TicketCenter",
                table: "Section",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ApplicationId",
                schema: "TicketCenter",
                table: "Tickets",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SectionId",
                schema: "TicketCenter",
                table: "Tickets",
                column: "SectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketInteractions",
                schema: "TicketCenter");

            migrationBuilder.DropTable(
                name: "Tickets",
                schema: "TicketCenter");

            migrationBuilder.DropTable(
                name: "Section",
                schema: "TicketCenter");

            migrationBuilder.DropTable(
                name: "Application",
                schema: "TicketCenter");
        }
    }
}

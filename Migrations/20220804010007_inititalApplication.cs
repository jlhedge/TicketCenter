using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketCenter.Migrations
{
    public partial class inititalApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ApplicationAdmin");

            migrationBuilder.EnsureSchema(
                name: "TicketCenterAdmin");

            migrationBuilder.EnsureSchema(
                name: "TicketCenter");

            migrationBuilder.CreateTable(
                name: "Applications",
                schema: "ApplicationAdmin",
                columns: table => new
                {
                    AppId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(77)", maxLength: 77, nullable: false),
                    ApplicationDescription = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application_Id", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                schema: "ApplicationAdmin",
                columns: table => new
                {
                    PageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(77)", maxLength: 77, nullable: false),
                    PageDescription = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages_PageId", x => x.PageId);
                    table.ForeignKey(
                        name: "FK_Pages_Applications_ApplicationId",
                        column: x => x.AppId,
                        principalSchema: "ApplicationAdmin",
                        principalTable: "Applications",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                schema: "ApplicationAdmin",
                columns: table => new
                {
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionName = table.Column<string>(type: "nvarchar(77)", maxLength: 77, nullable: false),
                    SectionDescription = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections_SectionId", x => x.SectionId);
                    table.ForeignKey(
                        name: "FK_Sections_Pages_PageId",
                        column: x => x.PageId,
                        principalSchema: "ApplicationAdmin",
                        principalTable: "Pages",
                        principalColumn: "PageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSections",
                schema: "ApplicationAdmin",
                columns: table => new
                {
                    SubsectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubsectionName = table.Column<string>(type: "nvarchar(77)", maxLength: 77, nullable: false),
                    SubsectionDescription = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsections_SubsectionId", x => x.SubsectionId);
                    table.ForeignKey(
                        name: "FK_Subsections_Sections_SectionId",
                        column: x => x.SectionId,
                        principalSchema: "ApplicationAdmin",
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                schema: "TicketCenterAdmin",
                columns: table => new
                {
                    RequestTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestType_Id", x => x.RequestTypeId);
                    table.ForeignKey(
                        name: "FK_RequestTypes_Subsections_SubsectionId",
                        column: x => x.SubSectionId,
                        principalSchema: "ApplicationAdmin",
                        principalTable: "SubSections",
                        principalColumn: "SubsectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatuseTypes",
                schema: "TicketCenterAdmin",
                columns: table => new
                {
                    StatusTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_StatusTypeId", x => x.StatusTypeId);
                    table.ForeignKey(
                        name: "FK_Statuses_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalSchema: "TicketCenterAdmin",
                        principalTable: "RequestTypes",
                        principalColumn: "RequestTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                schema: "TicketCenter",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket_Id", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusTypeId,
                        principalSchema: "TicketCenterAdmin",
                        principalTable: "StatuseTypes",
                        principalColumn: "StatusTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketInteractions",
                schema: "TicketCenter",
                columns: table => new
                {
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdatedByLogon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketInteractions_TicketId_CreatedOnUtc", x => new { x.TicketId, x.CreatedOnUtc });
                    table.ForeignKey(
                        name: "FK_TicketInteractions_Status_StatusId",
                        column: x => x.StatusTypeId,
                        principalSchema: "TicketCenterAdmin",
                        principalTable: "StatuseTypes",
                        principalColumn: "StatusTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketInteractions_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalSchema: "TicketCenter",
                        principalTable: "Tickets",
                        principalColumn: "TicketId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_AppId",
                schema: "ApplicationAdmin",
                table: "Pages",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTypes_SubSectionId",
                schema: "TicketCenterAdmin",
                table: "RequestTypes",
                column: "SubSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_PageId",
                schema: "ApplicationAdmin",
                table: "Sections",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_StatuseTypes_RequestTypeId",
                schema: "TicketCenterAdmin",
                table: "StatuseTypes",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSections_SectionId",
                schema: "ApplicationAdmin",
                table: "SubSections",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketInteractions_StatusTypeId",
                schema: "TicketCenter",
                table: "TicketInteractions",
                column: "StatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusTypeId",
                schema: "TicketCenter",
                table: "Tickets",
                column: "StatusTypeId");
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
                name: "StatuseTypes",
                schema: "TicketCenterAdmin");

            migrationBuilder.DropTable(
                name: "RequestTypes",
                schema: "TicketCenterAdmin");

            migrationBuilder.DropTable(
                name: "SubSections",
                schema: "ApplicationAdmin");

            migrationBuilder.DropTable(
                name: "Sections",
                schema: "ApplicationAdmin");

            migrationBuilder.DropTable(
                name: "Pages",
                schema: "ApplicationAdmin");

            migrationBuilder.DropTable(
                name: "Applications",
                schema: "ApplicationAdmin");
        }
    }
}

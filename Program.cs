using Microsoft.EntityFrameworkCore;
using TicketCenter.Data;
using TicketCenter.Interfaces.ApplicationAdmin;
using TicketCenter.Interfaces.TicketCenter;
using TicketCenter.Interfaces.TicketCenterAdmin; 
using TicketCenter.Services.ApplicationAdmin;
using TicketCenter.Services.TicketCenter;
using TicketCenter.Services.TicketCenterAdmin;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TicketCenter")));
builder.Services.AddScoped<IApplicationService,ApplicationService>();
builder.Services.AddScoped<IPageService,PageService>();
builder.Services.AddScoped<ISectionService,SectionService>();
builder.Services.AddScoped<ISubsectionService,SubSectionService>();
builder.Services.AddScoped<ITicketInteractionService,TicketInteractionService>();
builder.Services.AddScoped<ITicketService,TicketService>();
builder.Services.AddScoped<IRequestTypeService,RequestTypeService>();
builder.Services.AddScoped<IStatusTypeService,StatusTypeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using SPRINT3NET.Application.Services;
using SPRINT3NET.Data.AppData;
using SPRINT3NET.Data.Repositories;
using SPRINT3NET.Domain.Interfaces;
using SPRINT3NET.Domain.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationContext>(options => {
    options.UseOracle(builder.Configuration["ConnectionStrings:Oracle"]);
});


builder.Services.AddTransient<ISitesRepository, SitesRepository>();
builder.Services.AddTransient<ISitesApplicationService, SitesApplicationService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {

    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

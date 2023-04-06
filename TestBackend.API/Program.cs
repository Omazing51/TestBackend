using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.APP.Application.HotelStatusses;
using TestBackend.APP.Application.Services;
using TestBackend.CONTEXT.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMediatR(typeof(GetService.Handler).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TestBackendContext>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("DC"));
});

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

using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TestBackend.APP.Application.HotelStatusses;
using TestBackend.APP.Application.Services;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMediatR(typeof(GetService.Handler).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => {
    x.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});
builder.Services.AddDbContext<TestBackendContext>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("DC"));
});
var buil =  builder.Services.AddIdentityCore<User>();
var identityBuilder = new IdentityBuilder(buil.UserType, buil.Services);
identityBuilder.AddEntityFrameworkStores<TestBackendContext>();
identityBuilder.AddSignInManager<SignInManager<User>>();
builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;
});
builder.Services.TryAddSingleton<ISystemClock, SystemClock>();

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

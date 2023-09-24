using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Data;
using MitsAdvisor.Web.Services;

using Serilog;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
  .MinimumLevel.Verbose()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");

builder.Services
  .AddDbContext<MitsadvisorContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddScoped<RestaurantService>();

try
{
  var app = builder.Build(); // possible exceptions

  if (app.Environment.IsDevelopment())
  {
    app.UseSwagger();
    app.UseSwaggerUI();
  }

  app.UseHttpsRedirection();

  app.UseAuthorization();

  app.MapControllers();

  await app.CreateDbIfNotExists();

  app.Run(); // possible exceptions
}
catch (Exception e)
{
  logger.Fatal(e, "Application start-up failed");
}
finally
{
  Log.CloseAndFlush();
}

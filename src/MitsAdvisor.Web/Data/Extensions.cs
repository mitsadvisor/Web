namespace MitsAdvisor.Web.Data;

public static class Extensions
{
  public static async Task CreateDbIfNotExists(this IHost host)
  {
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<MitsadvisorContext>();
    await dbContext.Database.EnsureCreatedAsync();
    await DbInitializer.Initialize(dbContext);
  }
}

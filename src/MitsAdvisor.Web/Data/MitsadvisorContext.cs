namespace MitsAdvisor.MitsAdvisor.Web.Data;

using global::MitsAdvisor.MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

public class MitsadvisorContext(IConfiguration configuration)
  : DbContext
{
  public DbSet<Restaurant> Restaurants => Set<Restaurant>();

  public DbSet<Menu> Menus => Set<Menu>();

  public DbSet<MenuItem> MenuItems => Set<MenuItem>();

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
    }
  }
}

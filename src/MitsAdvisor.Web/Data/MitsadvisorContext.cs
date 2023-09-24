namespace MitsAdvisor.Web.Data;

using Microsoft.EntityFrameworkCore;
using MitsAdvisor.Web.Models;

public class MitsadvisorContext : DbContext
{
  public MitsadvisorContext(DbContextOptions<MitsadvisorContext> options)
    : base(options)
  {
  }

  public DbSet<Restaurant> Restaurants => Set<Restaurant>();

  public DbSet<Menu> Menus => Set<Menu>();

  public DbSet<MenuItem> MenuItems => Set<MenuItem>();

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Database=Test;Username=dimtsap;Password=password;");
    }
  }
}

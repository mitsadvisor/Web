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

  public DbSet<MenuItem> MenuItems => Set<MenuItem>();

  public DbSet<Chain> Chains => Set<Chain>();

  public DbSet<CuisineType> CuisineTypes => Set<CuisineType>();

  public DbSet<RestaurantCuisineType> RestaurantCuisineTypes => Set<RestaurantCuisineType>();

  public DbSet<UserCuisineType> UserCuisineTypes => Set<UserCuisineType>();

  public DbSet<UserRestaurantToTry> UserRestaurantsToTry => Set<UserRestaurantToTry>();

  public DbSet<UserRestaurantVisited> UserRestaurantsVisited => Set<UserRestaurantVisited>();

  public DbSet<Post> posts => Set<Post>();

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Database=Test;Username=dimtsap;Password=password;");
    }
  }
}

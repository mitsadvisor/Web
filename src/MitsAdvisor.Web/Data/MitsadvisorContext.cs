namespace MitsAdvisor.Web.Data;

using System.Diagnostics.Metrics;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Joins;
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

  public DbSet<Post> Posts => Set<Post>();

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Database=Test;Username=dimtsap;Password=password;");
    }
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    Chain.OnModelCreating(modelBuilder);
    CuisineType.OnModelCreating(modelBuilder);
    MenuItem.OnModelCreating(modelBuilder);
    Post.OnModelCreating(modelBuilder);
    Rating.OnModelCreating(modelBuilder);
    Restaurant.OnModelCreating(modelBuilder);
    RestaurantCuisineType.OnModelCreating(modelBuilder);
    User.OnModelCreating(modelBuilder);
    UserCuisineType.OnModelCreating(modelBuilder);
    UserRestaurantToTry.OnModelCreating(modelBuilder);
    UserRestaurantVisited.OnModelCreating(modelBuilder);
  }
}

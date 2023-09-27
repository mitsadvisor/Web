namespace MitsAdvisor.Web.Models;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

using MitsAdvisor.Web.Joins;
using MitsAdvisor.Web.Models.Interfaces;

public class Restaurant : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public decimal UserRating { get; set; }

  public decimal MitsadvisorRating { get; set; }

  public string Neighborhood { get; set; } = string.Empty;

  public Chain Chain { get; set; }

  public long ChainId { get; set; }

  public ICollection<Post> Posts { get; } = new List<Post>(0);

  public ICollection<Rating> Ratings { get; } = new List<Rating>(0);

  public ICollection<MenuItem> MenuItems { get; } = new List<MenuItem>(0);

  public ICollection<RestaurantCuisineType> RestaurantCuisines { get; } = new List<RestaurantCuisineType>(0);

  public ICollection<UserRestaurantToTry> UserRestaurantsToTry { get; } = new List<UserRestaurantToTry>(0);

  public ICollection<UserRestaurantVisited> UserRestaurantsVisited { get; } = new List<UserRestaurantVisited>(0);

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Restaurant>(r =>
    {
      r.HasKey(x => x.Id);
      r.HasOne(x => x.Chain)
      .WithMany(c => c.Restaurants)
      .HasForeignKey(x => x.ChainId);

    });
  }
}

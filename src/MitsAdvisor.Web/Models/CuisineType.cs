namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Joins;
using MitsAdvisor.Web.Models.Interfaces;

public class CuisineType : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public ICollection<User> Users { get; } = new List<User>(0);

  public ICollection<RestaurantCuisineType> RestaurantCuisines { get; } = new List<RestaurantCuisineType>(0);

  public ICollection<UserCuisineType> UserCuisines { get; } = new List<UserCuisineType>(0);

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Chain>(c =>
    {
      c.HasKey(x => x.Id);
    });
  }
}

namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models;

public class RestaurantCuisineType
{
  public Restaurant Restaurant { get; set; }
  public long RestaurantId { get; set; }

  public CuisineType CuisineType { get; set; }
  public long CuisineId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<RestaurantCuisineType>().HasKey(rc => new { rc.RestaurantId, rc.CuisineId });

    modelBuilder.Entity<RestaurantCuisineType>()
      .HasOne<Restaurant>()
      .WithMany(r => r.RestaurantCuisines)
      .HasForeignKey(rc => rc.RestaurantId);

    modelBuilder.Entity<RestaurantCuisineType>()
      .HasOne<CuisineType>()
      .WithMany(r => r.RestaurantCuisines)
      .HasForeignKey(rc => rc.CuisineId);
  }
}

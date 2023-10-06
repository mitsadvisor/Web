namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models;

public class RestaurantCuisineType
{
  public Restaurant Restaurant { get; set; }

  public CuisineType CuisineType { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<RestaurantCuisineType>()
      .HasOne(e => e.Restaurant)
      .WithMany()
      .HasForeignKey("RestaurantId");

    modelBuilder.Entity<RestaurantCuisineType>()
      .HasOne(e => e.CuisineType)
      .WithMany()
      .HasForeignKey("CuisineId");

    modelBuilder.Entity<RestaurantCuisineType>().HasKey("RestaurantId", "CuisineId");
  }
}

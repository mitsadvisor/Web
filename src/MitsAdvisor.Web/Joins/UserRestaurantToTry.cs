namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models;

public class UserRestaurantToTry
{
  public User User { get; set; }

  public Restaurant Restaurant { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UserRestaurantToTry>(ur =>
    {
      ur.HasOne(e => e.User)
      .WithMany()
      .HasForeignKey("UserId");

      ur.HasOne(e => e.Restaurant)
      .WithMany()
      .HasForeignKey("RestaurantId");

      ur.HasKey("UserId", "RestaurantId");
    });
  }
}

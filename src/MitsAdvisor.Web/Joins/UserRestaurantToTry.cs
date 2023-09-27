namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models;

public class UserRestaurantToTry
{
  public User user { get; set; }
  public Guid UserId { get; set; }

  public Restaurant Restaurant { get; set; }
  public long RestaurantId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UserRestaurantToTry>(ur =>
    {
      ur.HasKey(x => new { x.UserId, x.RestaurantId });

      ur.HasOne<User>()
      .WithMany(u => u.UserRestaurantsToTry)
      .HasForeignKey(ur => ur.UserId);

      ur.HasOne<Restaurant>()
      .WithMany(r => r.UserRestaurantsToTry)
      .HasForeignKey(ur => ur.RestaurantId);
    });
  }
}

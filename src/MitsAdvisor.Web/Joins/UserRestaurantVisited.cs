namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

public class UserRestaurantVisited
{
  public Guid UserId { get; set; }

  public long RestaurantId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

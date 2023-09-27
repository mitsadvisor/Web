namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

public class UserRestaurantToTry
{
  public Guid UserId { get; set; }

  public long RestaurantId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

public class RestaurantCuisineType
{
  public long RestaurantId { get; set; }

  public long CuisineId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

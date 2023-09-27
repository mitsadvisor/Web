namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

public class UserCuisineType
{
  public Guid UserId { get; set; }

  public long CuisineId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

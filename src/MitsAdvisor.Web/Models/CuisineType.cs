namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class CuisineType : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public ICollection<User> Users { get; } = new List<User>(0);

  public ICollection<Restaurant> Restaurants { get; } = new List<Restaurant>(0);

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

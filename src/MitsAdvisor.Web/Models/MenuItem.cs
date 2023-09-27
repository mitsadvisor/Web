namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class MenuItem : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public long RestaurantId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

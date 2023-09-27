namespace MitsAdvisor.Web.Models;

using System.Diagnostics.Eventing.Reader;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class Post : IEntity<long>
{
  public long Id { get; set; }

  public string Title { get; set; } = string.Empty;

  public string Body { get; set; } = string.Empty;

  public Guid UserId { get; set; }

  public DateTime Created { get; set; }

  public long RestaurantId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

namespace MitsAdvisor.Web.Models;

using System.Diagnostics.Eventing.Reader;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class Post : IEntity<long>
{
  public long Id { get; set; }

  public string Title { get; set; } = string.Empty;

  public string Body { get; set; } = string.Empty;

  public User User { get; set; }

  public Guid UserId { get; set; }

  public DateTime Created { get; set; }

  public Restaurant Restaurant { get; set; }

  public long RestaurantId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Post>(p =>
    {
      p.HasKey(x => x.Id);

      p.HasOne(x => x.Restaurant)
      .WithMany(r => r.Posts)
      .HasForeignKey(x => x.RestaurantId);

      p.HasOne(x => x.User)
      .WithMany(u => u.Posts)
      .HasForeignKey(x => x.UserId);
    });
  }
}

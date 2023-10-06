namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class Rating : IEntity<long>
{
  public long Id { get; set; }

  public bool IsFromFoodieUser { get; set; } = false;

  public Restaurant Restaurant { get; set; }

  public User User { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Rating>(r =>
    {
      r.HasKey(x => x.Id);

      r.HasOne(x => x.User)
      .WithMany()
      .IsRequired(true);

      r.HasOne(x => x.Restaurant)
      .WithMany()
      .IsRequired(true);
    });
  }
}

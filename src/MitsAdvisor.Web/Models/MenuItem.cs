namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class MenuItem : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public Restaurant Restaurant { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<MenuItem>(i =>
    {
      i.HasKey(x => x.Id);

      i.HasOne<Restaurant>()
      .WithMany()
      .IsRequired(true);
    });
  }
}

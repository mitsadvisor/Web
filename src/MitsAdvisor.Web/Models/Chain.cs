namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models.Interfaces;

public class Chain : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Chain>(c => c.HasKey(x => x.Id));
  }
}

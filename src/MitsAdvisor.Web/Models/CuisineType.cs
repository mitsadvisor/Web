namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Joins;
using MitsAdvisor.Web.Models.Interfaces;

public class CuisineType : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Chain>(c => c.HasKey(x => x.Id));
  }
}

namespace MitsAdvisor.Web.Models;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

using MitsAdvisor.Web.Joins;
using MitsAdvisor.Web.Models.Interfaces;

public class Restaurant : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public decimal UserRating { get; set; }

  public decimal MitsadvisorRating { get; set; }

  public string Neighborhood { get; set; } = string.Empty;

  public Chain? Chain { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Restaurant>(r =>
    {
      r.HasKey(x => x.Id);
      r.HasOne(x => x.Chain)
      .WithMany()
      .IsRequired(false);
    });
  }
}

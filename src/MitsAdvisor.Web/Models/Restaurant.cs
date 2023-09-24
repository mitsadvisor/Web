namespace MitsAdvisor.Web.Models;

using System.ComponentModel.DataAnnotations;

using Microsoft.Extensions.Diagnostics.HealthChecks;

using MitsAdvisor.Web.Models.Interfaces;

public class Restaurant : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public decimal UserRating { get; set; }

  public decimal MitsadvisorRating { get; set; }

  public string Neighborhood { get; set; }

  public long? ChainId { get; set; }

}

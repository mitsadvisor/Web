namespace MitsAdvisor.Web.Models;

using MitsAdvisor.Web.Models.Interfaces;

public class Rating : IEntity<long>
{
  public long Id { get; set; }

  public bool IsFromFoodieUser { get; set; } = false;

  public long RestarantId { get; set; }

  public Guid UserId { get; set; }
}

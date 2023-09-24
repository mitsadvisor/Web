namespace MitsAdvisor.Web.Models;

public class UserRestaurantVisited
{
  public Guid UserId { get; set; }

  public long RestaurantId { get; set; }
}

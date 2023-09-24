namespace MitsAdvisor.Web.Models;

public class CuisineType : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; }
}

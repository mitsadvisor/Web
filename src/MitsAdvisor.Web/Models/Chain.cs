namespace MitsAdvisor.Web.Models;

using MitsAdvisor.Web.Models.Interfaces;

public class Chain : IEntity<long>
{
  public long Id { get; set; }

  public string Name { get; set; }

  public string Description { get; set; }
}

namespace MitsAdvisor.Web.Models;

using MitsAdvisor.Web.Models.Interfaces;

public class User : IEntity<Guid>
{
  public Guid Id { get; set; }

  public string Username { get; set; } = string.Empty;

  public string FirstName { get; set; } = string.Empty;

  public string LastName { get; set; } = string.Empty;

  public string Email { get; set; } = string.Empty;

  public string PhoneNumber { get; set; } = string.Empty;

  public string PhotoUrl { get; set; } = string.Empty;
}

namespace MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

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

  public ICollection<Rating> Ratings { get; } = new List<Rating>(0);

  public ICollection<CuisineType> FavouriteCuisines { get; } = new List<CuisineType>(0);

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {

  }
}

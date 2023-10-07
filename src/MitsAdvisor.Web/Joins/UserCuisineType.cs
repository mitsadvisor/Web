namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models;

public class UserCuisineType
{
  public User User { get; set; }

  public CuisineType CuisineType { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UserCuisineType>(uc =>
    {
      uc.HasOne(e => e.User)
      .WithMany()
      .HasForeignKey("UserId");

      uc.HasOne(e => e.CuisineType)
      .WithMany()
      .HasForeignKey("CuisineId");

      uc.HasKey("UserId", "CuisineId");
    });
  }
}

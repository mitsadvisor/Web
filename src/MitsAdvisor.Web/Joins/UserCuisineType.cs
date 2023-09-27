namespace MitsAdvisor.Web.Joins;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Models;

public class UserCuisineType
{
  public UserCuisineType User { get; set; }
  public Guid UserId { get; set; }

  public CuisineType CuisineType { get; set; }
  public long CuisineId { get; set; }

  public static void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UserCuisineType>(uc =>
    {
      uc.HasKey(x => new { x.UserId, x.CuisineId });

      uc.HasOne<User>()
      .WithMany(u => u.UserCuisineTypes)
      .HasForeignKey(x => x.CuisineId);

      uc.HasOne<CuisineType>()
      .WithMany(c => c.UserCuisines)
      .HasForeignKey(x => x.CuisineId);
    });
  }
}

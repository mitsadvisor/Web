namespace MitsAdvisor.Web.Models.Interfaces;

using Microsoft.EntityFrameworkCore;

public interface IEntity
{
}

public interface IEntity<TKey> : IEntity
  where TKey : IComparable, IComparable<TKey>, IEquatable<TKey>
{
  TKey Id { get; set;  }

  static void OnModelCreating(ModelBuilder modelBuilder)
  {
  }
}

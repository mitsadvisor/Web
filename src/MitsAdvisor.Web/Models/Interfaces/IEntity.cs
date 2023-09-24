namespace MitsAdvisor.Web.Models.Interfaces;

public interface IEntity
{
}

public interface IEntity<TKey> : IEntity
  where TKey : IComparable, IComparable<TKey>, IEquatable<TKey>
{
  TKey Id { get; set;  }
}

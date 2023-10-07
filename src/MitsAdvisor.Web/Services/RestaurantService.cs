namespace MitsAdvisor.Web.Services;

using Microsoft.EntityFrameworkCore;

using MitsAdvisor.Web.Data;
using MitsAdvisor.Web.Models;

public class SearchCriteria
{

}

public class RestaurantService(MitsadvisorContext dbContext)
{
  public IEnumerable<Restaurant> GetAll(SearchCriteria criteria, CancellationToken cancellationToken) => dbContext.Restaurants.ToList();

  public Restaurant? GetById(int id, CancellationToken cancellationToken)
    => dbContext.Restaurants
      .SingleOrDefault(r => r.Id == id);

  public Restaurant Create(Restaurant newRestaurant)
  {
    dbContext.Restaurants.Add(newRestaurant);
    dbContext.SaveChanges();

    return newRestaurant;
  }

  public void DeleteById(int id)
  {
    var restaurantToDelete = dbContext.Restaurants.Find(id);

    if (restaurantToDelete is null)
    {
      return;
    }

    dbContext.Restaurants.Remove(restaurantToDelete);
    dbContext.SaveChanges();
  }
}

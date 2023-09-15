namespace MitsAdvisor.MitsAdvisor.Web.Services;

using global::MitsAdvisor.MitsAdvisor.Web.Data;
using global::MitsAdvisor.MitsAdvisor.Web.Models;

using Microsoft.EntityFrameworkCore;

public class RestaurantService(MitsadvisorContext dbContext)
{
  public IEnumerable<Restaurant> GetAll() => dbContext.Restaurants.AsNoTracking().ToList();

  public Restaurant? GetById(int id)
    => dbContext.Restaurants
      .Include(r => r.Menus)
      .AsNoTracking()
      .SingleOrDefault(r => r.Id == id);

  public Restaurant Create(Restaurant newRestaurant)
  {
    dbContext.Restaurants.Add(newRestaurant);
    dbContext.SaveChanges();

    return newRestaurant;
  }

  public void AddMenu(int restaurantId, int menuId)
  {
    var restaurantToUpdate = dbContext.Restaurants.Find(restaurantId);
    var menuToAdd = dbContext.Menus.Find(menuId);

    if (restaurantToUpdate is null || menuToAdd is null)
    {
      throw new InvalidOperationException("Pizza or topping does not exist");
    }

    restaurantToUpdate.Menus ??= new List<Menu>();

    restaurantToUpdate.Menus.Add(menuToAdd);

    dbContext.SaveChanges();
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

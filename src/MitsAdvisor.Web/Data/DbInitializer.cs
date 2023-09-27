namespace MitsAdvisor.Web.Data;

using MitsAdvisor.Web.Models;

public static class DbInitializer
{
  public static async Task Initialize(MitsadvisorContext dbContext)
  {
    if (dbContext.Restaurants.Any())
    {
      return;
    }

    var elaikonRestaurant = new Restaurant() { Name = "Ελαϊκόν" };

    var kyrAristosRestaurant = new Restaurant() { Name = "Κυρ Αρίστος" };

    var restaurants = new List<Restaurant>() { elaikonRestaurant, kyrAristosRestaurant };

    dbContext.Restaurants.AddRange(restaurants);
    await dbContext.SaveChangesAsync();
  }
}

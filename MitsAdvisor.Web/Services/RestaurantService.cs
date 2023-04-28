using Microsoft.EntityFrameworkCore;
using MitsAdvisor.Web.Data;
using MitsAdvisor.Web.Models;

namespace MitsAdvisor.Web.Services
{
	public class RestaurantService
	{
		private readonly MitsadvisorContext _dbContext;
        public RestaurantService(MitsadvisorContext dbContext)
        {
			_dbContext = dbContext;
        }

		public IEnumerable<Restaurant> GetAll() => _dbContext.Restaurants.AsNoTracking().ToList();

		public Restaurant? GetById(int id)
		{
			return _dbContext.Restaurants
				.Include(r => r.Menus)
				.AsNoTracking()
				.SingleOrDefault(r=>r.Id==id);
		}
		
		public Restaurant Create(Restaurant newRestaurant)
		{
			_dbContext.Restaurants.Add(newRestaurant);
			_dbContext.SaveChanges();

			return newRestaurant;
		}

		public void AddMenu(int restaurantId, int menuId)
		{
			var restaurantToUpdate = _dbContext.Restaurants.Find(restaurantId);
			var menuToAdd = _dbContext.Menus.Find(menuId);

			if (restaurantToUpdate is null || menuToAdd is null) 
				throw new InvalidOperationException("Pizza or topping does not exist");

			restaurantToUpdate.Menus ??= new List<Menu>();

			restaurantToUpdate.Menus.Add(menuToAdd);

			_dbContext.SaveChanges();
		}

		public void DeleteById(int id)
		{
			var restaurantToDelete = _dbContext.Restaurants.Find(id);

			if (restaurantToDelete is not null)
			{
				_dbContext.Restaurants.Remove(restaurantToDelete);
				_dbContext.SaveChanges();
			}
		}

	}
}

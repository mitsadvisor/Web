using MitsAdvisor.Web.Models;

namespace MitsAdvisor.Web.Services
{
	public class RestaurantService
	{
		static List<Restaurant> Restaurants { get; }
		static int nextId = 3;
		static RestaurantService()
		{
			Restaurants = new List<Restaurant>()
			{
				new Restaurant{Id=1, Name="Elaikon"},
				new Restaurant{Id=2, Name=" Kyr Aristos" }
			};
		}

		public static List<Restaurant> GetAll() => Restaurants;

		public static Restaurant? Get(int id) => Restaurants.FirstOrDefault(r => r.Id == id);
		
		public static void Add(Restaurant restaurant)
		{
			restaurant.Id = nextId++;
			Restaurants.Add(restaurant);
		}

		public static void Delete(int id)
		{
			var restaurant = Get(id);
			if (restaurant != null)
				Restaurants.Remove(restaurant);
		}

		public static void Update(Restaurant restaurant)
		{
			var index = Restaurants.FindIndex(r=>r.Id == restaurant.Id);
			if (index == -1) return;
			Restaurants[index] = restaurant;
		}

	}
}

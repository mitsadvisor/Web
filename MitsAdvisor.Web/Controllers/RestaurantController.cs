using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MitsAdvisor.Web.Models;
using MitsAdvisor.Web.Services;

namespace MitsAdvisor.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class RestaurantController : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<Restaurant>> GetAll() =>
			RestaurantService.GetAll();

		[HttpGet("{id}")]
		public ActionResult<Restaurant> Get(int id)
		{
			var restaurant = RestaurantService.Get(id);

			if (restaurant == null) return NotFound();

			return restaurant;
		}

		[HttpPost]
		public IActionResult Create(Restaurant newRestaurant)
		{
			RestaurantService.Add(newRestaurant);
			return CreatedAtAction(nameof(Get), new { id = newRestaurant.Id }, newRestaurant);
		}

		[HttpPut("id")]
		public IActionResult Update(int id, Restaurant restaurant)
		{
			if (id != restaurant.Id) return BadRequest();

			var existingRestaurant = RestaurantService.Get(id);
			if (existingRestaurant is null) return NotFound();
			RestaurantService.Update(restaurant);

			return NoContent();
		}

		[HttpDelete("id")]
		public IActionResult Delete(int id)
		{
			var restaurant = RestaurantService.Get(id);

			if (restaurant is null) return NotFound();

			RestaurantService.Delete(id);

			return NoContent();
		}

	}
}	

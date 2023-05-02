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
		RestaurantService _service;
        public RestaurantController(RestaurantService restaurantService)
        {
            _service = restaurantService;
        }

		[HttpGet]
		public ActionResult<List<Restaurant>> GetAll() =>
			_service.GetAll().ToList();

		[HttpGet("{id}")]
		public ActionResult<Restaurant> Get(int id)
		{
			var restaurant = _service.GetById(id);

			if (restaurant == null) return NotFound();

			return restaurant;
		}

		[HttpPost]
		public IActionResult Create(Restaurant newRestaurant)
		{
			_service.Create(newRestaurant);
			return CreatedAtAction(nameof(Get), new { id = newRestaurant.Id }, newRestaurant);
		}

		//[HttpPut("id")]
		//public IActionResult Update(int id, Restaurant restaurant)
		//{
		//	if (id != restaurant.Id) return BadRequest();

		//	var existingRestaurant = _service.GetById(id);
		//	if (existingRestaurant is null) return NotFound();
		//	_service..Update(restaurant);

		//	return NoContent();
		//}

		[HttpDelete("id")]
		public IActionResult Delete(int id)
		{
			var restaurant = _service.GetById(id);

			if (restaurant is null) return NotFound();

			_service.DeleteById(id);

			return NoContent();
		}

	}
}	

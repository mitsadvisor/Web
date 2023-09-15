namespace MitsAdvisor.Web.Controllers;

using Microsoft.AspNetCore.Mvc;

using MitsAdvisor.Web.Models;
using MitsAdvisor.Web.Services;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController(RestaurantService restaurantService)
  : ControllerBase
{
  [HttpGet]
  public ActionResult<List<Restaurant>> GetAll() =>
    restaurantService.GetAll().ToList();

  [HttpGet("{id}")]
  public ActionResult<Restaurant> Get(int id)
  {
    var restaurant = restaurantService.GetById(id);

    return restaurant == null
      ? NotFound()
      : restaurant;
  }

  [HttpPost]
  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesDefaultResponseType]
  public IActionResult Create(Restaurant newRestaurant)
  {
    restaurantService.Create(newRestaurant);
    return CreatedAtAction(nameof(Get), new { id = newRestaurant.Id }, newRestaurant);
  }

  [HttpDelete("id")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  [ProducesDefaultResponseType]
  public IActionResult Delete(int id)
  {
    var restaurant = restaurantService.GetById(id);

    if (restaurant is null)
    {
      return NotFound();
    }

    restaurantService.DeleteById(id);

    return NoContent();
  }
}

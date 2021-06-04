using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRBL;
using RRModels;

namespace RRREST.Controllers
{
    [Route("api/Restaurants")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantBL _restaurantBL;
        public RestaurantController(IRestaurantBL restaurantBL)
        {
            _restaurantBL = restaurantBL;
        }

        // GET: api/Restaurant
        [HttpGet]
        public async Task<IActionResult> GetAllRestaurantsAsync()
        {
            return Ok(await _restaurantBL.GetAllRestaurantsAsync());
        }

        // GET: api/Restaurant/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRestaurantByIdAsync(int id)
        {
            return Ok(await _restaurantBL.GetRestaurantByIdAsync(id));
        }

        // POST: api/Restaurant
        [HttpPost]
        public async Task<IActionResult> AddNewRestaurantAsync([FromBody] Restaurant newRestaurant)
        {
            return Created("api/Restaurant", await _restaurantBL.AddRestaurantAsync(newRestaurant));
        }

        // PUT: api/Restaurant/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRestaurantAsync(int id, [FromBody] Restaurant updatedRestaurant)
        {
             await _restaurantBL.UpdateRestaurantAsync(updatedRestaurant);
            return NoContent();
        }

        // DELETE: api/Restaurant/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantAsync(int id)
        {
            await _restaurantBL.DeleteRestaurantAsync(await _restaurantBL.GetRestaurantByIdAsync(id));
            return NoContent();
        }
    }
}

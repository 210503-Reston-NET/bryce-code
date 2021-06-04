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
    [Route("api/Restaurants/{restaurantId}/Reviews")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewBL _reviewBL;
        private readonly IRestaurantBL _restaurantBL;

        public ReviewController(IReviewBL reviewBL, IRestaurantBL restaurantBL)
        {
            _reviewBL = reviewBL;
            _restaurantBL = restaurantBL;
        }

        // GET: api/Review
        [HttpGet]
        public async Task<IActionResult> GetAllReviewsAsync(int restaurantId)
        {
            return Ok(await _reviewBL.GetReviewsAsync(await _restaurantBL.GetRestaurantByIdAsync(restaurantId)));
        }

        // POST: api/Review
        [HttpPost]
        public async Task<IActionResult> AddReviewAsync(int restaurantId, [FromBody] Review newReview)
        {
            return Created($"/api/Restaurant/{restaurantId}/Reviews", await _reviewBL.AddReviewAsync(await _restaurantBL.GetRestaurantByIdAsync(restaurantId), new Review(newReview.Rating, newReview.Description)));
        }
    }
}

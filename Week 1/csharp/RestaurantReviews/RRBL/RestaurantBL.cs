using System.Collections.Generic;
using RRModels;
using RRDL;
namespace RRBL
{
    /// <summary>
    /// Business Logic class for the restaurant model
    /// </summary>
    public class RestaurantBL : IRestaurantBL
    {
        private IRepository _repo;
        public RestaurantBL(IRepository repo) {
            _repo = repo;
        }
        public List<Restaurant> GetAllRestaurants() {
            // Note that this method is not dependent on any inputs/parameters, I can directly call the DL Method in charge of getting all restaurants
            return _repo.GetAllRestaurants();
        }
    }
}
using System.Collections.Generic;
using RRModels;
using RRDL;
using System;
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

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            // TODO: Call a repo method that adds a restaurant
            if(_repo.GetRestaurant(restaurant) != null) {
                throw new Exception("Restaurant already exists :<");
            }
            return _repo.AddRestaurant(restaurant);
        }

        public List<Restaurant> GetAllRestaurants() {
            // Note that this method is not dependent on any inputs/parameters, I can directly call the DL Method in charge of getting all restaurants
            return _repo.GetAllRestaurants();
        }
    }
}
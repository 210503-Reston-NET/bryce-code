using System.Collections.Generic;
using RRModels;
namespace RRBL
{
    public interface IRestaurantBL
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant AddRestaurant(Restaurant restaurant);
        Restaurant GetRestaurant(Restaurant restaurant);
        Restaurant GetRestaurantById(int id);
        Restaurant DeleteRestaurant(Restaurant restaurant);
        Restaurant EditRestaurant(Restaurant restaurant);
    }
}
using System;
using RRModels;
using System.Collections.Generic;
using RRBL;
namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        public RestaurantMenu(IRestaurantBL restaurantBL) {
            _restaurantBL = restaurantBL;
        }
        public void Start() {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Menu!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View Restaurants");
                Console.WriteLine("[1] Go Back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        ViewRestaurants();
                        break;
                    case "1":
                        repeat = false;
                        break;
                    default:
                        //invalid input
                        Console.WriteLine("Please input a valid option");
                        break;
                }
            } while (repeat);
        }
private void ViewRestaurants()
        {
            //TODO: Remove the hardcoded restaurant and refer to a stored restaurant that exists
            List<Restaurant> restaurants = _restaurantBL.GetAllRestaurants();
            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine(restaurant.ToString());
            }
        }
    }
}
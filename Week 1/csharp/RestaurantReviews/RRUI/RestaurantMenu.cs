using System;
using RRModels;
using System.Collections.Generic;
using RRBL;
namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        private IValidationService _validate;
        public RestaurantMenu(IRestaurantBL restaurantBL, IValidationService validate) {
            _restaurantBL = restaurantBL;
            _validate = validate;
        }
        public void Start() {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Menu!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View Restaurants");
                Console.WriteLine("[1] Create a Restaurants");
                Console.WriteLine("[2] Go Back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        ViewRestaurants();
                        break;

                    case "1":
                        AddARestaurant();
                        break;

                    case "2":
                        repeat = false;
                        break;

                    default:
                        //invalid input
                        Console.WriteLine("Please input a valid option");
                        break;
                }
            } while (repeat);
        }

        private void AddARestaurant() {
            Console.WriteLine("Enter the details of the restaurnt you want to add");
            string name = _validate.ValidateString("Enter the restaurant name: ");
            string city = _validate.ValidateString("Enter the city where the restaurant is located");
            string state = _validate.ValidateString("Enter the state where the restaurant is located at");

            Restaurant newRestaurant = new Restaurant(name, city, state);

            try {
            Restaurant createdRestaurant =  _restaurantBL.AddRestaurant(newRestaurant);
            Console.WriteLine("New Restaurant Created!");
            Console.WriteLine(createdRestaurant.ToString());
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

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
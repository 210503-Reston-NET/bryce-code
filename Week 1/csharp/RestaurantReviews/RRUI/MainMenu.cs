using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void Start() {
            bool repeat = true;

            do {
            Console.WriteLine("Welcome to my Restaurant Reviews Application!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[0] View a restaurant");
            Console.WriteLine("[1] Exit");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                // Add a restaurant
                ViewRestaurant();
                    break;

                case "1":
                // exit
                    Console.WriteLine("\nGoodbye cruel world.");
                    repeat = false;
                    break;
                default:
                // invalid input
                Console.WriteLine("\nPlease iput a valid option");
                break;
            }
            } while (repeat);
            
        }

        private void ViewRestaurant() {
            // TODO: Tomorrow
            Restaurant goodTaste = new Restaurant("Good Taste", "Baguio City", "Benguet");
            goodTaste.Reviews = new List<Reviews> 
            {
                new Reviews {
                Rating = 5,
                Description = "A M A Z I N G"
                },
                new Reviews {
                    Rating = 5,
                    Description = "Good food for cheap."
                }
            };
            Console.WriteLine(goodTaste.ToString());

            foreach (Reviews review in goodTaste.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}
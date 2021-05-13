using System;
namespace RRUI
{
    public class ReviewMenu : IMenu
    {
        public void Start() {
            // Add a review
            Console.WriteLine("Welcome to the reviews menu! What would you like to do?");
            Console.WriteLine("[0] Add a Review");
            Console.WriteLine("[1] Go back");
        }
    }
}
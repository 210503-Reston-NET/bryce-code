using System;
using RRModels;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Restarant goodTaste = new Restarant("Good Taste", "Baguio City", "Benguet");
            goodTaste.Review = new Review 
            {
                rating = 5,
                Description = "A M A Z I N G"
            };
            Console.WriteLine(goodTaste.ToString());
        }
    }
}

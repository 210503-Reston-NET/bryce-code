using  RRModels;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using RRDL;
using System.Linq;
namespace RRTests
{
    //When unit testing DBs, note that you need to install the Microsoft.EntityFrameworkCore.Sqlite package
    //Sqlite has features that allows you to create an inmemory rdb. 

    /// <summary>
    /// This is going to be my test class for the data access methods in my repo
    /// </summary>
    public class RepoTest
    {
        private readonly DbContextOptions<RestaurantDBContext> options;
        //Xunit creates new instances of test classes, you need to make sure that you seed your db for each class
        public RepoTest()
        {
            options = new DbContextOptionsBuilder<RestaurantDBContext>().UseSqlite("Filename=Test.db").Options;
            Seed();
        }
        //Test Read Ops
        //When testing methods that do not state of the data in the db only one context instance is needed
        //What methods does not affect db state: Read
        [Fact]
        public void GetAllRestaurantsShouldReturnAllRestaurants()
        {
            //putting in a test context/ connection to our test db
            using (var context = new RestaurantDBContext(options))
            {
                //Arrange
                IRepository _repo = new RepoDB(context);

                //Act
                var restaurants = _repo.GetAllRestaurantsAsync();

                //Assert
                Assert.Equal(2, restaurants.Count);
            }
        }
        //When testing operations that change the state of the db (i.e manipulate the data inside the db) 
        //make sure to check if the change has persisted even when accessing the db using a different context/connection
        //This means that you create another instance of your context when testing to check that the method has 
        //definitely affected the db.
        //What operations affect the state of the db? Create, Update, Delete
        [Fact]
        public void AddRestaurantShouldAddRestaurant()
        {
            using (var context = new RestaurantDBContext(options))
            {
                IRepository _repo = new RepoDB(context);
                //Act with a test context
                _repo.AddRestaurantAsync
                (
                    new Restaurant("Whataburger", "Dallas", "TX")
                );
            }
            //use a diff context to check if changes persist to db
            using (var assertContext = new RestaurantDBContext(options))
            {
                //Assert with a different context
                var result = assertContext.Restaurants.FirstOrDefault(restaurant => restaurant.Id == 3);
                Assert.NotNull(result);
                Assert.Equal("Dallas", result.City);
            }
        }
        private void Seed()
        {
            //this is an exmaple of a using block
            using (var context = new RestaurantDBContext(options))
            {
                //This makes sure that the state of the db gets recreated everytime to maintain modularity of tests
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Restaurants.AddRange
                (
                    new Restaurant
                    {
                        Id = 1,
                        Name = "Good Taste",
                        City = "Baguio City",
                        State = "Benguet",
                        Reviews = new List<Review>
                        {
                            new Review
                            {
                                Id = 1,
                                Rating = 5,
                                Description = "This was good"
                            },
                            new Review
                            {
                                Id = 2,
                                Rating = 5,
                                Description = "Pretty cool"
                            }
                        }
                    },
                    new Restaurant
                    {
                        Id = 2,
                        Name = "Maru Sushi",
                        City = "Kalamazoo",
                        State = "Michigan",
                        Reviews = new List<Review>
                        {
                            new Review
                            {
                                Id = 3,
                                Rating = 5,
                                Description = "This was good sushi"
                            },
                            new Review
                            {
                                Id = 4,
                                Rating = 5,
                                Description = "Pretty cool sushi"
                            }
                        }
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
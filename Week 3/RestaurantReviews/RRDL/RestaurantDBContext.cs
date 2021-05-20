using Microsoft.EntityFrameworkCore;
using RRModels;

namespace RRDL
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext(DbContextOptions options) : base(options) {

        }

        protected RestaurantDBContext() {

        }

        public DbSet<Restaurant> Restaurants {get; set;}
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Restaurant>().Property(restaurant => restaurant.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Review>().Property(review => review.Id).ValueGeneratedOnAdd();
        }
    }
}
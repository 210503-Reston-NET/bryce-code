using Microsoft.AspNetCore.Mvc;
using Moq;
using RRBL;
using RRModels;
using RRWebUI.Controllers;
using RRWebUI.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RRTests
{
    public class RestaurantControllerTest
    {
        [Fact]
        public void RestaurantControllerIndexShouldReturnList()
        {
            var mockBL = new Mock<IRestaurantBL>();
            mockBL.Setup(x => x.GetAllRestaurantsAsync()).Returns(
                new List<Restaurant>()
                {
                new Restaurant("Whataburger", "Dallas", "Texas"),
                new Restaurant("In n Out", "Hayward", "California")
                }
                );

            var controller = new RestaurantController(mockBL.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<RestaurantVM>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }


        public RestaurantControllerTest()
        {

        }
    }
}

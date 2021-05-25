using System;
using Moq;
using Xunit;
using RRDL;
using RRBL;
using RRModels;
using System.Collections.Generic;


namespace RRTests
{
    public class ReviewBLTest
    {
        [Fact]
        public void GetReviewsShouldReturnAverage()
        {
            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(x => x.GetReviews(It.IsAny<Restaurant>())).Returns
                (
                new List<Review>()
                {
                    new Review(5, "Really good description"),
                    new Review(5, "Okay, Amazing")
                }
                );
            var reviewBL = new ReviewBL(mockRepo.Object);

            var result = reviewBL.GetReviews(new Restaurant());

            Assert.Equal(5, result.Item2);
        }

        public ReviewBLTest()
        {
        }
    }
}

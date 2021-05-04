using System;
/// <summary>
/// Namespace for the models/custom data structures involved in Restaurant Reviews
/// </summary>
namespace RRModels
{
    /// <summary>
    ///  Data structures used to define a restaurant
    /// </summary>
    public class Restaurant
    {
        public Restaurant(string name, string city, string state) {
            this.Name = name;
            this.City = city;
            this.State = state;
        }
        public Restaurant() 
        {

        }
        /// <summary>
        /// This describes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; }
        /// <summary>
        /// This describes the city location of your restaurant
        /// </summary>
        /// <value></value>
        public string City { get; }
        /// <summary>
        /// This describe the state location of your restaurant
        /// </summary>
        /// <value></value>
        public string State { get; }
        /// <summary>
        /// This contains the review of a particular restaurant
        /// </summary>
        /// <value></value>
        public Review Review { get; set;}
        public override string ToString()
        {
            return $"Name: {Name} \n Location: {City}, {State} \n Review: {Review.ToString()}";
        }
    }
}

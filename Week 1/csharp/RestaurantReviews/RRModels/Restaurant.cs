using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        /// <summary>
        /// This describes the city location of your restaurant
        /// </summary>
        /// <value></value>
        public string City { get; set;}
        /// <summary>
        /// This describe the state location of your restaurant
        /// </summary>
        /// <value></value>
        public string State { get; set;}
        /// <summary>
        /// This contains the review of a particular restaurant
        /// </summary>
        /// <value></value>
        public List<Reviews> Reviews { get; set;}
        public override string ToString()
        {
            return $"Name: {Name} \nLocation: {City}, {State}";
        }
    }
}

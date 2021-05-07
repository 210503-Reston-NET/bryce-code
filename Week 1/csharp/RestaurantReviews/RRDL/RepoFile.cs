using System.Collections.Generic;
using RRModels;
using System.IO;
using System.Text.Json;
using System;
using System.Linq;
namespace RRDL
{
    /// <summary>
    /// Repo implemenation but I store it in a file
    /// </summary>
    public class RepoFile : IRepository 
    {
        // The file path is relative to where you run the dotnet run command, Since it is run in the RRUI project the filepath is relative from RRUI to the file location
        private const string filePath = "../RRDL/Restaurants.json";
        private string jsonString;

    public Restaurant AddRestaurant(Restaurant restaurant) {
        List<Restaurant> restaurantsFromFile = GetAllRestaurants();
        restaurantsFromFile.Add(restaurant);
        jsonString = JsonSerializer.Serialize(restaurantsFromFile);
        File.WriteAllText(filePath, jsonString);
        return restaurant;
        }
    public List<Restaurant> GetAllRestaurants() {
        try {
            jsonString = File.ReadAllText(filePath);
        } catch (Exception ex) {
            // Logging to the console
            Console.WriteLine(ex.Message);
            return new List<Restaurant>();
        }
        return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        }

    public Restaurant GetRestaurant(Restaurant restaurant) {
        return GetAllRestaurants().FirstOrDefault(resto => resto.Equals(restaurant));
        }    
    }
}
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemmoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemmoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="Scott's Pizza",Location="MaryLand",Cuisine= CuisineType.Italian},
                new Restaurant{Id=2,Name="Cinnamon Club",Location="London",Cuisine= CuisineType.Mexican},
                new Restaurant{Id=3,Name="La Costa",Location="California",Cuisine= CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

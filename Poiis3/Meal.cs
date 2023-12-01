using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3
{
    public class Meal
    {
        public string Name { get; set; }
        
        public List<Food> Foods { get; set; }

        public int Calories;
       
        public Meal(string name)
        {
            Name = name;
            Foods = new List<Food>();
            
        }
        public void AddFood(Food food)
        {
            Foods.Add(food);
        }

        public int CalculateCaloriesOfMeal()
        {
            return Calories= Foods.Sum(f => f.Calories);
        }
    }
}

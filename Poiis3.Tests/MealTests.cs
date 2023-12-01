using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poiis3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3.Tests
{
    [TestClass()]
    public class MealTests
    {
       

        [TestMethod()]
        public void AddFoodTest()
        {
            var шпинат = new Food("Шпинат",23);
            var творожный_сыр = new Food("ТВорожный сыр", 342);
            var черный_хлеб = new Food("Черный хлеб", 259);

            var meal1 = new Meal("ПП бутерброд");

            meal1.AddFood(шпинат);
            meal1.AddFood(творожный_сыр);
            meal1.AddFood(черный_хлеб);

            Assert.IsTrue(meal1.Foods.Contains(шпинат));
            Assert.IsTrue(meal1.Foods.Contains(творожный_сыр));
            Assert.IsTrue(meal1.Foods.Contains(черный_хлеб));

        }

        [TestMethod()]
        public void CalculateCaloriesOfMealTest()
        {
            var шпинат = new Food("Шпинат", 23);
            var творожный_сыр = new Food("ТВорожный сыр", 342);
            var черный_хлеб = new Food("Черный хлеб", 259);

            var meal1 = new Meal("ПП бутерброд");

            var expected = 624;

            var actual = meal1.CalculateCaloriesOfMeal();
        }
    }
}
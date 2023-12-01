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
    public class FitnessTrackerTests
    {
        [TestMethod()]
        public void AddWorkoutTest()
        {
            var fitnessTracker = new FitnessTracker();
            var workout1 = new Workout("кардио");
            var workout2 = new Workout("силовая");

            fitnessTracker.AddWorkout(workout1);
            fitnessTracker.AddWorkout(workout2);

            Assert.IsTrue(fitnessTracker.Workouts.Contains(workout1));
            Assert.IsTrue(fitnessTracker.Workouts.Contains(workout2));

        }

        [TestMethod()]
        public void AddMealTest()
        {
            var fitnessTracker = new FitnessTracker();

            var meal1 = new Meal("ПП бутерброд");

            fitnessTracker.AddMeal(meal1);

            Assert.IsTrue(fitnessTracker.Meals.Contains(meal1));
        }

        [TestMethod()]
        public void ReminderOfWorkoutTest()
        {
            var fitnessTracker = new FitnessTracker();

            var беговая_дорожка = new Equipment("беговая дорожка");
            var гантели = new Equipment("гантели");
            var скакалка = new Equipment("скакалка");

            var excercise1 = new Exercise("бег", беговая_дорожка, 30);
            var excercise3 = new Exercise("прыжки со скаакалкой",скакалка, 10);
            var excercise2 = new Exercise("тяга", гантели, 20);

            var workout1 = new Workout("кардио");
            var workout2 = new Workout("силовая");

            workout1.AddExercise(excercise1);
            workout1.AddExercise(excercise3);
            workout2.AddExercise(excercise2);

            fitnessTracker.AddWorkout(workout1);
            fitnessTracker.AddWorkout(workout2);

            string[] expected ={

                "Workout: кардио, Duration: 40 minutes",
                "Workout: силовая, Duration: 20 minutes"
            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
           fitnessTracker.ReminderOfWorkout();

            //assert
            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DisplayMealsTest()
        {
            var fitnessTracker = new FitnessTracker();

            var шпинат = new Food("Шпинат", 23);
            var творожный_сыр = new Food("ТВорожный сыр", 342);
            var черный_хлеб = new Food("Черный хлеб", 259);
            var гранула = new Food("гранула", 250);
            var йогурт = new Food("йогурт", 300);

            var meal1 = new Meal("ПП бутерброд");
            var meal2=new Meal("гранула с йогуртом");

            meal1.AddFood(шпинат);
            meal1.AddFood(творожный_сыр);
            meal1.AddFood(черный_хлеб);

            meal1.CalculateCaloriesOfMeal();

            meal2.AddFood(гранула);
            meal2.AddFood(йогурт);

            meal2.CalculateCaloriesOfMeal();
            fitnessTracker.AddMeal(meal1);
            fitnessTracker.AddMeal(meal2);

            string[] expected ={

                "Meal: ПП бутерброд, Calories: 624",
                "Meal: гранула с йогуртом, Calories: 550"

            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            fitnessTracker.DisplayMeals();

            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);



        }

        [TestMethod()]
        public void DisplayUserProgressTest()
        {
            var fitnessTracker=new FitnessTracker();
            var client1 = new Client("Kate", 18, 55, 170, "women", 50);
            var client2 = new Client("Egor", 19, 85, 180, "men", 75);

            client1.ChooseWeightNow(50);
            client2.ChooseWeightNow(76);

            client1.WaterIntake.AddWater(2000);
            client2.WaterIntake.AddWater(1000);
            

            string[] expected =
            {
                "Клиент: Kate Начальный вес: 55 Цель: 50",
                "Вы достигли желаемого результата!",
                "Клиент: Egor Начальный вес: 85 Цель: 75",
                "Вы должны работать лучше!"
            };

            var sw = new StringWriter();
            Console.SetOut(sw);

            fitnessTracker.DisplayUserProgress(client1 );
            fitnessTracker.DisplayUserProgress(client2 );

            string[] actual = sw.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
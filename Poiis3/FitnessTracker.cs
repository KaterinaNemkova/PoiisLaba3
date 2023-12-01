using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3
{
    public class FitnessTracker
    {
     

        public List<Meal> Meals { get; set; }
        public List<Client> Users { get; set; }

        public List<Workout> Workouts { get; set; }

        public FitnessTracker()
        {
            Meals=new List<Meal>();
            Users=new List<Client>();
            Workouts=new List<Workout>();
        }

        public void AddWorkout(Workout workout)
        {
            Workouts.Add(workout);  
        }
        public void AddMeal(Meal meal)
        {
            Meals.Add(meal);  
        }

        public void ReminderOfWorkout()
        {
            foreach (var workout in Workouts)
            {
                Console.WriteLine($"Workout: {workout.Name}, Duration: {workout.Duration} minutes");
            }
        }

        public void DisplayMeals()
        {
            foreach (var meal in Meals)
            {
                Console.WriteLine($"Meal: {meal.Name}, Calories: {meal.Calories}");
            }
        }

       
        public void DisplayUserProgress(Client user)
        {
            int waterIntakeGoal = 2000; // Цель по количеству выпитой воды в миллилитрах
            int waterIntake = user.WaterIntake.Amount;

            Console.WriteLine($"Клиент: {user.Name} Начальный вес: {user.StartWeight} Цель: {user.Goal}");

            if (waterIntake >= waterIntakeGoal && user.NewWeight == user.Goal)
            {
                Console.WriteLine("Вы достигли желаемого результата!");
            }
            else if (waterIntake >= waterIntakeGoal && user.CalculateBMI(user.StartWeight, user.Height) > user.CalculateBMI(user.NewWeight, user.Height))
            {
                Console.WriteLine("Хорошая работа, продолжайте");
            }
            
            else
            {
                Console.WriteLine("Вы должны работать лучше!");
            }

            
            
        }

    }
}

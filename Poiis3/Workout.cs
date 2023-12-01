using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3
{
    public class Workout
    {
        public string Name { get; set; }
       
        public int Duration { get; set; }//в минутах

       
        public List<Exercise> Exercises { get; set; }
        
        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
            Duration += exercise.Duration;
        }

        public Workout(string name)
        {
            Exercises=new List<Exercise>();
            Name = name;
        }
    }
}

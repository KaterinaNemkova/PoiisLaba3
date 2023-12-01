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
    public class WorkoutTests
    {
        [TestMethod()]
        public void AddExerciseTest()
        {
            var беговая_дорожка = new Equipment("беговая дорожка");
            var excercise1 = new Exercise("бег", беговая_дорожка, 30);
            var workout1 = new Workout("кардио");

            workout1.AddExercise(excercise1);

            Assert.IsTrue(workout1.Exercises.Contains(excercise1));

        }

        
    }
}
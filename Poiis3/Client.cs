using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3
{
    public class Client:Person
    {
       public int Age { get; set; }

        public string Sex {  get; set; }
        public int StartWeight { get; set; }

        public int NewWeight { get; set; }

        public int Height {  get; set; }

        public int Goal {  get; set; }

        public WaterIntake WaterIntake =new WaterIntake();


        public Client(string name,int age, int weight, int height,string sex,int goal):base(name)
        {
            Age = age;
            StartWeight = weight;   
            Height = height;
            Sex=sex;
            Goal=goal;
            
        }

        public double CalculateBMI(double weight,double height)
        {
            
          return (int)(weight / Math.Pow(height/100, 2));
        }


        public void ChooseWeightNow( int newWeight)
        {
            NewWeight = newWeight;
        }

    }
}

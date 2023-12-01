using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Poiis3
{
    public class Exercise
    {
        public string Name { get; set; }
        public Equipment Equipment { get; set; }

        public int Duration {  get; set; }

        public Exercise(string name, Equipment equipment, int duration)
        {
            Name = name;
            Equipment = equipment;
            Duration = duration;

        }

        
    }
}

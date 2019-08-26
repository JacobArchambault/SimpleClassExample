using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        // Put back the default constructor, which will set all data members to default values.
        public Motorcycle() { }
        public Motorcycle(int intensity)
            : this(intensity, "") { }
        public Motorcycle(string name)
            : this(0, name) { }
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

        public void SetDriverName(string name)
        {
            this.name = name;
        }

        public void PopAWheely()
        {
            Console.WriteLine("Yeee Haaaaaaaeeeeeeeeeeewwww!");
        }


    }
}

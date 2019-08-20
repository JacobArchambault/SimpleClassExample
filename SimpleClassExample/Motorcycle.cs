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


        public void PopAWheely()
        {
            Console.WriteLine("Yeee Haaaaaaaeeeeeeeeeeewwww!");
        }

        // Put back the default constructor, which will set all data members to default values.
        public Motorcycle() { }

        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}

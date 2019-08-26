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

        public Motorcycle(int intensity = 0, string name = "")
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
            this.driverName = name;
        }

        public void PopAWheely()
        {
            Console.WriteLine("Yeee Haaaaaaaeeeeeeeeeeewwww!");
        }


    }
}

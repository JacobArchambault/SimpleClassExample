using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Car constructors
            Car myCar = new Car();
            Car chuck = new Car();
            Car mary = new Car("Mary");
            Car daisy = new Car("Daisy", 75);
            Motorcycle mc = new Motorcycle();
            Motorcycle c = new Motorcycle(5);

            // Change myCar fields.
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // Set c's driver name.
            c.SetDriverName("Tiny");

            // Speed up myCar a few times and print out the new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            // Print states for Chuck, Mary, and Daisy.
            chuck.PrintState();
            mary.PrintState();
            daisy.PrintState();

            // mc and c pop a wheely.
            mc.PopAWheely();
            c.PopAWheely();
            Console.WriteLine("The rider of c is {0}", c.name);

            Console.ReadLine();
        }
    }
}

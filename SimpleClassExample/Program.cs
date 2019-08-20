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

            // Change myCar fields.
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

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

            Console.ReadLine();
        }
    }
}

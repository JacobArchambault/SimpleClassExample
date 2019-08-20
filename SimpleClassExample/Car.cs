﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car.
        public string petName;
        public int currSpeed;

        // A custom default constructor.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // The functionality of the Car.
        // Using the expression-bodied member syntax introduced in C# 6
        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta) => currSpeed += delta;
    }
}

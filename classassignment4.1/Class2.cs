﻿using System;
using System.Collections.Generic;
using System.Text;

namespace classassignment4._2
{
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace classassignment4._5
{
    class Car
    {
        string color;
        int maxSpeed;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}

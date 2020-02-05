using System;
using System.Collections.Generic;
using System.Text;

namespace classassignment4._10
{
    class Car
    {
        public string model;

        // Create a class constructor with a parameter
        public Car(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}

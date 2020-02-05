using System;
using System.Collections.Generic;
using System.Text;

namespace classassignment4._13
{
    class Car
    {
        public string model = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}

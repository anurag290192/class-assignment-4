﻿using System;
using System.Collections.Generic;
using System.Text;

namespace classassignment4._23
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(20);
        }
    }
}

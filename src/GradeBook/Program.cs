﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            
            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            Console.WriteLine(result);

            System.Console.WriteLine($"How many numbers are in grades? {grades.Count}");
            var average = 0.0;
            average = result / grades.Count;
            System.Console.WriteLine($"The average grade is {average:N1}.");

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}

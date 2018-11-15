using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace Video
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            Console.WriteLine("Enter the radius of the circle:");
            radius = double.Parse(Console.ReadLine());

            if(radius >=0)
            {
                area = Math.PI * radius * radius;
                Console.WriteLine($"The areaaaaa of the circle is: {area:0.00}");
            }
            else
                Console.WriteLine($"{radius} is not a valid radius");

            Console.ReadKey();
        }
    }
}
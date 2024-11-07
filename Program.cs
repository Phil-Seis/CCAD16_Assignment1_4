using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;

namespace CCAD16_Assignment1_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instantiating the 2 points from Point class
            Point p1 = new Point(5.3, 6.8);
            Point p2 = new Point(5.3, 3.5);

            //print statements for points
            Console.WriteLine($"Coordinates for Point 1: ({p1.X} , {p1.Y})");
            Console.WriteLine($"Coordinates for Point 2: ({p2.X} , {p2.Y})");

            if (p1.X == p2.X)
            {
                Console.WriteLine("Point 1 and Point 2 are on the same axis");

                if (p1.X < p2.X)
                {
                    Console.WriteLine("Point 2 is to the right of Point 1");
                }
            }
            else
            {
                Console.WriteLine("Point 2 is to the left of Point 1");
            }            
        }
    }


        //Create a class named “Point” and 2 data members: X and Y coordinate.
    public class Point
    {
        //constructor, same name as class
        public Point(double xCoord, double yCoord)
        {
            X = xCoord;
            Y = yCoord;
        }

        //Data members for X and Y coordinates
        public double X;
        public double Y;
    }
}
using System;

namespace PracticeProblem
{   /*  As a fan of geometry, I want to
        model a line based on a point
        consisting of (x, y) co-ordinates using the Cartesian system, So that I can calculate its length.
        - A Length as 2 Points (x1, y1) and (x2, y2) 
        - Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2 - y1) ^ 2)
    */
    class LineComparisonProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 Value:- ");             // Take x1 input value
            int x1 = Convert.ToInt32(Console.ReadLine());       //Convert x1 value integer 
            Console.WriteLine("Enter x2 Value:- ");              // Take x2 input value
            int x2 = Convert.ToInt32(Console.ReadLine());         //Convert x2 value integer 
            Console.WriteLine("Enter y1 Value:- ");                // Take y1 input value
            int y1 = Convert.ToInt32(Console.ReadLine());            //Convert y1 value integer
            Console.WriteLine("Enter y2 Value:- ");                 // Take y2 input value
            int y2 = Convert.ToInt32(Console.ReadLine());       //Convert y2 value integer
            double LengthofLine = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);  // Calculate LenghthofLine using Math.Sqrt formula
            Console.WriteLine("Length of (x, y) co-ordinates -  " + LengthofLine);  // Display Length
        }
    }
}

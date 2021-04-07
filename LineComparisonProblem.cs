using System;

namespace PracticeProblem
{   /*  As a fan of geometry, I want to compare two lines based on the end points, So that I know 
        one line is equal, greater or less than the other line. 
        - Using Java compareTo method to compare 2 Lengths is preferable.
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
           

            Console.WriteLine("Enter j1 Value:- ");             // Take j1 input value
            int j1 = Convert.ToInt32(Console.ReadLine());       //Convert j1 value integer 
            Console.WriteLine("Enter j2 Value:- ");              // Take j2 input value
            int j2 = Convert.ToInt32(Console.ReadLine());         //Convert j2 value integer 
            Console.WriteLine("Enter k1 Value:- ");                // Take k1 input value
            int k1 = Convert.ToInt32(Console.ReadLine());            //Convert k1 value integer
            Console.WriteLine("Enter k2 Value:- ");                 // Take k2 input value
            int k2 = Convert.ToInt32(Console.ReadLine());       //Convert k2 value integer

            double LengthofLine1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);  // Calculate LenghthofLine1 using Math.Sqrt formula
            double LengthofLine2 = Math.Sqrt((j2 - j1) ^ 2 + (k2 - k1) ^ 2);  // // Calculate LenghthofLine2 using Math.Sqrt formula
            Console.WriteLine("Length of (x, y) co-ordinates -  " + LengthofLine1);  // Display Length1
            Console.WriteLine("Length of (j, k) co-ordinates -  " + LengthofLine2);  // Display Length2


            double Result = LengthofLine1.CompareTo(LengthofLine2);  //compareTo method to compare 2 Lengths is LengthofLine1 and LengthofLine2
            if (Result==0)                       // one line is equal 
            {
                Console.WriteLine("Two Lines are equal ");
            }
            else if(Result<0.0)    //less than the other line.
            {
                Console.WriteLine("Line one is Smaller thean line Two");
            }
            else
            {
                Console.WriteLine("Lines one is Greater then Line two");
            }
        }
    }
}

using System;
namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the values from the user.
            Console.WriteLine("Enter the Value of x1 of first point : ");
            float x1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of y1 of first point : ");
            float y1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of x2 of Second point : ");
            float x2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of y2 of second point : ");
            float y2 = Single.Parse(Console.ReadLine());
            //calculating Line Length
            double lineLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine($"Length of the line is {lineLength}");
        }
    }
}

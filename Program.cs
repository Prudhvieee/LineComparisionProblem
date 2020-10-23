using System;
namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double lineLength1 = 0;
            double lineLength2 = 0;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Enter the {i} point values");
                //reading the values from the user.
                Console.WriteLine("Enter the Value of x1 of first point : ");
                float x1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value of y1 of first point : ");
                float y1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value of x2 of Second point : ");
                float x2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value of y2 of second point : ");
                float y2 = Single.Parse(Console.ReadLine());
                if (i == 1)
                {
                    //calculating Line Length1
                    lineLength1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    Console.WriteLine($"Length of the line is {lineLength1}");
                }
                if (i == 2)
                {
                    //calculating Line Length2
                    lineLength2 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    Console.WriteLine($"Length of the line is {lineLength2}");
                }
            }
            //To check the equality of the lines
            if (lineLength1 > lineLength2)
            {
                Console.WriteLine("The Line1 is greater than Line2");
            }
            else if (lineLength1 == lineLength2)
            {
                Console.WriteLine("The Lines are Equal");
            }
            else
            {
                Console.WriteLine("The Line2 is Greater than Line1!");
            }
        }
    }
}

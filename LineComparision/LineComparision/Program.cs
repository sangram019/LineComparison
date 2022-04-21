using System;
namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation!");
            Console.WriteLine("Please enter First and Second coordinates :");
            double First = Convert.ToDouble(Console.ReadLine());
            double Second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Third and Fourth coordinates :");
            double Third = Convert.ToDouble(Console.ReadLine());
            double Fourth = Convert.ToDouble(Console.ReadLine());
            double finalResult = Distance(First,Second,Third,Fourth);
            Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", First, Second, Third, Fourth, finalResult);

            static double Distance(double First, double Second, double Third, double Fourth)
            {
                double temp1 = Math.Pow((Third - First), 2);
                double temp2 = Math.Pow((Fourth - Second), 2);
                double result = Math.Sqrt(temp1 + temp2);
                return result;
            }
        }
    }
}
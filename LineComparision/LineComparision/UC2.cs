using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_comparision
{
    public class comparingtwolines
    {
        public void EqualtoMethod()
        {
            Console.WriteLine("Please Enter A and B coordinates : ");
            var A = Convert.ToDouble(Console.ReadLine());
            var B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter C and D coordinates : ");
            var C = Convert.ToDouble(Console.ReadLine());
            var D = Convert.ToDouble(Console.ReadLine());
            var finalResult = Distance(A, B, C, D);
            Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", A, B, C, D, finalResult);

            static double Distance(double A, double C, double B, double D)
            {
                var temp1 = Math.Pow((C - A), 2);
                var temp2 = Math.Pow((D - B), 2);
                var result = Math.Sqrt(temp1 + temp2);
                return result;
            }
            Console.WriteLine("Please Enter p and q coordinates ");
            var p = Convert.ToDouble(Console.ReadLine());
            var q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter x2 and y2 coordinates ");
            var r = Convert.ToDouble(Console.ReadLine());
            var s = Convert.ToDouble(Console.ReadLine());
            var finalResult2 = Distance(p, r, q, s);
            Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", p, q, r, s, finalResult2);
            bool status = finalResult.Equals(finalResult2);
            if (status)

                Console.WriteLine("{0} is equal to {1}",
                                        finalResult, finalResult2);
            else
                Console.WriteLine("{0} is not equal to {1}",
                                        finalResult, finalResult2);
        }
    }
}
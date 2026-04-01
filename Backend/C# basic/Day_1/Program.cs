using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace task1_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            int length, width, area;
            Console.WriteLine("Enter Length of Rectangle: ");
            //we can use also int.Parse method here
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of Rectangle: ");
            //if you use int.Parse method here.it does not accept null value.
            width = Convert.ToInt32(Console.ReadLine());

            area = length * width;
            //i used string interpolation.it's the new formatting way to format string in C#
            Console.WriteLine($"Area of Rectangle is: {area}");
            #endregion

            Console.WriteLine("\n");

            #region Task 2
            Console.WriteLine("please enter the  positive number that you want to check even or odd:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
            #endregion

            #region Task 3
            Console.WriteLine("\n");
            double grade, sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"please enter the grade for student number:{i + 1}");
                grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
            }
            Console.WriteLine($"the sum of {sum}\n");
            #endregion
            #region task 4
            int grades, sumOfEven = default, sumOfOdd = default;
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine($"please enter the grade for student number:");
                grades = Convert.ToInt32(Console.ReadLine());
                if (grades % 2 == 0)
                {
                    sumOfEven += grades;
                }
                else
                {
                    sumOfOdd += grades;
                }
            }
            Console.WriteLine($"the total sum of even numbers are:{sumOfEven}");
            Console.WriteLine($"the total sum of odd numbers are:{sumOfOdd}");
            #endregion
            #region problem solving Fizz Buzz
            int numbers;
            Console.WriteLine("please enter a positive number:");
            numbers = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
                else { Console.WriteLine(i); }
            }
            #endregion

        }
        }
    }


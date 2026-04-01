using System.Numerics;
using System.Runtime.InteropServices;
using System.Security;

namespace Day_3_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-prime
            //for (int i = 2; i <= 100; i++)
            //{
            //    int result = IsAPrime(i);
            //    if (IsPrime(i) == true)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 2 task
            //Console.WriteLine(AddDigits(19));

            #endregion

            #region 3 task 
            //print(5);
            #endregion

            #region task 4 circulre swap
            //int a=15, b=16, c=30;
            //CirculSwap(ref a, ref b, ref c);
            //Console.WriteLine($"a:{a} b:{b} c:{c} ");
            #endregion

            #region task 5 find max and min
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max, min;
            //FindMinMax(out min, out max, numbers);

            //Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion

            #region Array Statistics 6
            //int[] arr = { 10, 20, 30, 40, -50 };
            //ArrayStatistics(arr,out int countP,out int countNagative,out double avarage,out int sum);
            //Console.WriteLine($" sum:{sum}, avarage:{avarage},number of positive values:{countP}, number of negative values:{countNagative}");
            #endregion

            #region 9_Student Grading System 
            //Console.WriteLine(Grade(90));
            #endregion

            #region 10_Traffic Light System
            //string result = TraficState(ETraficLight.Yellow);
            //Console.WriteLine(result);
            #endregion

            #region 11_FilePermission 
            //EFilePermission currentPermission = EFilePermission.None;
            //GrantPermission(ref currentPermission, EFilePermission.Execute);
            //GrantPermission(ref currentPermission, EFilePermission.Delete);
            //GrantPermission(ref currentPermission, EFilePermission.Write);
            //GrantPermission(ref currentPermission, EFilePermission.Execute);
            //GrantPermission(ref currentPermission, EFilePermission.Read);
            //RevokePermission(ref currentPermission, EFilePermission.Execute);
            //PrintAllPermission(currentPermission);
            #endregion
            #region 12 second Largest Numbr
            //int[] arr = { 1, 2, 3 ,5,6,73,7,4,45,24,5};
            //Console.WriteLine(SecondLargestNumber(arr,out int secondLargestNumber));
            #endregion

            #region 13 MERGE TWO SORTED ARRAYS
            //int[] arr = { 1, 3, 5, 7, 9 };
            //int[] arr1 = { 2, 4, 6, 8 };
            //MergeTwoArrays(arr, arr1, out int[] temp);

            //foreach (var item in temp)
            //{
            //    Console.Write($" {item}");
            //}
            //Console.WriteLine();
            #endregion

            #region 16
            int[,] arr = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            SumDiagonal(arr,out int sumOfP,out int sumOfS,out int dif);
            Console.WriteLine($"sum of primery diagonal :{sumOfP}, " +
                $"sum of secondery diagonal: {sumOfS}" +
                $",difference: {dif}"
                );
            #endregion
        }


        // i make this function not check but return the prime number or -1 if not prime
        private static int IsAPrime(int x)
        {
            if (x == 2)
            {
                return 2;
            }
            else if (x == 3)
            {
                return 3;
            }
            else
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        return -1;
                    }

                }
                return x;
            }
        }
        //and this function ckecks if a number is prime or not
        private static Boolean IsPrime(int x)
        {
            if (x == 2)
            {
                return true;
            }
            else if (x == 3)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }


        }

        //task2
        static int AddDigits(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                int div = num / 10;
                int reminder = num % 10;
                int result = Add(div, reminder);
                while (result > 10)
                {
                    div = result / 10;
                    reminder = result % 10;
                    result = Add(div, reminder);
                }
                return result;


            }
        }
        static int Add(int div, int reminder)
        {
            return div + reminder;
        }

        //task 3
        static void print(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //task 4
        static void CirculSwap(ref int a, ref int b, ref int c)
        {
            int z = a;
            a = b;
            b = c;
            c = z;
        }

        //task 5
        static void FindMinMax(out int min, out int max, int[] arr)
        {
            min = int.MaxValue; max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

        }
        //problem 6
        static void ArrayStatistics(int[] arr, out int countPositive, out int countNagative, out double avarage, out int sum)
        {
            countNagative = 0;
            countPositive = 0;
            avarage = 0;
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    countPositive++;
                if (arr[i] < 0)
                    countNagative++;
                sum += arr[i];
            }
            avarage = sum / arr.Length;

        }
        static EGrades Grade(int x)
        {
            if (x >= 95 && x <= 100)
            {
                return EGrades.APlus;
            }
            else if (x >= 90 && x < 95)
            {
                return EGrades.A;
            }
            else if (x >= 85 && x < 90)
            {
                return EGrades.BPlus;
            }
            else if (x >= 80 && x < 85)
            {
                return EGrades.B;
            }
            else if (x >= 75 && x < 80)
            {
                return EGrades.CPlus;
            }
            else if (x >= 70 && x < 75)
            {
                return EGrades.C;
            }
            else if (x >= 65 && x < 70)
            {
                return EGrades.D;
            }
            else
                return EGrades.F;
        }

        static string TraficState(ETraficLight traficLight)
        {
            switch (traficLight)
            {
                case ETraficLight.Red:
                    return "Stop(^_^)";
                case ETraficLight.Yellow:
                    return "Get Ready...!";
                case ETraficLight.Green:
                    return "Go ->...";
                default:
                    return "Error!";
            }
        }

        //11 File Permissions with Flags 
        static void GrantPermission(ref EFilePermission currentPermission, EFilePermission permission)
        {
            if (currentPermission == EFilePermission.None)
            { currentPermission = currentPermission | permission; }
            else if ((currentPermission & permission) == permission) { }
            else { currentPermission = currentPermission | permission; }
        }
        static void RevokePermission(ref EFilePermission currentPermission, EFilePermission permission)
        {
            if ((currentPermission & permission) == permission)
            {
                currentPermission = currentPermission & (~permission);//~ is for not oprator
            }

        }
        static Boolean CheckPermission(EFilePermission currentPermission, EFilePermission permission)
        {
            if ((currentPermission & permission) == permission)
            {
                return true;
            }
            return false;
        }
        static void PrintAllPermission(EFilePermission currentPermission)
        {
            Console.WriteLine(currentPermission);
        }

        //12 second largest number in array
        static int SecondLargestNumber(int[] arr, out int secondLarge)
        {
            int largestNumber = 0;
            secondLarge = 0;
            foreach (int item in arr)
            {
                if (item > largestNumber)
                {
                    secondLarge = largestNumber;
                    largestNumber = item;
                }
                else if (item > secondLarge)
                {
                    secondLarge = item;
                }
            }
            return secondLarge;
        }

        //13 merge two sorted arrays
        static int[] MergeTwoArrays(int[] arr1, int[] arr2, out int[] temp)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;

            temp = new int[n1 + n2];
            int i = 0, j = 0, k = 0;
            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                {
                    temp[k] = arr1[i];
                    k++;
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    temp[k] = arr2[j];
                    j++;
                    k++;
                }
                else
                {
                    temp[k] = arr1[i];
                    k++;
                    i++;
                    j++;
                }
            }
            while (i < n1) { temp[k] = arr1[i]; k++; i++; }
            while (j < n2) { temp[k] = arr1[i]; k++; j++; }
            return temp;
        }
        //16 matrix diagonal sum
        static void SumDiagonal(int[,] toDiArr, out int sumOfPrimeDia, out int sumOfSecondDia, out int difference)
        {
            sumOfPrimeDia = 0;
            sumOfSecondDia = 0;
            difference = 0;
            int n = toDiArr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                // Primary diagonal
                sumOfPrimeDia += toDiArr[i, i];

                // Secondary diagonal
                sumOfSecondDia += toDiArr[i, n - 1 - i];
            }

            difference = sumOfPrimeDia - sumOfSecondDia;

        }
    }
}

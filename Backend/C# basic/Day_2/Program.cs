using System;

namespace task1_day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region identity matrix
            //int number;
            //Console.WriteLine("Enter the size of the identity matrix:");
            //number = Convert.ToInt32(Console.ReadLine());
            //int[,] array = new int[number, number];
            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        if (i == j)
            //        {
            //            array[i, j] = 1;
            //        }
            //        else
            //        {
            //            array[i, j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < number; ++i)
            //{
            //    for (int j = 0; j < number; ++j)
            //    {
            //        Console.Write(array[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //#endregion

            Console.WriteLine("\n");

            //#region Employee Salaries

            //decimal[] salaries = { 1000m, 3000m, 2000m, 4000m, 5000m };

            //for (int i = 0; i < salaries.Length; ++i)
            //{
            //    Console.WriteLine(salaries[i] *= 1.1m);
            //}
            //#endregion
            //Console.WriteLine("\n");

            //#region factorial
            //int number1,factorial=1;
            //Console.WriteLine("please enter the number you want to get it's factorial");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //int counter = number1;
            //while (counter > 0)
            //{
            //    factorial *= counter;
            //    counter--;
            //}
            //Console.WriteLine(factorial);
            //#endregion
            //Console.WriteLine("\n");
            //#region identecial array
            //int[] firstArr = { 3, 4,5 }, secondArr = { 3, 4, 6 };
            //if (firstArr.Length != secondArr.Length) {
            //    Console.WriteLine("two arrays are not identecial");
            //}
            //else
            //{
            //    for (int i = 0; i < firstArr.Length; i++)
            //    {
            //        if (firstArr[i] != secondArr[i])
            //        {
            //            Console.WriteLine("not identecial");
            //            break;
            //        }
            //        Console.WriteLine("identecial");
            //    }
            //}
            //#endregion
            Console.WriteLine("\n");
            //#region Longest Distance Between Equal Elements
            //int numOfArr;
            //Console.WriteLine("enter the number of array elements");
            //numOfArr = Convert.ToInt32(Console.ReadLine());
            //int[] myarr = new int[numOfArr];
            //for (int i = 0; i < numOfArr; i++)
            //{
            //    Console.WriteLine($"please enter the element number:{i}");
            //    myarr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int[] distance = new int[numOfArr];
            //int[] valueOfTheLongestDistance = new int[numOfArr];
            //int stateDistance;

            //for (int i = 0; i < numOfArr; i++)
            //{
            //    stateDistance = 0;
            //    for (int j = 1; j < numOfArr; j++)
            //    {
            //        if (myarr[i] == myarr[j])
            //        {
            //            stateDistance = j - i;//-1
            //            if (distance[i] == 0 || distance[i] < stateDistance)
            //            {
            //                distance[i] = stateDistance;
            //                valueOfTheLongestDistance[i] = myarr[j];
            //            }
            //        }
            //    }
            //}

            //int maxDistance = 0;
            //int valueWithMaxDistance = 0;
            //for (int i = 0; i < numOfArr; i++)
            //{
            //    if (distance[i] > maxDistance)
            //    {
            //        maxDistance = distance[i];
            //        valueWithMaxDistance = valueOfTheLongestDistance[i];
            //    }
            //}
            //if (maxDistance > 0)
            //{
            //    Console.WriteLine($"the Value of the longest value is {valueWithMaxDistance}");
            //    Console.WriteLine($"the longest distance is:{maxDistance}");
            //}
            //else
            //{
            //    Console.WriteLine("No equal elements found with a distance greater than 0.");
            //}
            // #endregion
            //    #region shift array left
            //    int[] myarr = { 1, 2, 3, 4, 5 };
            //    int temp = myarr[0];
            //    for(int i = 0; i < myarr.Length - 1; i++)
            //    {
            //        myarr[i] = myarr[i + 1];
            //    }
            //    myarr[^1] = temp;
            //    foreach(var item in myarr) { 
            //        Console.Write($" {item}");
            //    }
            //    #endregion
            Console.WriteLine("\n");
            //#region Count Occurrences
            //int[] myarr = { 1, 2, 3, 4, 5 ,3,4,2,2,2};
            //int[] count=new int[myarr.Length];
            //for(int i = 0; i < myarr.Length; i++)
            //{
            //    count[i] = 0;
            //    for(int j = 0; j < myarr.Length; j++)
            //    {
            //        if(myarr[i] == myarr[j])
            //        {
            //            count[i]++;
            //        }
            //    }
            //    Console.WriteLine($"the number {myarr[i]} occurs {count[i]} times");
            //}
            //#endregion
            // #region Two Sum
            //int[] myarr = { 2, 7, 11, 15 ,8,1 };
            //int target = 9;
            //for (int i = 0; i < myarr.Length; i++)
            //{
            //    for(int j = i + 1; j < myarr.Length; j++)
            //    {
            //        if(myarr[i] + myarr[j] == target)
            //        {
            //            Console.WriteLine($"the indices are {i} and {j},"
            //                +$" where {myarr[i]} + {myarr[j]} = { target}");
            //        }
            //    }
            //}
            //#endregion
            //#region Maximum Number of Words
            //string[] sentece = new string[5];
            //string? input;
            //Console.WriteLine("please enter 5 sentece:");
            //for (int i = 0; i < 5; i++)
            //{
            //    input = Console.ReadLine();
            //    if (input != null)
            //    {
            //        sentece[i] = input!;
            //    }
            //}
            //int maxnuMberOfWords = 0;
            //int indexOfMax = -1;
            //for (int i = 0; i < sentece.Length; i++)
            //{

            //    if (sentece[i].Split(' ').Length > maxnuMberOfWords)
            //    {
            //        maxnuMberOfWords = sentece[i].Split(' ').Length;
            //        indexOfMax = i;
            //    }
            //}
            //Console.WriteLine($"index of max words: {indexOfMax} and it's number of words equal:{maxnuMberOfWords}");
            //#endregion
            #region sub string revers
            string[] name = { "hossam mohamed yehia sallam","mansor hmada montaser","Alyaa Khaled","Noor hamed nasr" };
            //should know that return type of split is array of substring if you whant to 
            string[] subString ;
            
            foreach (var item in name)
            {   

                subString = item.Split(' ');
                Array.Reverse(subString);
                foreach(var items in subString) {
                    Console.Write($" {items}");
                }
                Console.WriteLine();
               
            }
            #endregion

        }
    }
}
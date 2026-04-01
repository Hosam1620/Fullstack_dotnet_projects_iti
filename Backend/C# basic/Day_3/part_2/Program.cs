using System;

namespace Day_3part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Circle Struct 
            // we use property to retuen data of specific field not want to make an operation on this field
            //CircleStruct circle1=default;
            //circle1.Redius = 10;
            //Console.WriteLine(circle1.Redius);
            //Console.WriteLine(circle1.GetArea());
            //Console.WriteLine(circle1.GetCircumference());
            #endregion
            #region 8 bank account
            //BankAccount account= new BankAccount();
            //Console.WriteLine(account.Balance);
            //Console.WriteLine();
            //Console.WriteLine(account.Deposit(150));
            //Console.WriteLine();
            //Console.WriteLine(account.WithDrow(50));
            //Console.WriteLine(); 
            //Console.WriteLine(account.Balance);
            #endregion
            #region 14_palindrome number
            //Console.WriteLine(IsAPalindrome(123, 321));
            #endregion

            #region 15
            //int[] arr = { 1, 2, 4, 5, 6, 7 };
            //Console.WriteLine(MissingNumber(arr));
            #endregion
            #region 17
            Password password=new Password();
            if (password.SetPassword("hosam"))
            {
                Console.WriteLine("Accepted");
                Console.WriteLine(password.GetPasswordStrength());
            }
            else { 
                Console.WriteLine(password.GetPasswordStrength());
                Console.WriteLine("Rejected");
            }
            #endregion
        }
        //14
        static bool IsAPalindrome(int forwordNum, int backwordNum)
        {   //forword
            int div = forwordNum / 10;
            int reminder = forwordNum % 10;
            int result = forwordNum;
            //backword
            int div1 = backwordNum / 10;
            int reminder1 = backwordNum % 10;
            int result1 = backwordNum;

            while (reminder > 0 && reminder1 > 0)
            {
                result = div;
                div = result / 10;
                reminder = result % 10;
                //backworkd
                result1 = div1;
                div1 = result1 / 10;
                reminder1 = result1 % 10;

                if (reminder == reminder1)
                    continue;
                else
                    return false;
            }
            return true;
        }
        //15
        static int MissingNumber(int[] arr)
        {
            int sum = 0;
            int n = arr[^1];
            int sumForLength = (n * (n + 1)) / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sumForLength - sum;
        }





    }
}

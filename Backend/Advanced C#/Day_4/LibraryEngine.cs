using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    public class LibraryEngine
    {

        //first way
        //public static void ProcessBooks(List<Book> bList,/*Pointer To BookFunciton*/MyDelegates fPtr)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(fPtr(B));
        //    }
        //}


        public static void ProcessBooks(List<Book> bList,/*Pointer To BookFunciton*/Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            
            StringBuilder n=new StringBuilder("");
            
            foreach(string author in B.Authors)
            {
                
               n.Append(author);
            }
            

            return n.ToString() ;
        }

        public static string GetPrice(Book B)
        {
           return$"Price: {B.Price}";
        }
    }
}

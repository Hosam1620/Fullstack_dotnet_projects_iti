using System.Text;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bList = new List<Book>();
            bList.Add(new Book("978-3-16-148410-0", "The Great Gatsby", new string[] { "F. Scott Fitzgerald" }, new DateTime(1925, 4, 10), 10.99m));
            bList.Add(new Book("978-0-14-028333-4", "To Kill a Mockingbird", new string[] { "Harper Lee" }, new DateTime(1960, 7, 11), 7.99m));
            bList.Add(new Book("978-0-452-28423-4", "1984", new string[] { "George Orwell" }, new DateTime(1949, 6, 8), 8.99m));
            //first way
            //MyDelegates fPtr=BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(bList, fPtr);

            //second way
            //Func<Book, string> fPtr = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(bList, fPtr);

            //third way - anonymous method
            //Func<Book, string> fPtr = delegate (Book b)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    foreach (var item in b.Authors)
            //    {
            //        sb.Append(item);
            //    }
            //    return sb.ToString();
            //};
            //LibraryEngine.ProcessBooks(bList, fPtr);

            //fourth way - lambda expression. from here we can use expression body lambda expression or
            //statement body lambda expression we do not need to define any type of this delegate here 
            //cause of compiler will determine what we need to say.

            //this lambda have a body so we using carlee brace
            //Func<Book, string> fPtr = b => {
            //    StringBuilder sb = new StringBuilder();
            //    foreach (var item in b.Authors)
            //    {
            //        sb.Append(item);
            //    }
            //    return sb.ToString();
            //};
            //    LibraryEngine.ProcessBooks(bList, fPtr);

            //fifth way -else expression body lambda expression
           // LibraryEngine.ProcessBooks(bList, b => $"Title: {b.Title}");

        }
    }
}

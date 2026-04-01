namespace Library_managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            List<Member> members = new List<Member>();
            List<Loan> loans = new List<Loan>();


            Book b1 = new(1, "Java", "Hosam", "learning", 1924, 1824, 10);
            Book b2 = new(2, "C#", "Nourin", "learning", 1924, 1824, 20);
            Book b3 = new(3, "Python", "Mohamed", "learning", 1924, 1824, 30);
            Book b4 = new(4, "Algorithem", "Alyaa", "learning", 1924, 1824, 40);

            books.AddRange(new[] {b1,b2,b3,b4});
            
            Library library = new Library(books, loans, members);

            library.Save();


        }
    }
}

namespace Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question
            Product p = new Product(1, "Hossam", 5000, 220);
            ProductR pr = new ProductR(p.Name, p.Price - p.Discount);

            //Console.WriteLine(pr);

            //3
            Console.WriteLine(GetAvgAndNumberOfProduct(GetProducts()));
            #endregion

            #region second
            Person per1 = new(1, "Heba", 2007);
            PersonR perR = new(per1.Name!, DateTime.Now.Year - per1.YearOfBirth);
            Console.WriteLine(perR);
            //3
            Console.WriteLine(GetAvgAndNumberOfPeople(GetPeople()));


            #endregion


        }
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product p1 = new Product(1, "Mohamed", 12000, 400);
            Product p2 = new Product(2, "Ahmed", 10000, 400);
            Product p3 = new Product(3, "Hasan", 11000, 400);
            Product p4 = new Product(4, "Noha", 13000, 400);
            Product p5 = new Product(5, "Alyaa", 15000, 400);
            Product p6 = new Product(6, "Mostafa", 16000, 400);
            products.AddRange(new List<Product> { p1, p2, p3, p4, p5, p6 });
            return products;
        }

        public static Tuple<double, int> GetAvgAndNumberOfProduct(List<Product> products)
        {
            double sum = 0;
            foreach (Product p in products)
            {
                sum += (double)p.Price;
            }

            return new Tuple<double, int>(sum / products.Count, products.Count);
        }

        //question 2
        public static List<PersonR> GetPeople()
        {

            List<PersonR> people = new();
            Person per1 = new(1, "hossam", 2002);
            PersonR p1 = new(per1.Name!, DateTime.Now.Year - per1.YearOfBirth);
            Person per2 = new(1, "mohamed", 2005);
            PersonR p2= new(per2.Name!, DateTime.Now.Year - per2.YearOfBirth);
            Person per3 = new(1, "hebe", 2007);
            PersonR p3= new(per3.Name!, DateTime.Now.Year - per3.YearOfBirth);
            people.AddRange(new List<PersonR> { p1, p2, p3});
            return people;
        }

        public static (double,int) GetAvgAndNumberOfPeople(List<PersonR> people)
        {
            double sum= 0;
            foreach(PersonR p in people)
            {
                sum += p.Age;
            }
            return (sum/people.Count,people.Count);
        }
    }

}


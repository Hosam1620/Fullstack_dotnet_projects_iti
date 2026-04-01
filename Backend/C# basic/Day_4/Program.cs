namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Students struct
            //Student student = new Student(1, "hossam", 55);
            //Student student1 = new Student(2, "Alyaa", 95);
            //Console.WriteLine(student.IsPassed());
            //Console.WriteLine(student1.IsPassed());
            //student.Id = 20; 
            #endregion
            #region product
            //Product product = new("shoes",100,45);
            //Console.WriteLine(product.TotalPrice());
            #endregion
            #region 4 phone book
            #endregion

            #region 3,5_Bank Account
            #endregion

            #region 6_struct ShoppingCart
            ShoppingCart cart = new ShoppingCart(6);
            cart[0] = 1000;
            cart[1] = 200;
            cart[2] = 300;
            cart[3] = 400;
            cart[4] = 500;
            cart[5] = 600;
            Console.WriteLine();
            Console.WriteLine($"Total price: {cart.GetTotal()}");

            Console.WriteLine(cart.ApplyDiscount(20));
            #endregion
        }

    }
}

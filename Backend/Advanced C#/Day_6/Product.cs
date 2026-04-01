namespace Day_6
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public Product(int id, string name, decimal price, int discount)
        {
            Id = id;
            Name = name;
            Price = price;
            Discount = discount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    struct Product
    {
        public string? Name {  get; set; }
        public double Price {  get; set; }
        public int Quantity {  get; set; }
        public Product()
        {
            Price = 1;
        }
        public Product(string? name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public double TotalPrice()
        {
            return Price*Quantity; 
        }
    }
}

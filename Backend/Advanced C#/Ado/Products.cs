using System;
using System.Collections.Generic;
using System.Text;

namespace Ado
{
    public class Products
    {
        public int Id {  get; set; }
        public string? Name {  get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} ,Name: {Name} ,Price:{Price}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    struct ShoppingCart
    {
        double[] prices ;
        public int NumberOfItems {  get; set; }
        public ShoppingCart(int numOfItems){
            NumberOfItems = numOfItems;
            prices = new double[NumberOfItems];
        }
        //indexer
        public double this[int x]
        {
            get { return prices[x]; }
            set { prices[x] = value; }
        }
        public double GetTotal()
        {
            double sum=0;
            foreach (var price in prices)
            {
                sum += price;
            }
            return sum;
        }
        public string ApplyDiscount(double present)
        {
            double total = GetTotal();
            present = present / 100;
            double disValue = total * present;
            
            return $"Discount: {present}\n" +
                $"your total price after discount:{total-disValue}";
        }
    }
}

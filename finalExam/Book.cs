using System;
using System.Collections.Generic;
using System.Text;

namespace finalExam
{
    class Product
    {
        public Product(string code, string name, int price, int stock)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
        }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Stock { get; private set; }
        public void BuyProduct(int quantity)
        {
            Stock -= quantity;
        }
        public void AddProduct(int quantity)
        {
            Stock += quantity;
        }
    }
}

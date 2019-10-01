using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace finalExam
{
    class Ecommerce : IEcommerce
    {
        int a=0;
        private List<Product> ProductList;
        public Ecommerce(List<Product> ProductList)
        {
            this.ProductList = ProductList;
        }
        List<Product> BorrowList = new List<Product>();
        
        public void AddProduct()
        {

            Console.Write("Enter Product Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Price : ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Initial Stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product b = new Product(code, name, price, stock);
            ProductList.Add(b);
            Console.WriteLine("Successfully Product Added");
        }
        public void BuyProduct()
        {
            Console.Write("Enter Product Code: ");
            string borrowCode = Console.ReadLine();

            Product searchProduct = ProductList.Where(x => x.Code == borrowCode).FirstOrDefault();
            if (searchProduct != null)
            {
                Console.Write("Enter Product Stock: ");
                int borrowStock = Convert.ToInt32(Console.ReadLine());

                if (searchProduct.Stock >= borrowStock)
                {
                    searchProduct.BuyProduct(borrowStock);
                    Product c = new Product(searchProduct.Code, searchProduct.Name, searchProduct.Price, borrowStock);
                    BorrowList.Add(c);
                    a = a+(searchProduct.Price * borrowStock);
                    Console.WriteLine("Successfully Product Bought");
                }
                else
                {
                    Console.WriteLine("Sorry given quantity is not available on stock");
                }

            }
            else
            {
                Console.WriteLine("Product not Found");
            }
            
            
        }
        
        public void DisplayProduct()
        {
            foreach (var item in ProductList)
            {
                //var tab;
                // tab.AddRow(item.Code, item.Name, item.Price, item.Stock);
                
                Console.WriteLine(item.Code +"\t"+ item.Name +"\t"+ item.Price +"\t"+ item.Stock);
            }
            
        }
        
        public void DisplayBorrowProduct()
        {
            foreach (var item in BorrowList)
            {
                Console.WriteLine(item.Code + "\t" + item.Name + "\t" + item.Price + "\t" + item.Stock);
            }

        }
        
        public void TotalPrice()
        {

            Console.WriteLine("Total Price:  " + a +"Taka Only");
        }
        

    }
}

using System;
using System.Collections.Generic;

namespace finalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC E-Commerce System");

            var ProductList = new List<Product>();
            IEcommerce EcommerceModel = new Ecommerce(ProductList);

            while (true)
            {
                OptionMessage();
                Console.Write("Please Select an Option :");

                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("\n");
                    EcommerceModel.AddProduct();
                }
                else if (option == 2)
                {
                    Console.Write("\n");
                    Console.WriteLine("Code \t Name \t Price \t Stock");
                    EcommerceModel.DisplayProduct();
                }
                else if (option == 3)
                {
                    Console.Write("\n");
                    EcommerceModel.BuyProduct();
                }
                else if (option == 4)
                {
                    Console.Write("\n");
                    Console.WriteLine("Code \t Name \t Price \t Stock");
                    EcommerceModel.DisplayBorrowProduct();

                }
                else if (option == 5)
                {
                    Console.Write("\n");
                    EcommerceModel.TotalPrice();
                }
                else
                {
                    break;
                }
                Console.WriteLine("_______________________________________");

            }
            Console.WriteLine("Thank You for using ABC E-Commerce System");
            Console.WriteLine("Press ENTER to exit.");
            Console.Read();



            Console.Read();
        }
        public static void OptionMessage()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1: ADD PRODUCT TO STORE");
            Console.WriteLine("2: SHOW PRODUCT LIST OF STORE");
            Console.WriteLine("3: BUY PRODUCT");
            Console.WriteLine("4: SHOW ALL BOUGHT PRODUCT LIST");
            Console.WriteLine("5: SHOW TOTAL PRICE OF ALL BOUGHT PRODUCT");
            Console.WriteLine("6: Exit");

        }
    }
    
}

using System;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            Product.Pbrand = "Laptop";
            Console.WriteLine("-----Welcome----");

            while (true)
            {
                Console.WriteLine("Who are you? 1. Admin 2. Customer 3. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Do you want to: 1. Add Product 2. Display Products 3. Exit");
                        int adminChoice = int.Parse(Console.ReadLine());
                        switch (adminChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter Product Code:");
                                int pcode = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter Product Name:");
                                string pname = Console.ReadLine();

                                Console.WriteLine("Enter Quantity in Stock:");
                                int qty = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter Discount (%):");
                                double discount = double.Parse(Console.ReadLine());

                                Product newProduct = new Product(pcode, pname, qty, discount);
                                productService.AddProduct(newProduct);
                                break;

                            case 2:
                                productService.DisplayProducts();
                                break;

                            case 3:
                                return;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Do you want to: 1. Order Product");
                        int customerChoice = int.Parse(Console.ReadLine());
                        switch (customerChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter Product Name:");
                                string productName = Console.ReadLine();

                                Console.WriteLine("Enter Quantity:");
                                int orderQuantity = int.Parse(Console.ReadLine());

                                productService.OrderProduct(productName, orderQuantity);
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}

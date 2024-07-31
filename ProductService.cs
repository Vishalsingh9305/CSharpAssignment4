using System;
using System.Collections.Generic;

namespace Assignment4
{
    internal class ProductService
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        public Product FindProduct(string name)
        {
            return products.Find(product => product.Pname == name);
        }

        public void OrderProduct(string pname, int quantity)
        {
            Product product = FindProduct(pname);
            if (product != null)
            {
                Console.WriteLine($"Product Name: {product.Pname}, Product Quantity: {quantity}, Product Discount: {product.Pdiscount}%");
                if (quantity <= product.Pqty)
                {
                    Console.WriteLine("Order Successful");

                    double price = quantity * 500; // Assuming price per unit is 500

                    double discount = price * (product.Pdiscount / 100.0);
                    Console.WriteLine($"Price: {price}");
                    Console.WriteLine($"Discount: {discount}");
                    Console.WriteLine($"Total Price: {price - discount}");

                    product.Pqty -= quantity; // Deduct ordered quantity from stock
                }
                else
                {
                    Console.WriteLine("Insufficient stock");
                }
            }
            else
            {
                Console.WriteLine("Product not available");
            }
        }
    }
}

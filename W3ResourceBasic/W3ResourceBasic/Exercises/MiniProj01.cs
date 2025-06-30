using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    // Inventory Manager Console App
    // This application allows users to add, restock, update, and view product inventory.
    // It uses a Product class and a List<Product> to manage data.
    public static class MiniProj01
    {

        static List<Product> inventory = new List<Product>();
        class Product //Initialize properties 
        {
            public string? Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        public static void Run()
        {
            while (true)
            {
                //Inventory Management menu via switch statements 
                Console.WriteLine("\nWelcome to Cinco's Inventory Manager System.");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Restock Inventory");
                Console.WriteLine("3. Update Inventory");
                Console.WriteLine("4. View All Products");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddProduct(); break;
                    case "2": RestockInventory(); break;
                    case "3": UpdateInventory(); break;
                    case "4": UpdateProducts(); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid Choice. Please try again"); break;
                }

            }          
        }

        static void AddProduct()
        {
            Console.Write("Please enter name of new prodcut: ");
            string? name = Console.ReadLine();

            Console.Write("Please enter prive in 00.00 decimnal format");
            decimal price;

            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Enter a valid decimal");
            }

            inventory.Add(new Product { Name = name, Price = price, Quantity = 0 });
            Console.WriteLine("Product added with quantiy of 0");
            return;
        }

        static void RestockInventory()
        {
            Console.Write("Enter a prodcut to restock: ");
            string name = Console.ReadLine();

            Console.Write($"Enter quaintity of {name} you'd like to restock");
            int quantity;

            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Please enter a valid quantity");
            }

            for (int i = 0; i < 0; i++)
            {
                if (inventory[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    inventory[i].Quantity += quantity;
                    Console.WriteLine($"{quantity} units added to {name}");
                    return;
                }
            }

            Console.WriteLine("Product not found");
        }

        static void UpdateInventory()
        {
            // Allows user to set a new quantity for a specific product
            Console.Write("Enter product name to update: ");
            string name = Console.ReadLine();

            for (int i = 0; i < inventory.Count; i++)
            {
                if (!inventory[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Current quantity is {inventory[i].Quantity}");
                    Console.Write("Enter new quantity: ");
                }

                int newQuantity;
                while (!int.TryParse(Console.ReadLine(), out newQuantity))
                {
                    Console.WriteLine("Enter a valid integer");
                }

                inventory[i].Quantity = newQuantity;
                Console.WriteLine($"Inventory for {name} updated to {newQuantity}");
                return;

            }
        }

        static void UpdateProducts()
        {
            //Show list of inventory
            if (inventory.Count == 0)
            {
                Console.WriteLine("There is no inventory");
                return;
            }

            Console.WriteLine("\nCurrent Inventory: ");
            foreach (var product in inventory)
            {
                Console.WriteLine($"{product.Name} Price: {product.Price} - Amount in inventory: {product.Quantity}");
            }

        }
    }
}

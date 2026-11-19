//BYU-Pathway 
//Online Ordering Program for CSE210
//Author: Darwin J. Tovar.
//The Program main contain the next step:
//1. Entry point for the Online Ordering program. Creates sample domestic and
// international orders with multiple products and displays their labels and total costs.
//2. Builds sample orders without user interaction and prints packing labels,
// shipping labels, and total prices to the console.
//3. Create a domestic order (USA address -> $5 shipping fee) with three products.
//4. Create an international order (non-USA address -> $35 shipping fee) with two products.
//5. Display packing label, shipping label, and total cost for each order.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        
        Address address1 = new Address("1250 N University Ave", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Carlos Mendez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mechanical Keyboard", "PRD-101", 65.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "PRD-102", 25.50, 2));
        order1.AddProduct(new Product("USB-C Hub", "PRD-103", 19.99, 1));
        orders.Add(order1);

       
        Address address2 = new Address("Los Palos Grandes", "Caracas", "Miranda", "Venezuela");
        Customer customer2 = new Customer("Samuel Perez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Noise-Canceling Headphones", "PRD-201", 120.00, 1));
        order2.AddProduct(new Product("Laptop Stand", "PRD-202", 34.00, 2));
        orders.Add(order2);

        
        foreach (Order order in orders)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
    }
}
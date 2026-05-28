using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "199 4th Street, Sun Valley Subdivision, Calamba",
            "Cebu City",
            "Cebu",
            "6000",
            "Philippines"
        );

        Customer customer1 = new Customer("Argy Milan", address1);

        Product product1 = new Product(
            "Construction Gloves Set",
            "P001",
            46.64m,
            5
        );

        Product product2 = new Product(
            "Protective Helmet",
            "P002",
            80.05m,
            2
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(
            "456 Oak Avenue",
            "Los Angeles",
            "California",
            "90001",
            "USA"
        );

        Customer customer2 = new Customer("Judee Mae Febra", address2);

        Product product3 = new Product(
            "Tile Adhesive",
            "P003",
            25.75m,
            10
        );

        Product product4 = new Product(
            "Latex Paint",
            "P004",
            65.40m,
            3
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order>();

        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("ORDER DETAILS");
            Console.WriteLine();

            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }
    }
}
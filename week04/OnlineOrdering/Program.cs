using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("13101 Harold Green Road", "Austin", "Texas", "USA");
        Customer customer1 = new Customer("Elon Musk", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM100", 12.50, 2));
        order1.AddProduct(new Product("Keyboard", "KB200", 25.00, 1));
        order1.AddProduct(new Product("USB Cable", "USB300", 5.00, 3));

        Address address2 = new Address("199 4th Street, Sun Valley Subdivision, Calamba", "Cebu City", "Cebu", "Philippines");
        Customer customer2 = new Customer("Argy Milan", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS400", 18.00, 1));
        order2.AddProduct(new Product("Webcam", "WC500", 35.00, 1));
        order2.AddProduct(new Product("Notebook", "NB600", 3.50, 4));

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
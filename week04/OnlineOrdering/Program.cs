using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // ORDER 1.
        Address address1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("John Chol", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "A101", 700, 1));
        order1.AddProduct(new Product("Mouse", "B204", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // ORDER 2.
        Address address2 = new Address("45 Regent Rd", "London", "London", "UK");
        Customer customer2 = new Customer("Emmy Clark", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "C310", 50, 3));
        order2.AddProduct(new Product("Microphone", "D450", 120, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
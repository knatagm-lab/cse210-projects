using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("164 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Lukas Saenz", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "W123", 10.99m, 2);
        Product product2 = new Product("Airpods", "G456", 5.49m, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("14 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Rita Doe", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Monitor", "M789", 15.99m, 1);
        Product product4 = new Product("Keyboard", "K012", 7.99m, 2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
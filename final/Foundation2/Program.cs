using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Mouse", "P002", 19.99m, 2);
        Product product3 = new Product("Keyboard", "P003", 49.99m, 1);
        Product product4 = new Product("Monitor", "P004", 199.99m, 1);
        Product product5 = new Product("USB Cable", "P005", 5.99m, 3);

        // Create orders and add products to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Cost:");
        Console.WriteLine($"${order.CalculateTotalCost():0.00}");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
    }
}

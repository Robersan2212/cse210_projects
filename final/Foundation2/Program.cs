using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 1000.00, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.00, 2));

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "C789", 500.00, 1));
        order2.AddProduct(new Product("Charger", "D012", 20.00, 3));

        Console.WriteLine("Order 1 Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2 Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Cost: $" + order2.CalculateTotalCost());
    }
}

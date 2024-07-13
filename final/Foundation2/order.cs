using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        if (customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in products)
        {
            label.AppendLine($"Product: {product.Name}, ID: {product.ProductId}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Customer: {customer.Name}\nAddress: {customer.Address.ToString()}";
    }
}

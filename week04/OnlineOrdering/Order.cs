using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
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
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string location;

        if (_customer.LivesInUSA())
        {
            location = "Inside USA";
        }
        else
        {
            location = "Outside USA";
        }

        return $"Shipping Label:\n{_customer.GetCustName()}\n{_customer.GetAddress()}\n{location}";
    }
}
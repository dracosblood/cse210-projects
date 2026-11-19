//Darwin J. Tovar
//Orden item for Online Ordering program contain:
//1.Represents a customer order containing products and a customer,
// responsible for calculating total cost and generating packing and shipping labels.
//2. Initializes a new Order for the given customer with an empty product list.
//3. Adds a Product instance to the order's product list.
//4. Calculates the total order cost by summing all product totals plus a one-time
// shipping fee ($5 for USA customers, $35 for international customers).
//5. Returns a formatted string listing the name and product ID of each product in the order.
//6. Returns a formatted string listing the customer's name and full address.


using System;
using System.Collections.Generic;
using System.Text;

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

    public double CalculateTotalCost()
    {
        double productsTotal = 0;

        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;

        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Packing Label:");

        foreach (Product product in _products)
        {
            label.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()})");
        }

        return label.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Shipping Label:");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFullAddress());

        return label.ToString().TrimEnd();
    }
}
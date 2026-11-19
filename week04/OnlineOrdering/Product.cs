//Darwin j. Tovar
//Product item contain:
//1. Represents a product in an order with a name, ID, unit price, and quantity,
// and calculates the total cost for that item.
//2. Initializes a new Product instance with name, product ID, unit price, and quantity
//3. Returns the products name.
//4. Returns the products ID.
//5. Returns the unit price of the product.
//6. Returns the quantity ordered for this product.
//7. Calculates and returns the total cost of the product (unit price multiplied by quantity).



using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
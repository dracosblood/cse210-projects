//Darwin J. Tovar
//Vustomer item for online ordering contain:
//1. Represents a customer with a name and a mailing address,
// providing access to customer details and USA residency status.
//2. Initializes a new Customer instance with a name and an Address object.
//3. Returns the customer's name.
//4. Returns the customer's Address object.
//5. Returns true if the customer lives in the USA by delegating to the Address class.



using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
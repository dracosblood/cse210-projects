//Darwin J Tovar
//Online Ordering program (address items):
//1. Represents a physical mailing address and provides helper methods
// to check if it is in the USA and format all address fields together.
//2. Initializes a new Address instance with street, city, state/province, and country.
//3. Returns true if the address is located in the USA, or false otherwise.
//4. Returns all address fields combined into a single string with line breaks.


using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        string normalizedCountry = _country.Trim().ToUpper();
        return normalizedCountry == "USA" || normalizedCountry == "UNITED STATES" || normalizedCountry == "UNITED STATES OF AMERICA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}
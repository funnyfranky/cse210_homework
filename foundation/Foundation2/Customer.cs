using System;

namespace Foundation2;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address = new Address(streetAddress,city,stateOrProvince,country);
    }

    // Returns whether customer is in the USA
    public bool IsInUSA()
    {
        if (_address.GetCountryCode() == "USA")
        {
            return true;
        }
        return false;
    }
    public string GetMailingAddress()
    {
        return $"{_name}\n{_address.formatAddress()}";
    }

}

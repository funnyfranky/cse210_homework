using System;
using System.Globalization;

namespace Foundation2;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress.ToUpper();
        _city = city.ToUpper();
        _stateOrProvince = stateOrProvince.ToUpper();
        _country = country.ToUpper();
    }


    // Returns a formatted address string that looks like:
    /*  Street address
        city, state country */
    public string formatAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince} {_country}";
    }
    public string GetCountryCode()
    {
        return _country;
    }

}

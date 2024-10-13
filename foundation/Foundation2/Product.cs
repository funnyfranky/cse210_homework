using System;

namespace Foundation2;

public class Product
{
    private string _name = "default name";
    private int _prod_id = -1;
    private double _price = -1.0;
    private int _quantity_needed = -1;

    public Product(string name, int prod_id, double price)
    {
        _name = name;
        _prod_id = prod_id;
        _price = price;
    }
    
    public Product(string name, int prod_id, double price, int quantity_needed)
    {
        _name = name;
        _prod_id = prod_id;
        _price = price;
        _quantity_needed = quantity_needed;
    }

    public void DisplayProductPrice()
    {
        Console.WriteLine($"Product ID: {_prod_id} - {_quantity_needed,2} {_name,-20}");
    }

    // Function to return total cost? input: none; output: cost of quantity items
    public double GetCost()
    {
        return _price * _quantity_needed;
    }

}

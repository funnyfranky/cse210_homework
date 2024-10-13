using System;

namespace Foundation2;

public class Order(Customer customer)
{
    private Customer _customer = customer;
    private List<Product> _product = [];

    public void AddToOrder(string name, int prod_id, double price, int quantity_needed)
    {
        name = name.ToUpper();
        _product.Add(new(name, prod_id, price, quantity_needed));
        // Console.WriteLine($"Added {name} to order.");
    }

    // Function to calculate total cost
    public double CalcTotalCost()
    {
        double tempVal = 0;
        foreach (Product p in _product)
        {
            tempVal += p.GetCost();
        }
        Console.WriteLine($"Subtotal: ${tempVal}");
        if (_customer.IsInUSA()) { Console.WriteLine($"Shipping: $5"); tempVal += 5; } 
        else { Console.WriteLine($"Shipping: $35"); tempVal += 35; }
        return tempVal; 
        }
    public void PrintTotalCost()
    {
        Console.WriteLine($"Total cost: ${CalcTotalCost()}\n");
    }
    // Prints a string for the packing label
    public void PrintPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product p in _product)
        {
            p.DisplayProductPrice();
        } 
        PrintTotalCost();
    }

    // Returns a string for the shipping label
    public void PrintShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_customer.GetMailingAddress() + "\n");
    }

}